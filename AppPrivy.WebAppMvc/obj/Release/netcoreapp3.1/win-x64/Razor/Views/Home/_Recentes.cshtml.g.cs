#pragma checksum "E:\PROJETOS\NetCore\AppPrivy\AppPrivy.WebAppMvc\Views\Home\_Recentes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a057847a23eb22afaf1a62b839ed0b74bd773419"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__Recentes), @"mvc.1.0.view", @"/Views/Home/_Recentes.cshtml")]
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
#line 1 "E:\PROJETOS\NetCore\AppPrivy\AppPrivy.WebAppMvc\Views\_ViewImports.cshtml"
using AppPrivy.WebAppMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\PROJETOS\NetCore\AppPrivy\AppPrivy.WebAppMvc\Views\_ViewImports.cshtml"
using AppPrivy.WebAppMvc.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\PROJETOS\NetCore\AppPrivy\AppPrivy.WebAppMvc\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a057847a23eb22afaf1a62b839ed0b74bd773419", @"/Views/Home/_Recentes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecd829dd3b64d7430413dd535fd635bc1cc4d4d9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__Recentes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", "~/css/projetos_recentes.css", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/commons/divider-recent-experience.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a057847a23eb22afaf1a62b839ed0b74bd7734194438", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.Href = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 2 "E:\PROJETOS\NetCore\AppPrivy\AppPrivy.WebAppMvc\Views\Home\_Recentes.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"


<div class=""recent-background go-center"">

    <div class=""container"">

        <div class=""row"">
            <div class=""col-md-12 aui-top-exp-rec mt-1 mb-1 clearfix"">
                <h1 class=""text-muted go-center "">experiências recentes</h1>
                <div class=""go-center"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a057847a23eb22afaf1a62b839ed0b74bd7734196708", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\" row col-md-12 aui-top-thumb-rec go-center\">\r\n\r\n            <div class=\"col-md-4\">\r\n                <div class=\"card\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\'", 796, "\'", 864, 1);
#nullable restore
#line 22 "E:\PROJETOS\NetCore\AppPrivy\AppPrivy.WebAppMvc\Views\Home\_Recentes.cshtml"
WriteAttributeValue("", 802, Url.Content("~/Images/portfolio/bradesco/carteira_stelo.png"), 802, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""card-img-top"" alt=""Carteira Stelo"" style=""width:100%;height:190px"" />
                    <div class=""card-body aui-background"">
                        <h3 class=""card-title go-center"">Bradesco</h3>
                        <p class=""card-text go-center"">Construção de páginas web e campanhas para o cliente Bradesco</p>
                    </div>
                </div>
            </div>


            <div class=""col-md-4"">
                <div class=""card"">
                    <img");
            BeginWriteAttribute("src", " src=\'", 1370, "\'", 1439, 1);
#nullable restore
#line 33 "E:\PROJETOS\NetCore\AppPrivy\AppPrivy.WebAppMvc\Views\Home\_Recentes.cshtml"
WriteAttributeValue("", 1376, Url.Content("~/Images/portfolio/cdhu/ca_cabecalho_rodape.png"), 1376, 63, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""card-img-top"" alt=""CDHU"" style=""min-width:100%;min-height:190px""  />
                    <div class=""card-body aui-background"">
                        <h3 class=""card-title go-center"">CDHU</h3>
                        <p class=""card-text go-center"">Desenvolvimento de sistema de gestor de conteúdo para CDHU</p>
                    </div>
                </div>
            </div>



            <div class=""col-md-4"">
                <div class=""card"">
                    <img");
            BeginWriteAttribute("src", " src=\'", 1939, "\'", 2016, 1);
#nullable restore
#line 45 "E:\PROJETOS\NetCore\AppPrivy\AppPrivy.WebAppMvc\Views\Home\_Recentes.cshtml"
WriteAttributeValue("", 1945, Url.Content("~/Images/portfolio/secretariahabitacao/fale_conosco.png"), 1945, 71, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""card-img-top "" alt=""Secretária da Habitação"" style=""min-width:100%;min-height:190px"" />
                    <div class=""card-body aui-background"">
                        <h3 class=""card-title go-center"">Sec.da Habitação</h3>
                        <p class=""card-text go-center"">Funcionalidade de Fale Conosco para a Secretária da Habitação</p>

                    </div>
                </div>
            </div>
        </div>

        <div class=""row"">
            <div class=""col-md-12 ui-top-botton"">
                <div>
                    <a");
            BeginWriteAttribute("href", " href=\"", 2591, "\"", 2629, 1);
#nullable restore
#line 58 "E:\PROJETOS\NetCore\AppPrivy\AppPrivy.WebAppMvc\Views\Home\_Recentes.cshtml"
WriteAttributeValue("", 2598, Url.Action("Portfolio","Home"), 2598, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <h3 class=\"aui-top-button-all go-center\">ver todos</h3>\r\n                    </a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n\r\n");
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
