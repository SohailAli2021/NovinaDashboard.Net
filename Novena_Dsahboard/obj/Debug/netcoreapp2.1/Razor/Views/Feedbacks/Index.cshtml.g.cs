#pragma checksum "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\Feedbacks\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "345ecac8eb30e371b2507a4ae0ea3fc25b4468b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Feedbacks_Index), @"mvc.1.0.view", @"/Views/Feedbacks/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Feedbacks/Index.cshtml", typeof(AspNetCore.Views_Feedbacks_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"345ecac8eb30e371b2507a4ae0ea3fc25b4468b7", @"/Views/Feedbacks/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5545406e6a55b109e0d4beda68b1bd5920802db", @"/Views/_ViewImports.cshtml")]
    public class Views_Feedbacks_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Novena_Dsahboard.Models.Feedback>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\Feedbacks\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(97, 20, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n");
            EndContext();
#line 9 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\Feedbacks\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(171, 1671, true);
            WriteLiteral(@"
<section class=""is-title-bar"">
    <div class=""flex flex-col md:flex-row items-center justify-between space-y-6 md:space-y-0"">
        <ul>
            <li>Admin</li>
            <li>Tables</li>
        </ul>
        <!-- <a href=""https://justboil.me/"" onclick=""alert('Coming soon'); return false"" target=""_blank"" class=""button blue"">
          <span class=""icon""><i class=""mdi mdi-credit-card-outline""></i></span>
          <span>Premium Demo</span>
        </a> -->
    </div>
</section>

<section class=""is-hero-bar"">
    <div class=""flex flex-col md:flex-row items-center justify-between space-y-6 md:space-y-0"">
        <h1 class=""title"">
            Tables
        </h1>
    </div>
</section>

<section class=""section main-section"">
    <div class=""notification blue"">
        <div class=""flex flex-col md:flex-row items-center justify-between space-y-3 md:space-y-0"">
            <div>
                <span class=""icon""><i class=""mdi mdi-buffer""></i></span>
                <b>Table</b>
");
            WriteLiteral(@"            </div>
        </div>
    </div>
    <div class=""card has-table"">
        <header class=""card-header"">
            <p class=""card-header-title"">
                <span class=""icon""><i class=""mdi mdi-account-multiple""></i></span>
                Feedbacks Form Details
            </p>
            <a href=""#"" class=""card-header-icon"">
                <span class=""icon""><i class=""mdi mdi-reload""></i></span>
            </a>
        </header>
        <div class=""card-content"">
            <table class=""table"">
                <thead>
                    <tr>
                        <th>
                            ");
            EndContext();
            BeginContext(1843, 44, false);
#line 58 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\Feedbacks\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(1887, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(1979, 48, false);
#line 61 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\Feedbacks\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.EmailAddress));

#line default
#line hidden
            EndContext();
            BeginContext(2027, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(2119, 44, false);
#line 64 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\Feedbacks\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.PhoneNum));

#line default
#line hidden
            EndContext();
            BeginContext(2163, 93, true);
            WriteLiteral("\r\n                        </th>\r\n\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(2257, 47, false);
#line 68 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\Feedbacks\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.YourMassage));

#line default
#line hidden
            EndContext();
            BeginContext(2304, 146, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th></th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
            EndContext();
#line 74 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\Feedbacks\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(2523, 96, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2620, 43, false);
#line 78 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\Feedbacks\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(2663, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2767, 47, false);
#line 81 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\Feedbacks\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.EmailAddress));

#line default
#line hidden
            EndContext();
            BeginContext(2814, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2918, 43, false);
#line 84 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\Feedbacks\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.PhoneNum));

#line default
#line hidden
            EndContext();
            BeginContext(2961, 105, true);
            WriteLiteral("\r\n                            </td>\r\n\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(3067, 46, false);
#line 88 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\Feedbacks\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.YourMassage));

#line default
#line hidden
            EndContext();
            BeginContext(3113, 396, true);
            WriteLiteral(@"
                            </td>
                            <td>
                            </td>
                            <td class=""actions-cell"">
                                <div class=""buttons right nowrap"">
                                    <button class=""button small green --jb-modal"" data-target=""sample-modal-2"" type=""button"">
                                        ");
            EndContext();
            BeginContext(3509, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "345ecac8eb30e371b2507a4ae0ea3fc25b4468b712334", async() => {
                BeginContext(3557, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 95 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\Feedbacks\Index.cshtml"
                                                                  WriteLiteral(item.ID);

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
            BeginContext(3568, 212, true);
            WriteLiteral("\r\n                                    </button>\r\n                                    <button class=\"button small red --jb-modal\" data-target=\"sample-modal\" type=\"button\">\r\n                                        ");
            EndContext();
            BeginContext(3780, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "345ecac8eb30e371b2507a4ae0ea3fc25b4468b714942", async() => {
                BeginContext(3827, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 98 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\Feedbacks\Index.cshtml"
                                                                 WriteLiteral(item.ID);

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
            BeginContext(3837, 157, true);
            WriteLiteral("\r\n                                    </button>\r\n                                </div>\r\n                            </td>\r\n\r\n                        </tr>\r\n");
            EndContext();
#line 104 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\Feedbacks\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(4017, 592, true);
            WriteLiteral(@"                </tbody>
            </table>

            <div class=""table-pagination"">
                <div class=""flex items-center justify-between"">
                    <div class=""buttons"">
                        <button type=""button"" class=""button active"">1</button>
                        <button type=""button"" class=""button"">2</button>
                        <button type=""button"" class=""button"">3</button>
                    </div>
                    <small>Page 1 of 3</small>
                </div>
            </div>
        </div>
    </div>

</section>

");
            EndContext();
            BeginContext(5830, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Novena_Dsahboard.Models.Feedback>> Html { get; private set; }
    }
}
#pragma warning restore 1591
