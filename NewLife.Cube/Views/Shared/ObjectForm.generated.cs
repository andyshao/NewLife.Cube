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
    
    #line 2 "..\..\Views\Shared\ObjectForm.cshtml"
    using System.ComponentModel;
    
    #line default
    #line hidden
    using System.IO;
    using System.Linq;
    using System.Net;
    
    #line 3 "..\..\Views\Shared\ObjectForm.cshtml"
    using System.Reflection;
    
    #line default
    #line hidden
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
    using NewLife.Cube;
    
    #line 4 "..\..\Views\Shared\ObjectForm.cshtml"
    using NewLife.Reflection;
    
    #line default
    #line hidden
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/ObjectForm.cshtml")]
    public partial class _Views_Shared_ObjectForm_cshtml : System.Web.Mvc.WebViewPage<NewLife.Cube.ViewModels.ObjectModel>
    {
        public _Views_Shared_ObjectForm_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 5 "..\..\Views\Shared\ObjectForm.cshtml"
  
    Layout = NewLife.Cube.Setting.Current.Layout;

    var obj = Model.Value;
    var dic = Model.Properties;

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 12 "..\..\Views\Shared\ObjectForm.cshtml"
Write(Html.Partial("_Object_Nav", Model));

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n<div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"col-md-12\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"form-horizontal\"");

WriteLiteral(">\r\n");

            
            #line 17 "..\..\Views\Shared\ObjectForm.cshtml"
            
            
            #line default
            #line hidden
            
            #line 17 "..\..\Views\Shared\ObjectForm.cshtml"
             using (Html.BeginForm("Update", null))
            {
                
            
            #line default
            #line hidden
            
            #line 19 "..\..\Views\Shared\ObjectForm.cshtml"
           Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 19 "..\..\Views\Shared\ObjectForm.cshtml"
                                        
                
            
            #line default
            #line hidden
            
            #line 20 "..\..\Views\Shared\ObjectForm.cshtml"
           Write(Html.ValidationSummary(true));

            
            #line default
            #line hidden
            
            #line 20 "..\..\Views\Shared\ObjectForm.cshtml"
                                             
                foreach (var item in dic)
                {
                    if (dic.Count > 1)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" class=\"form-group col-sm-12 col-md-12 col-xd-12\"");

WriteLiteral(">\r\n                            <label");

WriteLiteral(" class=\"control-label col-xs-2 col-md-3 no-padding-left\"");

WriteLiteral(">\r\n                                <h2>");

            
            #line 27 "..\..\Views\Shared\ObjectForm.cshtml"
                               Write(item.Key);

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n                            </label>\r\n                        </div>\r\n");

            
            #line 30 "..\..\Views\Shared\ObjectForm.cshtml"
                    }
                    foreach (var pi in item.Value)
                    {
                        var name = pi.Name;
                        var dis = pi.GetDisplayName();
                        var des = pi.GetDescription();
                        if (dis.IsNullOrEmpty() && !des.IsNullOrEmpty()) { dis = des; des = null; }
                        if (!dis.IsNullOrEmpty() && des.IsNullOrEmpty() && dis.Contains("。"))
                        {
                            des = dis.Substring("。");
                            dis = dis.Substring(null, "。");
                        }

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" class=\"form-group col-sm-12 col-md-12\"");

WriteLiteral(">\r\n                            <label");

WriteLiteral(" class=\"control-label col-xs-2 col-md-3 no-padding-left\"");

WriteAttribute("for", Tuple.Create(" for=\"", 1764), Tuple.Create("\"", 1778)
            
            #line 43 "..\..\Views\Shared\ObjectForm.cshtml"
                , Tuple.Create(Tuple.Create("", 1770), Tuple.Create<System.Object, System.Int32>(pi.Name
            
            #line default
            #line hidden
, 1770), false)
);

WriteLiteral(">");

            
            #line 43 "..\..\Views\Shared\ObjectForm.cshtml"
                                                                                                      Write(dis ?? pi.Name);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                            <div");

WriteLiteral(" class=\"input-group col-xs-10 col-md-4\"");

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 45 "..\..\Views\Shared\ObjectForm.cshtml"
                           Write(Html.ForEditor(pi.Name, obj.GetValue(pi), pi.PropertyType));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                                ");

            
            #line 46 "..\..\Views\Shared\ObjectForm.cshtml"
                           Write(Html.ValidationMessage(pi.Name));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </div>\r\n                            <span");

WriteLiteral(" class=\"hidden-xs col-md-5\"");

WriteLiteral(">&nbsp; ");

            
            #line 48 "..\..\Views\Shared\ObjectForm.cshtml"
                                                               Write(des);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                        </div>\r\n");

            
            #line 50 "..\..\Views\Shared\ObjectForm.cshtml"
                    }
                }
                if (this.Has(PermissionFlags.Update))
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"clearfix form-actions col-sm-12 col-md-12\"");

WriteLiteral(">\r\n                        <label");

WriteLiteral(" class=\"control-label col-xs-4 col-sm-5 col-md-5\"");

WriteLiteral("></label>\r\n                        <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-success\"");

WriteLiteral("><i");

WriteLiteral(" class=\"glyphicon glyphicon-save\"");

WriteLiteral("></i><strong>保存</strong></button>\r\n                        <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-danger\"");

WriteLiteral(" onclick=\"history.go(-1);\"");

WriteLiteral("><i");

WriteLiteral(" class=\"glyphicon glyphicon-remove\"");

WriteLiteral("></i><strong>取消</strong></button>\r\n                    </div>\r\n");

            
            #line 59 "..\..\Views\Shared\ObjectForm.cshtml"
                }
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
