﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using NewLife;
    
    #line 1 "..\..\Areas\Admin\Views\User\_Login_Login.cshtml"
    using NewLife.Common;
    
    #line default
    #line hidden
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Admin/Views/User/_Login_Login.cshtml")]
    public partial class _Areas_Admin_Views_User__Login_Login_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_Admin_Views_User__Login_Login_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\Admin\Views\User\_Login_Login.cshtml"
  
    var set = NewLife.Cube.Setting.Current;

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"tab-pane fade in active\"");

WriteLiteral(" id=\"Login\"");

WriteLiteral(">\r\n    <!-- Logo-->\r\n    <div");

WriteLiteral(" class=\"row text-center\"");

WriteLiteral(">\r\n        <i");

WriteLiteral(" class=\"glyphicon glyphicon-cloud login-logo center-block\"");

WriteLiteral(" style=\"display: inline-block;\"");

WriteLiteral("></i>\r\n        ");

WriteLiteral("\r\n    </div>\r\n    <!-- 登录-->\r\n");

            
            #line 12 "..\..\Areas\Admin\Views\User\_Login_Login.cshtml"
    
            
            #line default
            #line hidden
            
            #line 12 "..\..\Areas\Admin\Views\User\_Login_Login.cshtml"
     using (Html.BeginForm("Login", "User", new { r = ViewBag.ReturnUrl }, FormMethod.Post, new { @class = "cube-login" }))
    {
        if (ViewBag.IsShowTip)
        {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"alert alert-block alert-success\"");

WriteLiteral(">\r\n            默认账号：<span");

WriteLiteral(" class=\"orange\"");

WriteLiteral(">admin</span>；默认密码：<span");

WriteLiteral(" class=\"orange\"");

WriteLiteral(">admin</span>\r\n        </div>\r\n");

            
            #line 19 "..\..\Areas\Admin\Views\User\_Login_Login.cshtml"
        }
        
            
            #line default
            #line hidden
            
            #line 20 "..\..\Areas\Admin\Views\User\_Login_Login.cshtml"
   Write(Html.ValidationSummary());

            
            #line default
            #line hidden
            
            #line 20 "..\..\Areas\Admin\Views\User\_Login_Login.cshtml"
                                 

            
            #line default
            #line hidden
WriteLiteral("        <span");

WriteLiteral(" class=\"heading text-primary\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 883), Tuple.Create("\"", 892)
, Tuple.Create(Tuple.Create("", 890), Tuple.Create<System.Object, System.Int32>(Href("~/")
, 890), false)
);

WriteLiteral(">");

            
            #line 21 "..\..\Areas\Admin\Views\User\_Login_Login.cshtml"
                                                   Write(SysConfig.Current.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</a> 登录</span>\r\n");

            
            #line 22 "..\..\Areas\Admin\Views\User\_Login_Login.cshtml"
        if (set.AllowLogin)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" id=\"username\"");

WriteLiteral(" name=\"username\"");

WriteLiteral(" placeholder=\"用户名 / 邮箱\"");

WriteLiteral(">\r\n                <i");

WriteLiteral(" class=\"glyphicon glyphicon-user\"");

WriteLiteral("></i>\r\n            </div>\r\n");

WriteLiteral("            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" type=\"password\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" id=\"password\"");

WriteLiteral(" name=\"password\"");

WriteLiteral(" placeholder=\"密码\"");

WriteLiteral(" autocomplete=\"off\"");

WriteLiteral(">\r\n                <i");

WriteLiteral(" class=\"glyphicon glyphicon-lock\"");

WriteLiteral("></i>\r\n                ");

WriteLiteral("\r\n            </div>\r\n");

WriteLiteral("            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"main-checkbox\"");

WriteLiteral(">\r\n                    <input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" value=\"true\"");

WriteLiteral(" id=\"remember\"");

WriteLiteral(" name=\"remember\"");

WriteLiteral(" />\r\n                    <label");

WriteLiteral(" for=\"remember\"");

WriteLiteral("></label>\r\n                </div>\r\n                <label");

WriteLiteral(" class=\"text text-primary\"");

WriteLiteral(" for=\"remember\"");

WriteLiteral(">记住我</label>\r\n");

            
            #line 39 "..\..\Areas\Admin\Views\User\_Login_Login.cshtml"
                
            
            #line default
            #line hidden
            
            #line 39 "..\..\Areas\Admin\Views\User\_Login_Login.cshtml"
                 if (set.AllowRegister)
                {
                    
            
            #line default
            #line hidden
            
            #line 42 "..\..\Areas\Admin\Views\User\_Login_Login.cshtml"
                                                                             
                    
            
            #line default
            #line hidden
            
            #line 49 "..\..\Areas\Admin\Views\User\_Login_Login.cshtml"
                           

                    if (set.AllowRegister)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" style=\"display: inline-block; margin-top: 5px; float: right;\"");

WriteLiteral(">\r\n                            ");

WriteLiteral("\r\n                            <a");

WriteLiteral(" href=\"#Register\"");

WriteLiteral(" data-toggle=\"tab\"");

WriteLiteral(" style=\"margin-left: auto; margin-right: auto;position: static; font-size: 15px; " +
"margin-top: 5px;\"");

WriteLiteral(">\r\n                                ");

WriteLiteral("\r\n                                <span>我要注册</span>\r\n                            " +
"</a>\r\n                        </div>\r\n");

            
            #line 60 "..\..\Areas\Admin\Views\User\_Login_Login.cshtml"
                    }
                    
            
            #line default
            #line hidden
            
            #line 62 "..\..\Areas\Admin\Views\User\_Login_Login.cshtml"
                                
                }

            
            #line default
            #line hidden
WriteLiteral("                <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-default\"");

WriteLiteral(" style=\"margin: 5px 0 15px 0;width: 100%;\"");

WriteLiteral(">登录</button>\r\n            </div>\r\n");

            
            #line 66 "..\..\Areas\Admin\Views\User\_Login_Login.cshtml"

            if (!set.LoginTip.IsNullOrEmpty())
            {

            
            #line default
            #line hidden
WriteLiteral("                <h4");

WriteLiteral(" class=\"header blue lighter bigger\"");

WriteLiteral(">\r\n                    <i");

WriteLiteral(" class=\"ace-icon fa fa-coffee green\"");

WriteLiteral("></i>\r\n\r\n                </h4>\r\n");

            
            #line 73 "..\..\Areas\Admin\Views\User\_Login_Login.cshtml"


            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"space-6\"");

WriteLiteral("></div>\r\n");

            
            #line 75 "..\..\Areas\Admin\Views\User\_Login_Login.cshtml"


            
            #line default
            #line hidden
WriteLiteral("                <nav");

WriteLiteral(" class=\"navbar navbar-fixed-top\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"alert alert-warning alert-dismissible text-center\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" style=\"margin-bottom:0px;\"");

WriteLiteral(">\r\n                        <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"close\"");

WriteLiteral(" data-dismiss=\"alert\"");

WriteLiteral(" aria-label=\"Close\"");

WriteLiteral("><span");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">&times;</span></button>\r\n");

WriteLiteral("                        ");

            
            #line 79 "..\..\Areas\Admin\Views\User\_Login_Login.cshtml"
                   Write(Html.Raw(set.LoginTip));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </nav>\r\n");

            
            #line 82 "..\..\Areas\Admin\Views\User\_Login_Login.cshtml"
            }
        }
    }

            
            #line default
            #line hidden
WriteLiteral("</div>");

        }
    }
}
#pragma warning restore 1591
