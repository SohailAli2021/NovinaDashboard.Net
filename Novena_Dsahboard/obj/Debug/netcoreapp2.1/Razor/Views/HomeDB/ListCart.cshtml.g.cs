#pragma checksum "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\HomeDB\ListCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "227af8ce4f5d9ca39881e7a546a704d1705f42da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HomeDB_ListCart), @"mvc.1.0.view", @"/Views/HomeDB/ListCart.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/HomeDB/ListCart.cshtml", typeof(AspNetCore.Views_HomeDB_ListCart))]
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
#line 1 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\_ViewImports.cshtml"
using Novena_Dsahboard;

#line default
#line hidden
#line 2 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\_ViewImports.cshtml"
using Novena_Dsahboard.Models;

#line default
#line hidden
#line 3 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\_ViewImports.cshtml"
using Novena_Dsahboard.ViewModel;

#line default
#line hidden
#line 4 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore;

#line default
#line hidden
#line 5 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 6 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.TagHelpers;

#line default
#line hidden
#line 8 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#line 9 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"227af8ce4f5d9ca39881e7a546a704d1705f42da", @"/Views/HomeDB/ListCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5545406e6a55b109e0d4beda68b1bd5920802db", @"/Views/_ViewImports.cshtml")]
    public class Views_HomeDB_ListCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "HomeDB", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "deleteCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("tyle", new global::Microsoft.AspNetCore.Html.HtmlString("text-align:center;font-size:25px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-main btn-round"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "checkouts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\HomeDB\ListCart.cshtml"
  
    ViewData["Title"] = "ListCart";
    Layout = "~/Views/Shared/_LayoutWeb.cshtml";

#line default
#line hidden
            BeginContext(94, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(96, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "227af8ce4f5d9ca39881e7a546a704d1705f42da8157", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(138, 324, true);
            WriteLiteral(@"
<script>
    $(document).ready(function () {
        $("".updateCart"").click(function (event) {
            event.preventDefault();
            var quantity = $("".quantity_"" + $(this).attr(""data-id"")).val();
            console.log(quantity);
            $.ajax({
                type: ""POST"",
                url:""");
            EndContext();
            BeginContext(463, 33, false);
#line 15 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\HomeDB\ListCart.cshtml"
                Write(Url.Action("updateCart","HomeDB"));

#line default
#line hidden
            EndContext();
            BeginContext(496, 228, true);
            WriteLiteral("\",\r\n                data: {\r\n                    id: $(this).attr(\"data-id\"),\r\n                    quantity:quantity\r\n                },\r\n                success: function (result) {\r\n                    window.location.href = \'");
            EndContext();
            BeginContext(725, 31, false);
#line 21 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\HomeDB\ListCart.cshtml"
                                       Write(Url.Action("ListCart","HomeDB"));

#line default
#line hidden
            EndContext();
            BeginContext(756, 1089, true);
            WriteLiteral(@"';
                }
            });
        });
    });
</script>

<section class=""section main-section"">
    <h3 style=""text-align:center""><b>Your Cart</b></h3>
    <div class=""card has-table"">
      
        <div class=""card-content"">
            <table class=""table"">
                <thead>
                    <tr>
                        <th>
                            STT
                        </th>
                        <th>
                            Title
                        </th>
                        <th>
                            Image
                        </th>
                        <th>
                            Quantity
                        </th>
                        <th>
                            Price
                        </th>
                        <th>
                       Total Price
                        </th>
                        <th>
                            Delete
                        </th>
             ");
            WriteLiteral("       </tr>\r\n                </thead>\r\n                <tbody>\r\n");
            EndContext();
#line 60 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\HomeDB\ListCart.cshtml"
                      
                        int STT = 0;
                        foreach (var item in ViewBag.carts)
                        {
                            string txt_class = "quantity_" + item.Product.Id;
                            STT++;
                            float total = item.Product.Price * item.qty;

#line default
#line hidden
            BeginContext(2184, 70, true);
            WriteLiteral("                            <tr>\r\n                                <td>");
            EndContext();
            BeginContext(2255, 3, false);
#line 68 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\HomeDB\ListCart.cshtml"
                               Write(STT);

#line default
#line hidden
            EndContext();
            BeginContext(2258, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2302, 18, false);
#line 69 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\HomeDB\ListCart.cshtml"
                               Write(item.Product.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2320, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2363, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "227af8ce4f5d9ca39881e7a546a704d1705f42da13338", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2373, "~/imgProduct/", 2373, 13, true);
#line 70 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\HomeDB\ListCart.cshtml"
AddHtmlAttributeValue("", 2386, item.Product.ProImage, 2386, 22, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2437, 63, true);
            WriteLiteral("</td>\r\n                                <td><input type=\"number\"");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2500, "\"", 2518, 1);
#line 71 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\HomeDB\ListCart.cshtml"
WriteAttributeValue("", 2508, txt_class, 2508, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 2519, "\"", 2536, 1);
#line 71 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\HomeDB\ListCart.cshtml"
WriteAttributeValue("", 2527, item.qty, 2527, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2537, 46, true);
            WriteLiteral(" /></td>\r\n                                <td>");
            EndContext();
            BeginContext(2584, 18, false);
#line 72 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\HomeDB\ListCart.cshtml"
                               Write(item.Product.Price);

#line default
#line hidden
            EndContext();
            BeginContext(2602, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2646, 5, false);
#line 73 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\HomeDB\ListCart.cshtml"
                               Write(total);

#line default
#line hidden
            EndContext();
            BeginContext(2651, 77, true);
            WriteLiteral("</td>\r\n                              \r\n\r\n                                <td>");
            EndContext();
            BeginContext(2728, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "227af8ce4f5d9ca39881e7a546a704d1705f42da16868", async() => {
                BeginContext(2811, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 76 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\HomeDB\ListCart.cshtml"
                                                                                         WriteLiteral(item.Product.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2821, 42, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n");
            EndContext();
#line 78 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\HomeDB\ListCart.cshtml"
                        }
                    

#line default
#line hidden
            BeginContext(2913, 90, true);
            WriteLiteral("\r\n\r\n\r\n                </tbody>\r\n            </table>\r\n\r\n\r\n        </div>\r\n    </div>\r\n    ");
            EndContext();
            BeginContext(3003, 142, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "227af8ce4f5d9ca39881e7a546a704d1705f42da19944", async() => {
                BeginContext(3124, 17, true);
                WriteLiteral("Continue Shopping");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3145, 8, true);
            WriteLiteral("\r\n\r\n    ");
            EndContext();
            BeginContext(3153, 136, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "227af8ce4f5d9ca39881e7a546a704d1705f42da21710", async() => {
                BeginContext(3277, 8, true);
                WriteLiteral("Checkout");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3289, 36, true);
            WriteLiteral("\r\n\r\n</section>\r\n\r\n\r\n\r\n              ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591