#pragma checksum "D:\TFS-Project-2022-23\ONLINE_ERP\auOLERP_Client\OLERP_Client\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46c9627bb2a6b15a55ed9f998c9f47ca7e6fed0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\TFS-Project-2022-23\ONLINE_ERP\auOLERP_Client\OLERP_Client\Views\_ViewImports.cshtml"
using OLERP_Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\TFS-Project-2022-23\ONLINE_ERP\auOLERP_Client\OLERP_Client\Views\_ViewImports.cshtml"
using OLERP_Client.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46c9627bb2a6b15a55ed9f998c9f47ca7e6fed0b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87949ceb4fcbdb91c23ce9c54d5c9e9cdfb95e74", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserLogin>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\TFS-Project-2022-23\ONLINE_ERP\auOLERP_Client\OLERP_Client\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";


#line default
#line hidden
#nullable disable
            WriteLiteral("<div style=\"padding-top:50px;\"></div>\r\n<div style=\"padding:50px;\">\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-4 col-md-4 col-sm-4\">\r\n            <div>\r\n");
#nullable restore
#line 11 "D:\TFS-Project-2022-23\ONLINE_ERP\auOLERP_Client\OLERP_Client\Views\Home\Index.cshtml"
                 using (Html.BeginForm("procLogins", "Home", FormMethod.Post, new { role = "form" }))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div>\r\n                    ");
#nullable restore
#line 14 "D:\TFS-Project-2022-23\ONLINE_ERP\auOLERP_Client\OLERP_Client\Views\Home\Index.cshtml"
               Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div>\r\n                        <label>Username</label>\r\n                    </div>\r\n                    <div>\r\n                        ");
#nullable restore
#line 19 "D:\TFS-Project-2022-23\ONLINE_ERP\auOLERP_Client\OLERP_Client\Views\Home\Index.cshtml"
                   Write(Html.TextBoxFor(m => m.Username, new { @class = "form-control textbox" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div style=\"padding-top:20px;\"></div>\r\n                    <div>\r\n                        <label>Password</label>\r\n                    </div>\r\n                    <div>\r\n                        ");
#nullable restore
#line 26 "D:\TFS-Project-2022-23\ONLINE_ERP\auOLERP_Client\OLERP_Client\Views\Home\Index.cshtml"
                   Write(Html.TextBoxFor(m => m.Password, new { @class = "form-control textbox" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
                <div style=""padding-left:35%;width:40%;"">
                    <div style=""padding-top:20px;"">
                        <input class=""btn btn-primary btn-lg rph-login-button"" type=""submit"" value=""Login""/>
                    </div>
                </div>
");
#nullable restore
#line 34 "D:\TFS-Project-2022-23\ONLINE_ERP\auOLERP_Client\OLERP_Client\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserLogin> Html { get; private set; }
    }
}
#pragma warning restore 1591
