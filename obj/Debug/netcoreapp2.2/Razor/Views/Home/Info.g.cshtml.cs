#pragma checksum "/media/thethup/KINGSTON/coding/coding-dojo/c#/aspMvc/dojoSurveyy/Views/Home/Info.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a14686ce8c45550c6e43213b99b641646ecc298"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Info), @"mvc.1.0.view", @"/Views/Home/Info.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Info.cshtml", typeof(AspNetCore.Views_Home_Info))]
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
#line 1 "/media/thethup/KINGSTON/coding/coding-dojo/c#/aspMvc/dojoSurveyy/Views/Home/Info.cshtml"
using dojoSurveyy.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a14686ce8c45550c6e43213b99b641646ecc298", @"/Views/Home/Info.cshtml")]
    public class Views_Home_Info : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Survey>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/info.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(40, 35, true);
            WriteLiteral("\n\n<!DOCTYPE html>\n<html lang=\"en\">\n");
            EndContext();
            BeginContext(75, 258, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a14686ce8c45550c6e43213b99b641646ecc2983866", async() => {
                BeginContext(81, 199, true);
                WriteLiteral("\n    <meta charset=\"UTF-8\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\n    <meta http-equiv=\"X-UA-Compatible\" content=\"ie=edge\">\n    <title>Submitted Info</title>\n    ");
                EndContext();
                BeginContext(280, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6a14686ce8c45550c6e43213b99b641646ecc2984453", async() => {
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
                BeginContext(325, 1, true);
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
            BeginContext(333, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(334, 593, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a14686ce8c45550c6e43213b99b641646ecc2986544", async() => {
                BeginContext(340, 78, true);
                WriteLiteral("\n    <div class=\"info\">\n        <h1 class=\"submittedInfo\">Submitted Info</h1>\n");
                EndContext();
                BeginContext(429, 75, true);
                WriteLiteral("            <p class=\"name\">Name:</p>\n            <p class=\"submittedName\">");
                EndContext();
                BeginContext(505, 10, false);
#line 19 "/media/thethup/KINGSTON/coding/coding-dojo/c#/aspMvc/dojoSurveyy/Views/Home/Info.cshtml"
                                Write(Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(515, 97, true);
                WriteLiteral("</p>\n            <p class=\"location\">Dojo Location:</p>\n            <p class=\"submittedLocation\">");
                EndContext();
                BeginContext(613, 14, false);
#line 21 "/media/thethup/KINGSTON/coding/coding-dojo/c#/aspMvc/dojoSurveyy/Views/Home/Info.cshtml"
                                    Write(Model.Location);

#line default
#line hidden
                EndContext();
                BeginContext(627, 101, true);
                WriteLiteral("</p>\n            <p class=\"language\">Favorite Language:</p>\n            <p class=\"submittedLanguage\">");
                EndContext();
                BeginContext(729, 14, false);
#line 23 "/media/thethup/KINGSTON/coding/coding-dojo/c#/aspMvc/dojoSurveyy/Views/Home/Info.cshtml"
                                    Write(Model.Language);

#line default
#line hidden
                EndContext();
                BeginContext(743, 89, true);
                WriteLiteral("</p>\n            <p class=\"comment\">Comment:</p>\n            <p class=\"submittedComment\">");
                EndContext();
                BeginContext(833, 13, false);
#line 25 "/media/thethup/KINGSTON/coding/coding-dojo/c#/aspMvc/dojoSurveyy/Views/Home/Info.cshtml"
                                   Write(Model.Comment);

#line default
#line hidden
                EndContext();
                BeginContext(846, 5, true);
                WriteLiteral("</p>\n");
                EndContext();
                BeginContext(861, 59, true);
                WriteLiteral("        <a class=\"goBack\" href=\"/\">Go Back</a>\n    </div>\n\n");
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
            BeginContext(927, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Survey> Html { get; private set; }
    }
}
#pragma warning restore 1591
