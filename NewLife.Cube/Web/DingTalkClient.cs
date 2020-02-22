﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using NewLife.Log;
using NewLife.Model;
using NewLife.Remoting;
using NewLife.Serialization;
using NewLife.Web;
using XCode.Membership;

namespace NewLife.Cube.Web
{
    /// <summary>钉钉身份验证提供者</summary>
    public class DingTalkClient : OAuthClient
    {
        static DingTalkClient()
        {
            // 输出帮助日志
            XTrace.WriteLine("钉钉登录分多种方式，由Scope参数区分。");
            XTrace.WriteLine("Scope=snsapi_qrlogin, 扫码登录");
            XTrace.WriteLine("Scope=snsapi_login, 密码登录");
            XTrace.WriteLine("Scope=snsapi_auth, 钉钉内免登");
        }

        /// <summary>实例化</summary>
        public DingTalkClient()
        {
            Name = "Ding";
            Server = "https://oapi.dingtalk.com/connect/oauth2/";

            AuthUrl = "sns_authorize?appid={key}&response_type=code&scope={scope}&state={state}&redirect_uri={redirect}";
            AccessUrl = null;
            OpenIDUrl = null;
            AccessUrl = "https://oapi.dingtalk.com/sns/getuserinfo_bycode?accessKey={key}&timestamp={timestamp}&signature={signature}";
        }

        /// <summary>应用参数</summary>
        /// <param name="mi"></param>
        public override void Apply(OAuthItem mi)
        {
            base.Apply(mi);

            SetMode(Scope);
        }

        /// <summary>设置工作模式</summary>
        /// <param name="mode"></param>
        public virtual void SetMode(String mode)
        {
            switch (mode)
            {
                // 扫码登录
                case "snsapi_qrlogin":
                    Server = "https://oapi.dingtalk.com/connect/";
                    AuthUrl = "qrconnect?appid={key}&response_type=code&scope=snsapi_login&state={state}&redirect_uri={redirect}";
                    break;
                // 密码登录
                case "snsapi_login":
                    Server = "https://oapi.dingtalk.com/connect/oauth2/";
                    AuthUrl = "sns_authorize?appid={key}&response_type=code&scope=snsapi_login&state={state}&redirect_uri={redirect}";
                    break;
                // 钉钉内免登
                case "snsapi_auth":
                    Server = "https://oapi.dingtalk.com/connect/oauth2/";
                    AuthUrl = "sns_authorize?appid={key}&response_type=code&scope=snsapi_auth&state={state}&redirect_uri={redirect}";
                    break;
                default:
                    break;
            }
        }

        /// <summary>获取令牌</summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public override String GetAccessToken(String code)
        {
            var url = AccessUrl;
            if (url.IsNullOrEmpty()) throw new ArgumentNullException(nameof(UserUrl), "未设置用户信息地址");

            var ts = DateTime.UtcNow.ToLong() + "";
            var sign = ts.GetBytes().SHA256(Secret.GetBytes()).ToBase64();
            url = url.Replace("{timestamp}", ts).Replace("{signature}", HttpUtility.UrlEncode(sign));

            url = GetUrl(url);

            var tmp_code = new { tmp_auth_code = code };
            WriteLog("GetUserInfo {0} {1}", url, tmp_code.ToJson());

            // 请求OpenId
            var http = new HttpClient();
            var dic = Task.Run(() => http.InvokeAsync<IDictionary<String, Object>>(HttpMethod.Post, url, tmp_code, null, "user_info")).Result;

            if (dic != null)
            {
                NickName = dic["nick"] as String;
                OpenID = dic["openid"] as String;
                UnionID = dic["unionid"] as String;

                Items = dic.ToDictionary(e => e.Key, e => e.Value as String);
            }

            return null;
        }

        #region 服务端Api
        /// <summary>企业内部应用获取凭证，有效期7200秒</summary>
        /// <param name="appkey"></param>
        /// <param name="appsecret"></param>
        /// <returns></returns>
        public static String GetToken(String appkey, String appsecret)
        {
            var url = $"https://oapi.dingtalk.com/gettoken?appkey={appkey}&appsecret={appsecret}";

            var http = new HttpClient();
            return Task.Run(() => http.InvokeAsync<String>(HttpMethod.Get, url, null, null, "access_token")).Result;
        }

        /// <summary>企业内部应用获取用户信息</summary>
        /// <param name="access_token"></param>
        /// <param name="userid">员工id</param>
        /// <returns></returns>
        public IDictionary<String, Object> GetUserInfo(String access_token, String userid)
        {
            var url = $"https://oapi.dingtalk.com/user/get?access_token={access_token}&userid={userid}";

            var http = new HttpClient();
            var buf = Task.Run(() => http.GetAsync<Byte[]>(url)).Result;
            var str = buf.ToStr();
            var js = new JsonParser(str).Decode() as IDictionary<String, Object>;

            UserName = js["name"] + "";
            NickName = js["nick"] + "";
            Avatar = js["avatar"] + "";

            // 合并字典
            var dic = Items;
            if (dic == null)
                Items = js.ToDictionary(e => e.Key, e => e.Value as String);
            else
            {
                foreach (var item in js)
                {
                    if (!dic.ContainsKey(item.Key)) dic[item.Key] = item.Value as String;
                }
            }

            return js;
        }

        /// <summary>填充信息</summary>
        /// <param name="user"></param>
        public override void Fill(IManageUser user)
        {
            var dic = Items;
            if (dic != null && user is UserX user2)
            {
                if (user2.Mail.IsNullOrEmpty() && dic.TryGetValue("email", out var email)) user2.Mail = email;
                if (user2.Mobile.IsNullOrEmpty() && dic.TryGetValue("mobile", out var mobile)) user2.Mobile = mobile;
                if (user2.Code.IsNullOrEmpty() && dic.TryGetValue("jobnumber", out var code)) user2.Code = code;
            }

            base.Fill(user);
        }

        /// <summary>根据unionid获取userid</summary>
        /// <param name="access_token"></param>
        /// <param name="unionId">员工在当前开发者企业账号范围内的唯一标识，系统生成，固定值，不会改变</param>
        /// <returns></returns>
        public static String GetUseridByUnionid(String access_token, String unionId)
        {
            var url = $"https://oapi.dingtalk.com/user/getUseridByUnionid?access_token={access_token}&unionid={unionId}";

            var http = new HttpClient();
            return Task.Run(() => http.InvokeAsync<String>(HttpMethod.Get, url, null, null, "userid")).Result;
        }
        #endregion
    }
}