#pragma checksum "C:\Users\murilo.melo\Desktop\Murilo\2020\LojaVirtual\LojaVirtual\LojaVirtual.Core\Views\Pedido\Carrossel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ce903f4429edbbfb272466b5242b452ca5f3724"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido_Carrossel), @"mvc.1.0.view", @"/Views/Pedido/Carrossel.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pedido/Carrossel.cshtml", typeof(AspNetCore.Views_Pedido_Carrossel))]
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
#line 1 "C:\Users\murilo.melo\Desktop\Murilo\2020\LojaVirtual\LojaVirtual\LojaVirtual.Core\Views\_ViewImports.cshtml"
using LojaVirtual.Core;

#line default
#line hidden
#line 2 "C:\Users\murilo.melo\Desktop\Murilo\2020\LojaVirtual\LojaVirtual\LojaVirtual.Core\Views\_ViewImports.cshtml"
using LojaVirtual.Core.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ce903f4429edbbfb272466b5242b452ca5f3724", @"/Views/Pedido/Carrossel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77532f82260305d3e4aeb33ec219f92f20e37a3f", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido_Carrossel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Produto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 213, true);
            WriteLiteral("<h3>Catálogo</h3>\r\n\r\n\r\n<div id=\"my-carousel\" class=\"carousel slide\" data-ride=\"carousel\">\r\n    <!-- Wrapper for slides -->\r\n    <div class=\"carousel-inner\" role=\"listbox\">\r\n   <!-- paginacao tela de carrosel -->\r\n");
            EndContext();
#line 9 "C:\Users\murilo.melo\Desktop\Murilo\2020\LojaVirtual\LojaVirtual\LojaVirtual.Core\Views\Pedido\Carrossel.cshtml"
          
         
            const int TAMANHO_PAGINA = 4;

           int paginas = (int)Math.Ceiling((double)Model.Count() / TAMANHO_PAGINA);
        

#line default
#line hidden
            BeginContext(400, 47, true);
            WriteLiteral("          <!-- paginacao tela de carrosel -->\r\n");
            EndContext();
#line 16 "C:\Users\murilo.melo\Desktop\Murilo\2020\LojaVirtual\LojaVirtual\LojaVirtual.Core\Views\Pedido\Carrossel.cshtml"
         for (int pagina = 0; pagina < paginas; pagina++)
        {
  


#line default
#line hidden
            BeginContext(523, 51, true);
            WriteLiteral("  <!-- paginacao tela de carrosel -->\r\n        <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 574, "\"", 616, 2);
            WriteAttributeValue("", 582, "item", 582, 4, true);
#line 21 "C:\Users\murilo.melo\Desktop\Murilo\2020\LojaVirtual\LojaVirtual\LojaVirtual.Core\Views\Pedido\Carrossel.cshtml"
WriteAttributeValue(" ", 586, pagina ==0 ? "active" : "", 587, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(617, 73, true);
            WriteLiteral(">\r\n            <div class=\"row\">\r\n  <!-- paginacao tela de carrosel -->\r\n");
            EndContext();
#line 24 "C:\Users\murilo.melo\Desktop\Murilo\2020\LojaVirtual\LojaVirtual\LojaVirtual.Core\Views\Pedido\Carrossel.cshtml"
                  
                    var produtosDaPagina = Model.Skip(pagina * TAMANHO_PAGINA).Take(TAMANHO_PAGINA);
                

#line default
#line hidden
            BeginContext(831, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 27 "C:\Users\murilo.melo\Desktop\Murilo\2020\LojaVirtual\LojaVirtual\LojaVirtual.Core\Views\Pedido\Carrossel.cshtml"
                 foreach (var item in produtosDaPagina)
                {

#line default
#line hidden
            BeginContext(907, 241, true);
            WriteLiteral("                    <div class=\"col-md-3 col-sm-3 col-lg-3\">\r\n                        <div class=\"panel panel-default\">\r\n                            <div class=\"panel-body\">\r\n                                <img class=\"img-produto-carrossel\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1148, "\"", 1195, 3);
            WriteAttributeValue("", 1154, "/images/produtos/large_", 1154, 23, true);
#line 32 "C:\Users\murilo.melo\Desktop\Murilo\2020\LojaVirtual\LojaVirtual\LojaVirtual.Core\Views\Pedido\Carrossel.cshtml"
WriteAttributeValue("", 1177, item.Codigo, 1177, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 1191, ".jpg", 1191, 4, true);
            EndWriteAttribute();
            BeginContext(1196, 170, true);
            WriteLiteral(" />\r\n                            </div>\r\n                            <div class=\"panel-footer produto-footer\">\r\n                                <div class=\"produto-nome\">");
            EndContext();
            BeginContext(1367, 9, false);
#line 35 "C:\Users\murilo.melo\Desktop\Murilo\2020\LojaVirtual\LojaVirtual\LojaVirtual.Core\Views\Pedido\Carrossel.cshtml"
                                                     Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1376, 60, true);
            WriteLiteral("</div>\r\n                                <div><h4><strong>R$ ");
            EndContext();
            BeginContext(1437, 10, false);
#line 36 "C:\Users\murilo.melo\Desktop\Murilo\2020\LojaVirtual\LojaVirtual\LojaVirtual.Core\Views\Pedido\Carrossel.cshtml"
                                               Write(item.Preco);

#line default
#line hidden
            EndContext();
            BeginContext(1447, 304, true);
            WriteLiteral(@"</strong></h4></div>
                                <div class=""text-center"">
                                    <a href=""/"" class=""btn btn-success"">Adicionar</a>
                                </div>
                            </div>
                        </div>
                    </div>
");
            EndContext();
#line 43 "C:\Users\murilo.melo\Desktop\Murilo\2020\LojaVirtual\LojaVirtual\LojaVirtual.Core\Views\Pedido\Carrossel.cshtml"
                }

#line default
#line hidden
            BeginContext(1770, 42, true);
            WriteLiteral("            </div>\r\n  \r\n\r\n        </div>\r\n");
            EndContext();
#line 48 "C:\Users\murilo.melo\Desktop\Murilo\2020\LojaVirtual\LojaVirtual\LojaVirtual.Core\Views\Pedido\Carrossel.cshtml"
                  
      }

#line default
#line hidden
            BeginContext(1841, 505, true);
            WriteLiteral(@"    </div>


    <!-- Controls -->
    <a class=""left carousel-control"" href=""#my-carousel"" role=""button"" data-slide=""prev"">
        <span class=""glyphicon glyphicon-chevron-left"" aria-hidden=""true""></span>
        <span class=""sr-only"">Previous</span>
    </a>
    <a class=""right carousel-control"" href=""#my-carousel"" role=""button"" data-slide=""next"">
        <span class=""glyphicon glyphicon-chevron-right"" aria-hidden=""true""></span>
        <span class=""sr-only"">Next</span>
    </a>
</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Produto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
