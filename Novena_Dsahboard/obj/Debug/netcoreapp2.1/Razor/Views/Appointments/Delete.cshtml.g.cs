#pragma checksum "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\Appointments\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88625d96cc84faad460ec79dfc5c5651e2b5155a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Appointments_Delete), @"mvc.1.0.view", @"/Views/Appointments/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Appointments/Delete.cshtml", typeof(AspNetCore.Views_Appointments_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88625d96cc84faad460ec79dfc5c5651e2b5155a", @"/Views/Appointments/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5545406e6a55b109e0d4beda68b1bd5920802db", @"/Views/_ViewImports.cshtml")]
    public class Views_Appointments_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Novena_Dsahboard.Models.Appointment>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\Appointments\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(88, 1761, true);
            WriteLiteral(@"<h2>Delete</h2>


<h3>Are you sure you want to delete this?</h3>
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
                <span class=""icon""><i");
            WriteLiteral(@" class=""mdi mdi-buffer""></i></span>
                <b> PriceList </b>
            </div>
        </div>
    </div>
    <div class=""card has-table"">
        <header class=""card-header"">
            <p class=""card-header-title"">
                <span class=""icon""><i class=""mdi mdi-account-multiple""></i></span>
                Are you sure you want to delete this?
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
            BeginContext(1850, 46, false);
#line 56 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\Appointments\Delete.cshtml"
                       Write(Html.DisplayNameFor(model => model.Department));

#line default
#line hidden
            EndContext();
            BeginContext(1896, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(1988, 42, false);
#line 59 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\Appointments\Delete.cshtml"
                       Write(Html.DisplayNameFor(model => model.Doctor));

#line default
#line hidden
            EndContext();
            BeginContext(2030, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(2122, 44, false);
#line 62 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\Appointments\Delete.cshtml"
                       Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(2166, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(2258, 48, false);
#line 65 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\Appointments\Delete.cshtml"
                       Write(Html.DisplayNameFor(model => model.EmailAddress));

#line default
#line hidden
            EndContext();
            BeginContext(2306, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(2398, 44, false);
#line 68 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\Appointments\Delete.cshtml"
                       Write(Html.DisplayNameFor(model => model.PhoneNum));

#line default
#line hidden
            EndContext();
            BeginContext(2442, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(2534, 47, false);
#line 71 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\Appointments\Delete.cshtml"
                       Write(Html.DisplayNameFor(model => model.YourMassage));

#line default
#line hidden
            EndContext();
            BeginContext(2581, 201, true);
            WriteLiteral("\r\n                        </th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n\r\n                    <tr>\r\n\r\n\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2783, 46, false);
#line 81 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\Appointments\Delete.cshtml"
                       Write(Html.DisplayFor(modelItem => Model.Department));

#line default
#line hidden
            EndContext();
            BeginContext(2829, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2921, 42, false);
#line 84 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\Appointments\Delete.cshtml"
                       Write(Html.DisplayFor(modelItem => Model.Doctor));

#line default
#line hidden
            EndContext();
            BeginContext(2963, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3055, 44, false);
#line 87 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\Appointments\Delete.cshtml"
                       Write(Html.DisplayFor(modelItem => Model.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(3099, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3191, 48, false);
#line 90 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\Appointments\Delete.cshtml"
                       Write(Html.DisplayFor(modelItem => Model.EmailAddress));

#line default
#line hidden
            EndContext();
            BeginContext(3239, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3331, 44, false);
#line 93 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\Appointments\Delete.cshtml"
                       Write(Html.DisplayFor(modelItem => Model.PhoneNum));

#line default
#line hidden
            EndContext();
            BeginContext(3375, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3467, 47, false);
#line 96 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\Appointments\Delete.cshtml"
                       Write(Html.DisplayFor(modelItem => Model.YourMassage));

#line default
#line hidden
            EndContext();
            BeginContext(3514, 648, true);
            WriteLiteral(@"
                        </td>


                    </tr>

                </tbody>
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
    ");
            EndContext();
            BeginContext(4162, 211, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88625d96cc84faad460ec79dfc5c5651e2b5155a14703", async() => {
                BeginContext(4188, 12, true);
                WriteLiteral("\r\n\r\n        ");
                EndContext();
                BeginContext(4200, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "88625d96cc84faad460ec79dfc5c5651e2b5155a15100", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 120 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\Appointments\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4236, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(4320, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88625d96cc84faad460ec79dfc5c5651e2b5155a17041", async() => {
                    BeginContext(4342, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
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
                BeginContext(4358, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4373, 16, true);
            WriteLiteral("\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Novena_Dsahboard.Models.Appointment> Html { get; private set; }
    }
}
#pragma warning restore 1591
