#pragma checksum "/Users/cthulhu/Documents/Dojo/C#/ASP.NET/ASPIntro/Views/Home/index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "755a6c6c2afa18127cdb36bf6408c7f860362867"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_index), @"mvc.1.0.view", @"/Views/Home/index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/index.cshtml", typeof(AspNetCore.Views_Home_index))]
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
#line 1 "/Users/cthulhu/Documents/Dojo/C#/ASP.NET/ASPIntro/Views/_ViewImports.cshtml"
using ASPIntro;

#line default
#line hidden
#line 2 "/Users/cthulhu/Documents/Dojo/C#/ASP.NET/ASPIntro/Views/_ViewImports.cshtml"
using ASPIntro.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"755a6c6c2afa18127cdb36bf6408c7f860362867", @"/Views/Home/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c65b782d6cdbc49d94e1a06d5be80eece6585fd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomePage>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 2, true);
            WriteLiteral("\n\n");
            EndContext();
            BeginContext(83, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(129, 34, true);
            WriteLiteral("\n<!DOCTYPE html>\n<html lang=\"en\">\n");
            EndContext();
            BeginContext(163, 191, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "755a6c6c2afa18127cdb36bf6408c7f8603628674331", async() => {
                BeginContext(169, 135, true);
                WriteLiteral("\n    <meta charset=\"UTF-8\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\n    <title>Document</title>\n    ");
                EndContext();
                BeginContext(304, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "755a6c6c2afa18127cdb36bf6408c7f8603628674850", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
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
                BeginContext(346, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(354, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(355, 447, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "755a6c6c2afa18127cdb36bf6408c7f8603628676941", async() => {
                BeginContext(361, 27, true);
                WriteLiteral("\n    <h1 class=\"red\">Hello ");
                EndContext();
                BeginContext(389, 23, false);
#line 17 "/Users/cthulhu/Documents/Dojo/C#/ASP.NET/ASPIntro/Views/Home/index.cshtml"
                     Write(Model.Tourist.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(412, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(414, 22, false);
#line 17 "/Users/cthulhu/Documents/Dojo/C#/ASP.NET/ASPIntro/Views/Home/index.cshtml"
                                              Write(Model.Tourist.LastName);

#line default
#line hidden
                EndContext();
                BeginContext(436, 33, true);
                WriteLiteral("</h1>\n\n    <h2 class=\"red\">Hello ");
                EndContext();
                BeginContext(470, 24, false);
#line 19 "/Users/cthulhu/Documents/Dojo/C#/ASP.NET/ASPIntro/Views/Home/index.cshtml"
                     Write(Model.Tourist.FullName());

#line default
#line hidden
                EndContext();
                BeginContext(494, 16, true);
                WriteLiteral("</h2>\n\n    <ul>\n");
                EndContext();
#line 22 "/Users/cthulhu/Documents/Dojo/C#/ASP.NET/ASPIntro/Views/Home/index.cshtml"
         foreach (Destination destination in Model.TravelDestinations)
        {

#line default
#line hidden
                BeginContext(591, 43, true);
                WriteLiteral("                <li>\n                    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 634, "\"", 666, 2);
                WriteAttributeValue("", 641, "/travel/", 641, 8, true);
#line 25 "/Users/cthulhu/Documents/Dojo/C#/ASP.NET/ASPIntro/Views/Home/index.cshtml"
WriteAttributeValue("", 649, destination.Name, 649, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(667, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(669, 16, false);
#line 25 "/Users/cthulhu/Documents/Dojo/C#/ASP.NET/ASPIntro/Views/Home/index.cshtml"
                                                   Write(destination.Name);

#line default
#line hidden
                EndContext();
                BeginContext(685, 27, true);
                WriteLiteral("</a>\n                </li>\n");
                EndContext();
#line 27 "/Users/cthulhu/Documents/Dojo/C#/ASP.NET/ASPIntro/Views/Home/index.cshtml"
        }

#line default
#line hidden
                BeginContext(722, 73, true);
                WriteLiteral("    </ul>\n\n    <div>\n        <a href=\"/register\">Register</a>\n    </div>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(802, 8, true);
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomePage> Html { get; private set; }
    }
}
#pragma warning restore 1591
