#pragma checksum "C:\Users\saite\Desktop\cricZee\cricZee\cricZee\Views\Quizzs\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f347bdf15b45b7fe9174d29cf4e447395b798b29"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Quizzs_Index), @"mvc.1.0.view", @"/Views/Quizzs/Index.cshtml")]
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
#line 1 "C:\Users\saite\Desktop\cricZee\cricZee\cricZee\Views\_ViewImports.cshtml"
using cricZee;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\saite\Desktop\cricZee\cricZee\cricZee\Views\_ViewImports.cshtml"
using cricZee.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f347bdf15b45b7fe9174d29cf4e447395b798b29", @"/Views/Quizzs/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed208f4f8e8abe4082edb360fb6c4de649e3acc5", @"/Views/_ViewImports.cshtml")]
    public class Views_Quizzs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<cricZee.Quizz>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/quizz.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\saite\Desktop\cricZee\cricZee\cricZee\Views\Quizzs\Index.cshtml"
  
    ViewData["Title"] = "Index";
    


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1> Quizz </h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f347bdf15b45b7fe9174d29cf4e447395b798b294329", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f347bdf15b45b7fe9174d29cf4e447395b798b294591", async() => {
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
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f347bdf15b45b7fe9174d29cf4e447395b798b296477", async() => {
                WriteLiteral("\r\n<table class=\"table table-dark table-striped\">\r\n\r\n    <tbody>\r\n");
#nullable restore
#line 19 "C:\Users\saite\Desktop\cricZee\cricZee\cricZee\Views\Quizzs\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td>\r\n\r\n                    ");
#nullable restore
#line 24 "C:\Users\saite\Desktop\cricZee\cricZee\cricZee\Views\Quizzs\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Ques));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <input type=\"radio\" id=\"Option1\"");
                BeginWriteAttribute("name", " name=\"", 502, "\"", 550, 1);
#nullable restore
#line 27 "C:\Users\saite\Desktop\cricZee\cricZee\cricZee\Views\Quizzs\Index.cshtml"
WriteAttributeValue(" ", 509, Html.DisplayFor(modelItem => item.Ques), 510, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"rb\"");
                BeginWriteAttribute("value", " value=\"", 562, "\"", 614, 1);
#nullable restore
#line 27 "C:\Users\saite\Desktop\cricZee\cricZee\cricZee\Views\Quizzs\Index.cshtml"
WriteAttributeValue(" ", 570, Html.DisplayFor(modelItem => item.Option1), 571, 43, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    ");
#nullable restore
#line 28 "C:\Users\saite\Desktop\cricZee\cricZee\cricZee\Views\Quizzs\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Option1));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n\r\n                    <input type=\"radio\" id=\"Option2\"");
                BeginWriteAttribute("name", " name=\"", 784, "\"", 832, 1);
#nullable restore
#line 32 "C:\Users\saite\Desktop\cricZee\cricZee\cricZee\Views\Quizzs\Index.cshtml"
WriteAttributeValue(" ", 791, Html.DisplayFor(modelItem => item.Ques), 792, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"rb\"");
                BeginWriteAttribute("value", " value=\"", 844, "\"", 896, 1);
#nullable restore
#line 32 "C:\Users\saite\Desktop\cricZee\cricZee\cricZee\Views\Quizzs\Index.cshtml"
WriteAttributeValue(" ", 852, Html.DisplayFor(modelItem => item.Option2), 853, 43, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    ");
#nullable restore
#line 33 "C:\Users\saite\Desktop\cricZee\cricZee\cricZee\Views\Quizzs\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Option2));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <input type=\"radio\" id=\"Option3\"");
                BeginWriteAttribute("name", " name=\"", 1064, "\"", 1112, 1);
#nullable restore
#line 36 "C:\Users\saite\Desktop\cricZee\cricZee\cricZee\Views\Quizzs\Index.cshtml"
WriteAttributeValue(" ", 1071, Html.DisplayFor(modelItem => item.Ques), 1072, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"rb\"");
                BeginWriteAttribute("value", " value=\"", 1124, "\"", 1176, 1);
#nullable restore
#line 36 "C:\Users\saite\Desktop\cricZee\cricZee\cricZee\Views\Quizzs\Index.cshtml"
WriteAttributeValue(" ", 1132, Html.DisplayFor(modelItem => item.Option3), 1133, 43, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n                    ");
#nullable restore
#line 38 "C:\Users\saite\Desktop\cricZee\cricZee\cricZee\Views\Quizzs\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Option3));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <input type=\"radio\" id=\"Option4\"");
                BeginWriteAttribute("name", " name=\"", 1346, "\"", 1394, 1);
#nullable restore
#line 41 "C:\Users\saite\Desktop\cricZee\cricZee\cricZee\Views\Quizzs\Index.cshtml"
WriteAttributeValue(" ", 1353, Html.DisplayFor(modelItem => item.Ques), 1354, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"rb\"");
                BeginWriteAttribute("value", " value=\"", 1406, "\"", 1458, 1);
#nullable restore
#line 41 "C:\Users\saite\Desktop\cricZee\cricZee\cricZee\Views\Quizzs\Index.cshtml"
WriteAttributeValue(" ", 1414, Html.DisplayFor(modelItem => item.Option4), 1415, 43, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    ");
#nullable restore
#line 42 "C:\Users\saite\Desktop\cricZee\cricZee\cricZee\Views\Quizzs\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Option4));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    <label id=\"corrections\"");
                BeginWriteAttribute("name", " name=\"", 1656, "\"", 1704, 1);
#nullable restore
#line 48 "C:\Users\saite\Desktop\cricZee\cricZee\cricZee\Views\Quizzs\Index.cshtml"
WriteAttributeValue(" ", 1663, Html.DisplayFor(modelItem => item.Ques), 1664, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"rb\" style=\"display:none;color:forestgreen;\"><b>");
#nullable restore
#line 48 "C:\Users\saite\Desktop\cricZee\cricZee\cricZee\Views\Quizzs\Index.cshtml"
                                                                                                                                              Write(Html.DisplayFor(modelItem => item.Correct));

#line default
#line hidden
#nullable disable
                WriteLiteral("</b></label>\r\n                </td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 52 "C:\Users\saite\Desktop\cricZee\cricZee\cricZee\Views\Quizzs\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    </tbody>
</table>

<button type=""button"" id=""buttonexam"" class=""btn-success"" onclick=""displayresult();"">
    Submit
</button>

<label id=""useranswers""></label>
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>

<script>
    $(document).ready(function () {
        $(""#buttonexam"").click(function () {
            $("".rb"").show();
            $("".rb"").attr(""disabled"", true);
        });
    });
    </script>

");
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
            WriteLiteral("\r\n        ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<cricZee.Quizz>> Html { get; private set; }
    }
}
#pragma warning restore 1591
