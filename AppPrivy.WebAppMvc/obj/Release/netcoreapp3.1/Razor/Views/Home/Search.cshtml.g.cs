#pragma checksum "H:\PROJETOS\NetCore\AppPrivy\AppPrivy.WebAppMvc\Views\Home\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46be3a634e35b9ca1c94ecc553ab4c3ebf919e20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Search), @"mvc.1.0.view", @"/Views/Home/Search.cshtml")]
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
#nullable restore
#line 3 "H:\PROJETOS\NetCore\AppPrivy\AppPrivy.WebAppMvc\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46be3a634e35b9ca1c94ecc553ab4c3ebf919e20", @"/Views/Home/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecd829dd3b64d7430413dd535fd635bc1cc4d4d9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AppPrivy.Application.ViewsModels.PesquisaViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "H:\PROJETOS\NetCore\AppPrivy\AppPrivy.WebAppMvc\Views\Home\Search.cshtml"
  
    ViewBag.Title = "Pesquisa";

 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container-fluid  margin-footer clearfix\">\r\n\r\n    <div class=\"container page-header  mt-5 mb-3\">\r\n      \r\n        <h1>Pesquisa<small class=\"text-muted\">  - resultados encontrados (");
#nullable restore
#line 12 "H:\PROJETOS\NetCore\AppPrivy\AppPrivy.WebAppMvc\Views\Home\Search.cshtml"
                                                                            if (Model != null)
            {

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "H:\PROJETOS\NetCore\AppPrivy\AppPrivy.WebAppMvc\Views\Home\Search.cshtml"
        Write(Html.Raw(Model.Count().ToString()));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "H:\PROJETOS\NetCore\AppPrivy\AppPrivy.WebAppMvc\Views\Home\Search.cshtml"
                                                ;
        }
        else
        { 

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "H:\PROJETOS\NetCore\AppPrivy\AppPrivy.WebAppMvc\Views\Home\Search.cshtml"
     Write(Html.Raw("0"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "H:\PROJETOS\NetCore\AppPrivy\AppPrivy.WebAppMvc\Views\Home\Search.cshtml"
                        ;
    } 

#line default
#line hidden
#nullable disable
            WriteLiteral(") </small></h1><hr />\r\n\r\n    </div>\r\n\r\n    <div class=\"container\" id=\"container\">\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-md-12\">\r\n\r\n");
#nullable restore
#line 26 "H:\PROJETOS\NetCore\AppPrivy\AppPrivy.WebAppMvc\Views\Home\Search.cshtml"
                 if (@Model!=null && Model.Count()>0) {
               

                    for (int i = 0; i < Model.Count(); i++)
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div  class=\"shadow-sm p-3 mb-5 bg-white rounded  border-left-1 border-info float-left\">\r\n                            <h4 class=\"text-dark\">");
#nullable restore
#line 33 "H:\PROJETOS\NetCore\AppPrivy\AppPrivy.WebAppMvc\Views\Home\Search.cshtml"
                                             Write(Model.ElementAt(i).Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                            <p class=\"text-muted\">");
#nullable restore
#line 34 "H:\PROJETOS\NetCore\AppPrivy\AppPrivy.WebAppMvc\Views\Home\Search.cshtml"
                                             Write(Model.ElementAt(i).Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <hr class=\"my-4\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1114, "\"", 1168, 1);
#nullable restore
#line 36 "H:\PROJETOS\NetCore\AppPrivy\AppPrivy.WebAppMvc\Views\Home\Search.cshtml"
WriteAttributeValue("", 1121, string.Format("{0}", Model.ElementAt(i).Url), 1121, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-secondary float-right\">Saber mais </a>\r\n                        </div>\r\n");
#nullable restore
#line 38 "H:\PROJETOS\NetCore\AppPrivy\AppPrivy.WebAppMvc\Views\Home\Search.cshtml"

                      

                    }

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AppPrivy.Application.ViewsModels.PesquisaViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591