#pragma checksum "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\HomeDB\ImmumeMedicine.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec3dc28ec2758405afeedab417c470b562b8fbcf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HomeDB_ImmumeMedicine), @"mvc.1.0.view", @"/Views/HomeDB/ImmumeMedicine.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/HomeDB/ImmumeMedicine.cshtml", typeof(AspNetCore.Views_HomeDB_ImmumeMedicine))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec3dc28ec2758405afeedab417c470b562b8fbcf", @"/Views/HomeDB/ImmumeMedicine.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5545406e6a55b109e0d4beda68b1bd5920802db", @"/Views/_ViewImports.cshtml")]
    public class Views_HomeDB_ImmumeMedicine : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Novena_Dsahboard.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-align:center;font-size:15px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-group-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "HomeDB", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "addCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("addProduct"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(55, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 5 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\HomeDB\ImmumeMedicine.cshtml"
   Layout = "~/Views/Shared/_LayoutWeb.cshtml"; 

#line default
#line hidden
            BeginContext(110, 123, true);
            WriteLiteral("\r\n\r\n\r\n<br />\r\n<br />\r\n\r\n\r\n\r\n\r\n<section class=\"section service-2\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n");
            EndContext();
#line 18 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\HomeDB\ImmumeMedicine.cshtml"
             foreach (var Pro in Model)
            {

#line default
#line hidden
            BeginContext(289, 136, true);
            WriteLiteral("                <div class=\"col-lg-4 col-md-4 col-sm-4\">\r\n                    <div class=\"service-block mb-5\">\r\n                        ");
            EndContext();
            BeginContext(425, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ec3dc28ec2758405afeedab417c470b562b8fbcf8095", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 435, "~/imgProduct/", 435, 13, true);
#line 22 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\HomeDB\ImmumeMedicine.cshtml"
AddHtmlAttributeValue("", 448, Pro.ProImage, 448, 13, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(488, 111, true);
            WriteLiteral("\r\n                        <div class=\"content\">\r\n                            <h4 class=\"mt-1 mb-2 title-color\">");
            EndContext();
            BeginContext(600, 9, false);
#line 24 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\HomeDB\ImmumeMedicine.cshtml"
                                                         Write(Pro.Title);

#line default
#line hidden
            EndContext();
            BeginContext(609, 51, true);
            WriteLiteral("</h4>\r\n                            <p class=\"mb-1\">");
            EndContext();
            BeginContext(661, 9, false);
#line 25 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\HomeDB\ImmumeMedicine.cshtml"
                                       Write(Pro.Price);

#line default
#line hidden
            EndContext();
            BeginContext(670, 50, true);
            WriteLiteral("</p>\r\n                            <p class=\"mb-1\">");
            EndContext();
            BeginContext(721, 15, false);
#line 26 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\HomeDB\ImmumeMedicine.cshtml"
                                       Write(Pro.Description);

#line default
#line hidden
            EndContext();
            BeginContext(736, 50, true);
            WriteLiteral("</p>\r\n                            <p class=\"mb-1\">");
            EndContext();
            BeginContext(787, 12, false);
#line 27 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\HomeDB\ImmumeMedicine.cshtml"
                                       Write(Pro.Catagory);

#line default
#line hidden
            EndContext();
            BeginContext(799, 34, true);
            WriteLiteral("</p>\r\n                            ");
            EndContext();
            BeginContext(833, 172, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec3dc28ec2758405afeedab417c470b562b8fbcf11765", async() => {
                BeginContext(990, 11, true);
                WriteLiteral("Add To Cart");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 28 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\HomeDB\ImmumeMedicine.cshtml"
                                                                                                                                                 WriteLiteral(Pro.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1005, 86, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 32 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\HomeDB\ImmumeMedicine.cshtml"
            }

#line default
#line hidden
            BeginContext(1106, 44, true);
            WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Novena_Dsahboard.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
