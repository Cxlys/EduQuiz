#pragma checksum "C:\Users\danie\OneDrive\NEA\please\pleaseoftheloveofgodbethelastversionofthisproject\Pages\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f32d9074681338499af3430726a3c98bf4ed21d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(pleaseoftheloveofgodbethelastversionofthisproject.Pages.Home.Pages_Home_Index), @"mvc.1.0.razor-page", @"/Pages/Home/Index.cshtml")]
namespace pleaseoftheloveofgodbethelastversionofthisproject.Pages.Home
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
#line 1 "C:\Users\danie\OneDrive\NEA\please\pleaseoftheloveofgodbethelastversionofthisproject\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\danie\OneDrive\NEA\please\pleaseoftheloveofgodbethelastversionofthisproject\Pages\_ViewImports.cshtml"
using pleaseoftheloveofgodbethelastversionofthisproject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\danie\OneDrive\NEA\please\pleaseoftheloveofgodbethelastversionofthisproject\Pages\_ViewImports.cshtml"
using pleaseoftheloveofgodbethelastversionofthisproject.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f32d9074681338499af3430726a3c98bf4ed21d5", @"/Pages/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5de1a2601c918fdfb3ba569e353961b2d0b3d0f4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Home_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark h-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 32%; font-size: 2rem; height: 100%; line-height: 5.25rem; text-align: center;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Submit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 32%; font-size: 2rem; height: 100%; line-height: 5.25rem; text-align: center; margin-left: 2%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Quiz/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Leaderboards", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\danie\OneDrive\NEA\please\pleaseoftheloveofgodbethelastversionofthisproject\Pages\Home\Index.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div");
            BeginWriteAttribute("class", " class=\"", 146, "\"", 154, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""height: 90vh;"">
        <div class=""d-flex flex-column w-25 float-left"" style=""height: 100%; margin-top: 1.5rem;"">
            <div class=""d-flex flex-column border text-center"" style=""height: 15rem;"">
                <span class=""display-4"" style=""font-size: 2rem; margin-bottom: 0.5rem; margin-top: 1rem; font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif"">You are level:</span>
                <span class=""display-1""><strong>");
#nullable restore
#line 13 "C:\Users\danie\OneDrive\NEA\please\pleaseoftheloveofgodbethelastversionofthisproject\Pages\Home\Index.cshtml"
                                            Write(Model.currentUserData.ExperienceTotal / 1500);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></span>\r\n                <span style=\"margin-top: 1rem;\"><strong>");
#nullable restore
#line 14 "C:\Users\danie\OneDrive\NEA\please\pleaseoftheloveofgodbethelastversionofthisproject\Pages\Home\Index.cshtml"
                                                    Write(Model.currentUserData.ExperienceTotal % 1500);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> / 1500 until next level</span>\r\n            </div>\r\n            <div class=\"p-3 d-flex flex-column text-center\">\r\n                <span><strong>Your stats:</strong></span>\r\n                <span>Correct answers: <strong>");
#nullable restore
#line 18 "C:\Users\danie\OneDrive\NEA\please\pleaseoftheloveofgodbethelastversionofthisproject\Pages\Home\Index.cshtml"
                                          Write(Model.currentUserData.CorrectAnswers);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></span>\r\n                <span>Questions attempted: <strong>");
#nullable restore
#line 19 "C:\Users\danie\OneDrive\NEA\please\pleaseoftheloveofgodbethelastversionofthisproject\Pages\Home\Index.cshtml"
                                              Write(Model.currentUserData.QuestionsAttempted);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></span>\r\n                <span>Questions contributed: <strong>");
#nullable restore
#line 20 "C:\Users\danie\OneDrive\NEA\please\pleaseoftheloveofgodbethelastversionofthisproject\Pages\Home\Index.cshtml"
                                                Write(Model.currentUserContent.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong></span>
            </div>
        </div>

        <div class=""d-flex flex-column w-75 h-100 float-right"" style=""padding-left: 3rem; margin-top: 1.5rem;"">
            <div class=""d-flex flex-row w-100"" style=""height: 12.5%; margin-bottom: 3.75rem;"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f32d9074681338499af3430726a3c98bf4ed21d59514", async() => {
                WriteLiteral("Submit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f32d9074681338499af3430726a3c98bf4ed21d510849", async() => {
                WriteLiteral("Quiz");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f32d9074681338499af3430726a3c98bf4ed21d512183", async() => {
                WriteLiteral("Leaderboards");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <div");
            BeginWriteAttribute("class", " class=\"", 2136, "\"", 2144, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <span class=\"display-4\" style=\"font-size: 3rem;\">Your submissions</span>\r\n");
#nullable restore
#line 32 "C:\Users\danie\OneDrive\NEA\please\pleaseoftheloveofgodbethelastversionofthisproject\Pages\Home\Index.cshtml"
                 if (Model.currentUserContent.Count() > 0)
                {

                    foreach (var item in Model.currentUserContent)
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"border p-3\" style=\"margin-top: 1.3rem;\">\r\n                            <strong>");
#nullable restore
#line 39 "C:\Users\danie\OneDrive\NEA\please\pleaseoftheloveofgodbethelastversionofthisproject\Pages\Home\Index.cshtml"
                               Write(Html.DisplayFor(m => item.QuestionContent));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> / ");
#nullable restore
#line 39 "C:\Users\danie\OneDrive\NEA\please\pleaseoftheloveofgodbethelastversionofthisproject\Pages\Home\Index.cshtml"
                                                                                      Write(Model.topics[item.QuestionType - 1].QuestionType1);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                            <strong>");
#nullable restore
#line 40 "C:\Users\danie\OneDrive\NEA\please\pleaseoftheloveofgodbethelastversionofthisproject\Pages\Home\Index.cshtml"
                               Write(Html.DisplayFor(m => item.AnswerContent));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br /></strong>\r\n                            <span>Likes: ");
#nullable restore
#line 41 "C:\Users\danie\OneDrive\NEA\please\pleaseoftheloveofgodbethelastversionofthisproject\Pages\Home\Index.cshtml"
                                    Write(Html.DisplayFor(m => item.Likes));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br />\r\n                            <span>Dislikes: ");
#nullable restore
#line 42 "C:\Users\danie\OneDrive\NEA\please\pleaseoftheloveofgodbethelastversionofthisproject\Pages\Home\Index.cshtml"
                                       Write(Html.DisplayFor(m => item.Dislikes));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br />\r\n                            <span>Flags: ");
#nullable restore
#line 43 "C:\Users\danie\OneDrive\NEA\please\pleaseoftheloveofgodbethelastversionofthisproject\Pages\Home\Index.cshtml"
                                    Write(Html.DisplayFor(m => item.Flags));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br />\r\n");
#nullable restore
#line 44 "C:\Users\danie\OneDrive\NEA\please\pleaseoftheloveofgodbethelastversionofthisproject\Pages\Home\Index.cshtml"
                             if (item.Shadowed == true)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span><i>This submission has been hidden by an administrator and will not show up in quizzes.</i></span>\r\n");
#nullable restore
#line 47 "C:\Users\danie\OneDrive\NEA\please\pleaseoftheloveofgodbethelastversionofthisproject\Pages\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n");
#nullable restore
#line 49 "C:\Users\danie\OneDrive\NEA\please\pleaseoftheloveofgodbethelastversionofthisproject\Pages\Home\Index.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 54 "C:\Users\danie\OneDrive\NEA\please\pleaseoftheloveofgodbethelastversionofthisproject\Pages\Home\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Please login ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f32d9074681338499af3430726a3c98bf4ed21d517739", async() => {
                WriteLiteral("here");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" in order to view this page.</p>\r\n");
#nullable restore
#line 58 "C:\Users\danie\OneDrive\NEA\please\pleaseoftheloveofgodbethelastversionofthisproject\Pages\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<pleaseoftheloveofgodbethelastversionofthisproject.Pages.Home.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<pleaseoftheloveofgodbethelastversionofthisproject.Pages.Home.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<pleaseoftheloveofgodbethelastversionofthisproject.Pages.Home.IndexModel>)PageContext?.ViewData;
        public pleaseoftheloveofgodbethelastversionofthisproject.Pages.Home.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
