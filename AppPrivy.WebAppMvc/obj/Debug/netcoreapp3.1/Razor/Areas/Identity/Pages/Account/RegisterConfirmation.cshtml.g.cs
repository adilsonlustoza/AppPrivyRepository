#pragma checksum "H:\PROJETOS\NetCore\AppPrivy\AppPrivy.WebAppMvc\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9528fd84d512264c2572340de6f51309a0df975c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_RegisterConfirmation), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml")]
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
#line 1 "H:\PROJETOS\NetCore\AppPrivy\AppPrivy.WebAppMvc\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\PROJETOS\NetCore\AppPrivy\AppPrivy.WebAppMvc\Areas\Identity\Pages\_ViewImports.cshtml"
using AppPrivy.WebAppMvc.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "H:\PROJETOS\NetCore\AppPrivy\AppPrivy.WebAppMvc\Areas\Identity\Pages\_ViewImports.cshtml"
using AppPrivy.WebAppMvc.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "H:\PROJETOS\NetCore\AppPrivy\AppPrivy.WebAppMvc\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using AppPrivy.WebAppMvc.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9528fd84d512264c2572340de6f51309a0df975c", @"/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2046d9d6f4d2f58784a6e5d5bdeeabbc45403380", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc2a450b737909cc771544529f36966cfe2b5264", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_RegisterConfirmation : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "H:\PROJETOS\NetCore\AppPrivy\AppPrivy.WebAppMvc\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
  
    ViewData["Title"] = "Confirmação de registro";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div class=\"container-fluid margin-footer\">\r\n\r\n    <div class=\"container page-header  mt-5 mb-3\">\r\n\r\n        <h1>");
#nullable restore
#line 13 "H:\PROJETOS\NetCore\AppPrivy\AppPrivy.WebAppMvc\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
       Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("<small class=\"text-muted\"> -  verifique a mensagem abaixo </small></h1><hr />\r\n\r\n\r\n    </div>\r\n\r\n    <div class=\"container\" id=\"container\">\r\n\r\n        <div class=\"col-md-12\">\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col-md-12\">\r\n");
#nullable restore
#line 24 "H:\PROJETOS\NetCore\AppPrivy\AppPrivy.WebAppMvc\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
                      
                        if (@Model.DisplayConfirmAccountLink)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <p>
                                This app does not currently have a real email sender registered, see <a href=""https://aka.ms/aspaccountconf"">these docs</a> for how to configure a real email sender.
                                Normally this would be emailed: <a id=""confirm-link""");
            BeginWriteAttribute("href", " href=\"", 917, "\"", 951, 1);
#nullable restore
#line 29 "H:\PROJETOS\NetCore\AppPrivy\AppPrivy.WebAppMvc\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
WriteAttributeValue("", 924, Model.EmailConfirmationUrl, 924, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Clique aqui para confirmar o seu e-mail</a>\r\n                            </p>\r\n");
#nullable restore
#line 31 "H:\PROJETOS\NetCore\AppPrivy\AppPrivy.WebAppMvc\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>\r\n                                Verifique seu e-mail para confirmar seu registro.\r\n                            </p>\r\n");
#nullable restore
#line 37 "H:\PROJETOS\NetCore\AppPrivy\AppPrivy.WebAppMvc\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n\r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterConfirmationModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterConfirmationModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterConfirmationModel>)PageContext?.ViewData;
        public RegisterConfirmationModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
