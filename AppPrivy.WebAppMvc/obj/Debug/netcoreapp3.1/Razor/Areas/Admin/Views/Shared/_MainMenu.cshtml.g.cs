#pragma checksum "H:\PROJETOS\NetCore\AppPrivy\AppPrivy.WebAppMvc\Areas\Admin\Views\Shared\_MainMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "815649cf5acc75bb344c68e253cb118d7c3902a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__MainMenu), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_MainMenu.cshtml")]
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
#line 2 "H:\PROJETOS\NetCore\AppPrivy\AppPrivy.WebAppMvc\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"815649cf5acc75bb344c68e253cb118d7c3902a1", @"/Areas/Admin/Views/Shared/_MainMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"869301d97ad83df9cb8990426390ecd70d6afcde", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared__MainMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<ul class=""sidebar-menu"" data-widget=""tree"">
    <li class=""header"">Menu</li>
    <!-- Optionally, you can add icons to the links -->
    <li class=""treeview"">
        <a href=""#"">
            <i class=""fa fa-user""></i> <span>Pacientes</span>
            <span class=""pull-right-container"">
                <i class=""fa fa-angle-left pull-right""></i>
            </span>
        </a>
        <ul class=""treeview-menu"">
            <li><a href=""/Pacientes/Create"">Incluir Novo</a></li>
            <li><a href=""/Pacientes"">Exibir Todos</a></li>
        </ul>
    </li>
</ul>");
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
