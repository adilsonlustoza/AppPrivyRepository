#pragma checksum "E:\PROJETOS\NetCore\AppPrivy\AppPrivy.WebAppMvc\Areas\Identity\Pages\Account\Logout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f69c92da32b8abbf83cf00ac266f6c146af7e482"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_Logout), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/Logout.cshtml")]
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
#line 1 "E:\PROJETOS\NetCore\AppPrivy\AppPrivy.WebAppMvc\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\PROJETOS\NetCore\AppPrivy\AppPrivy.WebAppMvc\Areas\Identity\Pages\_ViewImports.cshtml"
using AppPrivy.WebAppMvc.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\PROJETOS\NetCore\AppPrivy\AppPrivy.WebAppMvc\Areas\Identity\Pages\_ViewImports.cshtml"
using AppPrivy.WebAppMvc.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\PROJETOS\NetCore\AppPrivy\AppPrivy.WebAppMvc\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using AppPrivy.WebAppMvc.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f69c92da32b8abbf83cf00ac266f6c146af7e482", @"/Areas/Identity/Pages/Account/Logout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2046d9d6f4d2f58784a6e5d5bdeeabbc45403380", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc2a450b737909cc771544529f36966cfe2b5264", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Logout : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\PROJETOS\NetCore\AppPrivy\AppPrivy.WebAppMvc\Areas\Identity\Pages\Account\Logout.cshtml"
  
    ViewData["Title"] = "Sair ";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container-fluid margin-footer\">\r\n\r\n    <div class=\"container page-header  mt-5 mb-3\">\r\n\r\n        <h1>");
#nullable restore
#line 12 "E:\PROJETOS\NetCore\AppPrivy\AppPrivy.WebAppMvc\Areas\Identity\Pages\Account\Logout.cshtml"
       Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<small class=""text-muted""> -  verifique a mensagem abaixo </small></h1><hr />


    </div>

    <div class=""container"" id=""container"">

        <div class=""col-md-12"">

            <div class=""row"">
                <div class=""col-md-12"">
                    <p class=""text-danger"">Você abandonou da aplicação.</p>
                </div>
            </div>

        </div>

    </div>

</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LogoutModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LogoutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LogoutModel>)PageContext?.ViewData;
        public LogoutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
