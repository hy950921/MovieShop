#pragma checksum "C:\Users\hy199\source\repos\Antra\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e548c335e056238b063b66e34999da2ef83b93bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Details), @"mvc.1.0.view", @"/Views/Movies/Details.cshtml")]
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
#line 1 "C:\Users\hy199\source\repos\Antra\MovieShop\MovieShopMVC\Views\_ViewImports.cshtml"
using MovieShopMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hy199\source\repos\Antra\MovieShop\MovieShopMVC\Views\_ViewImports.cshtml"
using MovieShopMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e548c335e056238b063b66e34999da2ef83b93bd", @"/Views/Movies/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0d2154f16347fb0df8a919e414827cd460665e4", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ApplicationCore.Models.MovieDetailsResponseModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Casts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<style>\n    #poster {\n        display: block;\n        margin-left: auto;\n        margin-right: auto;\n        width:60%\n    }\n    #section {\n        background-image: linear-gradient(rgba(255,255,255,.5), rgba(255,255,255,.5)), url(");
#nullable restore
#line 11 "C:\Users\hy199\source\repos\Antra\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                                                                                      Write(Model.BackdropUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral(")\n    }\n    #title {\n        text-align:center;\n    }\n</style>\n\n<section class=\"container\" id=\"section\" >\n    <div class=\"row\">\n\n        <div class=\"col-lg-4\">\n            <img");
            BeginWriteAttribute("src", " src=\"", 482, "\"", 504, 1);
#nullable restore
#line 22 "C:\Users\hy199\source\repos\Antra\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
WriteAttributeValue("", 488, Model.PosterUrl, 488, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"poster\"");
            BeginWriteAttribute("alt", " alt=\"", 517, "\"", 535, 1);
#nullable restore
#line 22 "C:\Users\hy199\source\repos\Antra\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
WriteAttributeValue("", 523, Model.Title, 523, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n        </div>\n        <div class=\"col-lg-5\">\n            <h4 id=\"title\">");
#nullable restore
#line 25 "C:\Users\hy199\source\repos\Antra\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                      Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n            <span>");
#nullable restore
#line 26 "C:\Users\hy199\source\repos\Antra\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
             Write(Model.Tagline);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> <br />\n            <span>");
#nullable restore
#line 27 "C:\Users\hy199\source\repos\Antra\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
             Write(Model.RunTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" m | ");
#nullable restore
#line 27 "C:\Users\hy199\source\repos\Antra\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                                Write(Model.ReleaseDate.ToString().Substring(5, 5));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> <br />\n            <span>");
#nullable restore
#line 28 "C:\Users\hy199\source\repos\Antra\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
             Write(Model.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> <br />\n            <br />\n            <div>\n                <p>");
#nullable restore
#line 31 "C:\Users\hy199\source\repos\Antra\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
              Write(Model.Overview);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
            </div>

        </div>

        <div class=""col-3 justify-content-center pt-md-5"">
            <div class=""mx-auto mb-3"">
                <button type=""button"" class=""btn btn-outline-secondary btn-block text-white""><i class=""far fa-edit mr-1""></i>REVIEW</button>

            </div>
            <div class=""mx-auto mb-3"">
                <button type=""button"" class=""btn btn-outline-secondary btn-block text-white""><i class=""fas fa-play mr-1""></i>TRAILER</button>

            </div>
            <div class=""mx-auto mb-2"">

                <button type=""button"" class=""btn btn-light btn-block"">BUY 9.90</button>
            </div>
            <div class=""mx-auto"">

                <button type=""button"" class=""btn btn-light btn-block"">WATCH MOVIE</button>
            </div>
        </div>

        <div class=""row "">
            <div class=""col-5 pr-5"">
                <h3>MOVIE FACTS</h3>
                <ul class=""list-group"">
                    <li class=""list-group-item border-left-0 border-right-");
            WriteLiteral("0 rounded-0 border-bottom-dark\">\n                        <i class=\"far fa-calendar-alt mr-2\"></i>Release Date\n                        <span class=\"badge badge-secondary\">");
#nullable restore
#line 61 "C:\Users\hy199\source\repos\Antra\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                                                       Write(Model.ReleaseDate.ToString().Substring(0, 10));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                    </li>\n                    <li class=\"list-group-item border-left-0 border-right-0 rounded-0 border-dark\">\n                        <i class=\"fas fa-hourglass-half mr-2\"></i>Run Time <span class=\"badge badge-secondary\">");
#nullable restore
#line 64 "C:\Users\hy199\source\repos\Antra\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                                                                                                          Write(Model.RunTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" m</span>\n                    </li>\n                    <li class=\"list-group-item border-left-0 border-right-0 rounded-0 border-dark\">\n                        <i class=\"far fa-money-bill-alt mr-2\"></i>Box Office <span class=\"badge badge-secondary\">");
#nullable restore
#line 67 "C:\Users\hy199\source\repos\Antra\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                                                                                                            Write(Model.Revenue.GetValueOrDefault().ToString("C0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                    </li>\n                    <li class=\"list-group-item border-left-0 border-right-0 rounded-0 border-dark\">\n                        <i class=\"fas fa-dollar-sign mr-2\"></i>Budget <span class=\"badge badge-secondary\">");
#nullable restore
#line 70 "C:\Users\hy199\source\repos\Antra\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                                                                                                     Write(Model.Budget.GetValueOrDefault().ToString("C0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  </span>
                    </li>

                </ul>
                <div class=""mt-2"">
                    <i class=""fab fa-imdb pl-2""></i>
                    <i class=""fas fa-sign-out-alt pl-2""></i>
                </div>
            </div>
            <div class=""col pl-5"">
                <h3>CAST</h3>
                <div>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e548c335e056238b063b66e34999da2ef83b93bd10376", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 82 "C:\Users\hy199\source\repos\Antra\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.Casts;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </div>\n            </div>\n        </div>\n\n    </div>\n</section>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ApplicationCore.Models.MovieDetailsResponseModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
