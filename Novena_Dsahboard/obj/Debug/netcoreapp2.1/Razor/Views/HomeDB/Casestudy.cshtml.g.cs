#pragma checksum "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\HomeDB\Casestudy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f5f5a23656efbb70561beeae9af7967b7f61bde"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HomeDB_Casestudy), @"mvc.1.0.view", @"/Views/HomeDB/Casestudy.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/HomeDB/Casestudy.cshtml", typeof(AspNetCore.Views_HomeDB_Casestudy))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f5f5a23656efbb70561beeae9af7967b7f61bde", @"/Views/HomeDB/Casestudy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5545406e6a55b109e0d4beda68b1bd5920802db", @"/Views/_ViewImports.cshtml")]
    public class Views_HomeDB_Casestudy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Novena_Dsahboard.Models.Casestudy>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\HomeDB\Casestudy.cshtml"
   Layout = "~/Views/Shared/_LayoutWeb.cshtml"; 

#line default
#line hidden
            BeginContext(105, 982, true);
            WriteLiteral(@"




<section class=""page-title bg-1"">
    <div class=""overlay""></div>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""block text-center"">
                    <span class=""text-white"">Our blog</span>
                    <h1 class=""text-capitalize mb-5 text-lg"">Blog articles</h1>

                    <!-- <ul class=""list-inline breadcumb-nav"">
                      <li class=""list-inline-item""><a href=""index.html"" class=""text-white"">Home</a></li>
                      <li class=""list-inline-item""><span class=""text-white"">/</span></li>
                      <li class=""list-inline-item""><a href=""#"" class=""text-white-50"">Our blog</a></li>
                    </ul> -->
                </div>
            </div>
        </div>
    </div>
</section>

<section class=""section blog-wrap"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-8"">
                <div class=""row"">
");
            EndContext();
#line 34 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\HomeDB\Casestudy.cshtml"
                     foreach (var Blog in Model)
                    {

#line default
#line hidden
            BeginContext(1158, 176, true);
            WriteLiteral("                <div class=\"col-lg-12 col-md-12 mb-5\">\n                    <div class=\"blog-item\">\n                        <div class=\"blog-thumb\">\n                            ");
            EndContext();
            BeginContext(1334, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6f5f5a23656efbb70561beeae9af7967b7f61bde7060", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1344, "~/imgblog/", 1344, 10, true);
#line 39 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\HomeDB\Casestudy.cshtml"
AddHtmlAttributeValue("", 1354, Blog.Image, 1354, 11, false);

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
            BeginContext(1393, 272, true);
            WriteLiteral(@"
                        </div>

                        <div class=""blog-item-content"">
                            <div class=""blog-item-meta mb-3 mt-4"">

                                <span class=""text-black text-capitalize mr-3""><i class=""icofont-calendar mr-1""></i>");
            EndContext();
            BeginContext(1666, 9, false);
#line 45 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\HomeDB\Casestudy.cshtml"
                                                                                                              Write(Blog.Date);

#line default
#line hidden
            EndContext();
            BeginContext(1675, 122, true);
            WriteLiteral(" </span>\n                            </div>\n\n                            <h2 class=\"mt-3 mb-3\"><a href=\"blog-single.html\">");
            EndContext();
            BeginContext(1798, 10, false);
#line 48 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\HomeDB\Casestudy.cshtml"
                                                                        Write(Blog.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1808, 54, true);
            WriteLiteral("</a></h2>\n                            <p class=\"mb-4\">");
            EndContext();
            BeginContext(1863, 16, false);
#line 49 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\HomeDB\Casestudy.cshtml"
                                       Write(Blog.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1879, 86, true);
            WriteLiteral("</p>\n                        </div>\n                    </div>\n                </div>\n");
            EndContext();
#line 53 "C:\Users\sohai\Downloads\Novena_Dsahboard (2)\Novena_Dsahboard\Novena_Dsahboard\Views\HomeDB\Casestudy.cshtml"
                    }

#line default
#line hidden
            BeginContext(1987, 3470, true);
            WriteLiteral(@"                  </div>
            </div>
          <div class=""col-lg-4"">
                <div class=""sidebar-wrap pl-lg-4 mt-5 mt-lg-0"">

                    <div class=""sidebar-widget latest-post mb-3"">
                        <h5>Popular Posts</h5>

                        <div class=""py-2"">
                            <span class=""text-sm text-muted"">03 Mar 2018</span>
                            <h6 class=""my-2""><a href=""#"">Thoughtful living in los Angeles</a></h6>
                        </div>

                        <div class=""py-2"">
                            <span class=""text-sm text-muted"">03 Mar 2018</span>
                            <h6 class=""my-2""><a href=""#"">Vivamus molestie gravida turpis.</a></h6>
                        </div>

                        <div class=""py-2"">
                            <span class=""text-sm text-muted"">03 Mar 2018</span>
                            <h6 class=""my-2""><a href=""#"">Fusce lobortis lorem at ipsum semper sagittis</a></h6>
                        <");
            WriteLiteral(@"/div>
                    </div>




                    <div class=""sidebar-widget tags mb-3"">
                        <h5 class=""mb-4"">Tags</h5>

                        <a href=""#"">Doctors</a>
                        <a href=""#"">agency</a>
                        <a href=""#"">company</a>
                        <a href=""#"">medicine</a>
                        <a href=""#"">surgery</a>
                        <a href=""#"">Marketing</a>
                        <a href=""#"">Social Media</a>
                        <a href=""#"">Branding</a>
                        <a href=""#"">Laboratory</a>
                    </div>


                    <div class=""sidebar-widget schedule-widget mb-3"">
                        <h5 class=""mb-4"">Time Schedule</h5>

                        <ul class=""list-unstyled"">
                            <li class=""d-flex justify-content-between align-items-center"">
                                <a href=""#"">Monday - Friday</a>
                                <span>9:00 - 17:00</span>
         ");
            WriteLiteral(@"                   </li>
                            <li class=""d-flex justify-content-between align-items-center"">
                                <a href=""#"">Saturday</a>
                                <span>9:00 - 16:00</span>
                            </li>
                            <li class=""d-flex justify-content-between align-items-center"">
                                <a href=""#"">Sunday</a>
                                <span>Closed</span>
                            </li>
                        </ul>

                        <div class=""sidebar-contatct-info mt-4"">
                            <p class=""mb-0"">Need Urgent Help?</p>
                            <h3>+23-4565-65768</h3>
                        </div>
                    </div>

                </div>
            </div>
        </div>

        <div class=""row mt-5"">
            <div class=""col-lg-8"">
                <nav class=""pagination py-2 d-inline-block"">
                    <div class=""nav-links"">
                        <");
            WriteLiteral(@"span aria-current=""page"" class=""page-numbers current"">1</span>
                        <a class=""page-numbers"" href=""#"">2</a>
                        <a class=""page-numbers"" href=""#"">3</a>
                        <a class=""page-numbers"" href=""#""><i class=""icofont-thin-double-right""></i></a>
                    </div>
                </nav>
            </div>
        </div>
    </div>
</section>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Novena_Dsahboard.Models.Casestudy>> Html { get; private set; }
    }
}
#pragma warning restore 1591
