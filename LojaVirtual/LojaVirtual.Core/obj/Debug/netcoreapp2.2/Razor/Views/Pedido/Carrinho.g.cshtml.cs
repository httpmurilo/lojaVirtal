#pragma checksum "C:\Users\murilo.melo\Desktop\Murilo\2020\LojaVirtual\LojaVirtual\LojaVirtual.Core\Views\Pedido\Carrinho.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97f47ac1a85ee9cdcceca70c9d6ae8505f84f752"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido_Carrinho), @"mvc.1.0.view", @"/Views/Pedido/Carrinho.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pedido/Carrinho.cshtml", typeof(AspNetCore.Views_Pedido_Carrinho))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97f47ac1a85ee9cdcceca70c9d6ae8505f84f752", @"/Views/Pedido/Carrinho.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77532f82260305d3e4aeb33ec219f92f20e37a3f", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido_Carrinho : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<ItemPedido>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "carrosel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "cadastro", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\murilo.melo\Desktop\Murilo\2020\LojaVirtual\LojaVirtual\LojaVirtual.Core\Views\Pedido\Carrinho.cshtml"
  
    ViewData["Title"] = "Carinho";

#line default
#line hidden
            BeginContext(70, 608, true);
            WriteLiteral(@"<h3>Meu Carrinho</h3>
<div class=""panel panel-default"">
    <div class=""panel-heading"">
        <div class=""row"">
            <div class=""col-md-6"">
                Item
            </div>
            <div class=""col-md-2 text-center"">
                Preço Unitário
            </div>
            <div class=""col-md-2 text-center"">
                Quantidade
            </div>
            <div class=""col-md-2"">
                <span class=""pull-right"">
                    Subtotal
                </span>
            </div>
        </div>
    </div>
    <div class=""panel-body"">


");
            EndContext();
#line 28 "C:\Users\murilo.melo\Desktop\Murilo\2020\LojaVirtual\LojaVirtual\LojaVirtual.Core\Views\Pedido\Carrinho.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(727, 149, true);
            WriteLiteral("            <div class=\"row row-center linha-produto\">\r\n                <div class=\"col-md-3\">\r\n                    <img class=\"img-produto-carrinho\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 876, "\"", 931, 3);
            WriteAttributeValue("", 882, "/images/produtos/large_", 882, 23, true);
#line 32 "C:\Users\murilo.melo\Desktop\Murilo\2020\LojaVirtual\LojaVirtual\LojaVirtual.Core\Views\Pedido\Carrinho.cshtml"
WriteAttributeValue("", 905, item.Produto.Codigo, 905, 22, false);

#line default
#line hidden
            WriteAttributeValue("", 927, ".jpg", 927, 4, true);
            EndWriteAttribute();
            BeginContext(932, 67, true);
            WriteLiteral(" />\r\n                </div>\r\n                <div class=\"col-md-3\">");
            EndContext();
            BeginContext(1000, 17, false);
#line 34 "C:\Users\murilo.melo\Desktop\Murilo\2020\LojaVirtual\LojaVirtual\LojaVirtual.Core\Views\Pedido\Carrinho.cshtml"
                                 Write(item.Produto.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1017, 61, true);
            WriteLiteral("</div>\r\n                <div class=\"col-md-2 text-center\">R$ ");
            EndContext();
            BeginContext(1080, 18, false);
#line 35 "C:\Users\murilo.melo\Desktop\Murilo\2020\LojaVirtual\LojaVirtual\LojaVirtual.Core\Views\Pedido\Carrinho.cshtml"
                                                 Write(item.PrecoUnitario);

#line default
#line hidden
            EndContext();
            BeginContext(1099, 410, true);
            WriteLiteral(@"</div>
                <div class=""col-md-2 text-center"">
                    <div class=""input-group"">
                        <span class=""input-group-btn"">
                            <button class=""btn btn-default"">
                                <span class=""glyphicon-minus""></span>
                            </button>
                        </span>
                        <input type=""text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1509, "\"", 1535, 1);
#line 43 "C:\Users\murilo.melo\Desktop\Murilo\2020\LojaVirtual\LojaVirtual\LojaVirtual.Core\Views\Pedido\Carrinho.cshtml"
WriteAttributeValue("", 1517, item.Quantidade, 1517, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1536, 505, true);
            WriteLiteral(@"
                               class=""form-control text-center"" />
                        <span class=""input-group-btn"">
                            <button class=""btn btn-default"">
                                <span class=""glyphicon-plus""></span>
                            </button>
                        </span>
                    </div>
                </div>
                <div class=""col-md-2"">
                    R$ <span class=""pull-right"" subtotal>
                        ");
            EndContext();
            BeginContext(2043, 36, false);
#line 54 "C:\Users\murilo.melo\Desktop\Murilo\2020\LojaVirtual\LojaVirtual\LojaVirtual.Core\Views\Pedido\Carrinho.cshtml"
                    Write(item.Quantidade * item.PrecoUnitario);

#line default
#line hidden
            EndContext();
            BeginContext(2080, 75, true);
            WriteLiteral("\r\n                    </span>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 58 "C:\Users\murilo.melo\Desktop\Murilo\2020\LojaVirtual\LojaVirtual\LojaVirtual.Core\Views\Pedido\Carrinho.cshtml"
        }

#line default
#line hidden
            BeginContext(2166, 180, true);
            WriteLiteral("        <div class=\"panel-footer\">\r\n            <div class=\"row\">\r\n                <div class=\"col-md-10\">\r\n                    <span numero-itens>\r\n                        Total: ");
            EndContext();
            BeginContext(2348, 13, false);
#line 63 "C:\Users\murilo.melo\Desktop\Murilo\2020\LojaVirtual\LojaVirtual\LojaVirtual.Core\Views\Pedido\Carrinho.cshtml"
                           Write(Model.Count());

#line default
#line hidden
            EndContext();
            BeginContext(2362, 213, true);
            WriteLiteral("\r\n                        itens\r\n                    </span>\r\n                </div>\r\n                <div class=\"col-md-2\">\r\n                    Total: R$ <span class=\"pull-right\" total>\r\n                        ");
            EndContext();
            BeginContext(2577, 46, false);
#line 69 "C:\Users\murilo.melo\Desktop\Murilo\2020\LojaVirtual\LojaVirtual\LojaVirtual.Core\Views\Pedido\Carrinho.cshtml"
                    Write(Model.Sum(i => i.Quantidade * i.PrecoUnitario));

#line default
#line hidden
            EndContext();
            BeginContext(2624, 215, true);
            WriteLiteral("\r\n                    </span>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n\r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <div class=\"pull-right\">\r\n            ");
            EndContext();
            BeginContext(2839, 103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97f47ac1a85ee9cdcceca70c9d6ae8505f84f75210627", async() => {
                BeginContext(2888, 50, true);
                WriteLiteral("\r\n                Adicionar Produtos\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2942, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(2956, 103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97f47ac1a85ee9cdcceca70c9d6ae8505f84f75212146", async() => {
                BeginContext(3005, 50, true);
                WriteLiteral("\r\n                Preencher Cadastro\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3059, 38, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<ItemPedido>> Html { get; private set; }
    }
}
#pragma warning restore 1591
