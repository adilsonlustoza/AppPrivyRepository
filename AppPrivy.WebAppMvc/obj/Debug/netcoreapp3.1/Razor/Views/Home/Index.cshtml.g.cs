#pragma checksum "H:\PROJETOS\NetCore\AppPrivy\AppPrivy.WebAppMvc\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1af9e4809eeeca600a8d917c24e410670f85b2c7"
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
#line 1 "H:\PROJETOS\NetCore\AppPrivy\AppPrivy.WebAppMvc\Views\_ViewImports.cshtml"
using AppPrivy.WebAppMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\PROJETOS\NetCore\AppPrivy\AppPrivy.WebAppMvc\Views\_ViewImports.cshtml"
using AppPrivy.WebAppMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1af9e4809eeeca600a8d917c24e410670f85b2c7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d856fe62581d936797dd271970a191669de61fb1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "H:\PROJETOS\NetCore\AppPrivy\AppPrivy.WebAppMvc\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <div>\r\n        <div  class=\"row\">\r\n");
#nullable restore
#line 7 "H:\PROJETOS\NetCore\AppPrivy\AppPrivy.WebAppMvc\Views\Home\Index.cshtml"
              Html.RenderPartial("_Carrossel");

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>      \r\n    </div>\r\n\r\n    <div>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 13 "H:\PROJETOS\NetCore\AppPrivy\AppPrivy.WebAppMvc\Views\Home\Index.cshtml"
              Html.RenderPartial("_QueFaco");

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n\r\n\r\n    <div>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 20 "H:\PROJETOS\NetCore\AppPrivy\AppPrivy.WebAppMvc\Views\Home\Index.cshtml"
              Html.RenderPartial("_Recentes");

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n\r\n\r\n    <div>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 27 "H:\PROJETOS\NetCore\AppPrivy\AppPrivy.WebAppMvc\Views\Home\Index.cshtml"
              Html.RenderPartial("_Sobre");

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
