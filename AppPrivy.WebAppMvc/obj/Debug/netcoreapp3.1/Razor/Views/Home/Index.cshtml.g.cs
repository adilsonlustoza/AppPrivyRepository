#pragma checksum "C:\CandMountain\AppPrivyRepository\AppPrivy.WebAppMvc\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "527e0114e2839c352bbeed8e090ba6b017d26338"
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
#line 1 "C:\CandMountain\AppPrivyRepository\AppPrivy.WebAppMvc\Views\_ViewImports.cshtml"
using AppPrivy.WebAppMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\CandMountain\AppPrivyRepository\AppPrivy.WebAppMvc\Views\_ViewImports.cshtml"
using AppPrivy.WebAppMvc.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\CandMountain\AppPrivyRepository\AppPrivy.WebAppMvc\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"527e0114e2839c352bbeed8e090ba6b017d26338", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecd829dd3b64d7430413dd535fd635bc1cc4d4d9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 3 "C:\CandMountain\AppPrivyRepository\AppPrivy.WebAppMvc\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <div>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 9 "C:\CandMountain\AppPrivyRepository\AppPrivy.WebAppMvc\Views\Home\Index.cshtml"
               await Html.RenderPartialAsync("_Carrossel");

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n\r\n    <div>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 15 "C:\CandMountain\AppPrivyRepository\AppPrivy.WebAppMvc\Views\Home\Index.cshtml"
              await Html.RenderPartialAsync("_QueFaco");

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n\r\n\r\n    <div>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 22 "C:\CandMountain\AppPrivyRepository\AppPrivy.WebAppMvc\Views\Home\Index.cshtml"
              await Html.RenderPartialAsync("_Recentes");

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n\r\n\r\n    <div>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 29 "C:\CandMountain\AppPrivyRepository\AppPrivy.WebAppMvc\Views\Home\Index.cshtml"
              await Html.RenderPartialAsync("_Sobre");

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
