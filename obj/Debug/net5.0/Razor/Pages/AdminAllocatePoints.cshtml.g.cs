#pragma checksum "C:\Users\Vikumsri\source\repos\NotifyMyHabit\Pages\AdminAllocatePoints.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "beef47b8ac686cb563fb3fddf1d9eef0415c47b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HabitApp.Pages.Pages_AdminAllocatePoints), @"mvc.1.0.razor-page", @"/Pages/AdminAllocatePoints.cshtml")]
namespace HabitApp.Pages
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
#line 1 "C:\Users\Vikumsri\source\repos\NotifyMyHabit\Pages\_ViewImports.cshtml"
using HabitApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Vikumsri\source\repos\NotifyMyHabit\Pages\AdminAllocatePoints.cshtml"
using HabitApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/adminallocatepoints")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"beef47b8ac686cb563fb3fddf1d9eef0415c47b7", @"/Pages/AdminAllocatePoints.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0d8de3ee89885d71118c8112e0d377848ef63c3", @"/Pages/_ViewImports.cshtml")]
    public class Pages_AdminAllocatePoints : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "number", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("addpoints"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:65px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""container"">
    <h2 style=""align-content: center"">My Habits</h2>
    <table class=""table table-primary table-striped table-borderless"" style=""margin-top: 3rem; border-radius:0.5rem"">
        <thead>
            <tr>
                <th scope=""col"">Habit Status</th>
                <th scope=""col"">ID</th>
                <th scope=""col"">Habit</th>
                <th scope=""col"">Description</th>
                <th scope=""col"">Allocate Points</th>
                <th style=""text-align:center; align-items:center"" scope=""col"">Action</th>
            </tr>
        </thead>
        <tbody>

");
#nullable restore
#line 22 "C:\Users\Vikumsri\source\repos\NotifyMyHabit\Pages\AdminAllocatePoints.cshtml"
             foreach (var item in Model.HabitDataModels)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td id=\"hstatus\">");
#nullable restore
#line 25 "C:\Users\Vikumsri\source\repos\NotifyMyHabit\Pages\AdminAllocatePoints.cshtml"
                            Write(item.habitStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td id=\"hidValue\">");
#nullable restore
#line 26 "C:\Users\Vikumsri\source\repos\NotifyMyHabit\Pages\AdminAllocatePoints.cshtml"
                             Write(item.habitId.ToString().Substring(item.habitId.ToString().Length - 4));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td id=\"hid\" hidden>");
#nullable restore
#line 27 "C:\Users\Vikumsri\source\repos\NotifyMyHabit\Pages\AdminAllocatePoints.cshtml"
                               Write(item.habitId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td id=\"htitle\">");
#nullable restore
#line 28 "C:\Users\Vikumsri\source\repos\NotifyMyHabit\Pages\AdminAllocatePoints.cshtml"
                           Write(item.habitTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td id=\"hdescription\">\r\n");
#nullable restore
#line 30 "C:\Users\Vikumsri\source\repos\NotifyMyHabit\Pages\AdminAllocatePoints.cshtml"
                     if (item.habitDescription.Split(" ").Length > 4)
                    {

                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\Vikumsri\source\repos\NotifyMyHabit\Pages\AdminAllocatePoints.cshtml"
                                                                                       
                        List<String> list = item.habitDescription.Split(" ").Take(4).ToList();
                        string desc = list[0] + " " + list[1] + " " + list[2] + " " + list[3];


                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\Vikumsri\source\repos\NotifyMyHabit\Pages\AdminAllocatePoints.cshtml"
                   Write(desc);

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\Vikumsri\source\repos\NotifyMyHabit\Pages\AdminAllocatePoints.cshtml"
                             
                    }
                    else
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\Vikumsri\source\repos\NotifyMyHabit\Pages\AdminAllocatePoints.cshtml"
                   Write(item.habitDescription);

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\Vikumsri\source\repos\NotifyMyHabit\Pages\AdminAllocatePoints.cshtml"
                                              
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("...\r\n                </td>\r\n                <td id=\"haudio\" hidden>");
#nullable restore
#line 45 "C:\Users\Vikumsri\source\repos\NotifyMyHabit\Pages\AdminAllocatePoints.cshtml"
                                  Write(item.habitAudio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td id=\"himage\" hidden>");
#nullable restore
#line 46 "C:\Users\Vikumsri\source\repos\NotifyMyHabit\Pages\AdminAllocatePoints.cshtml"
                                  Write(item.habitImage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                <td id=\"hpoints\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "beef47b8ac686cb563fb3fddf1d9eef0415c47b79931", async() => {
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "beef47b8ac686cb563fb3fddf1d9eef0415c47b710213", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "C:\Users\Vikumsri\source\repos\NotifyMyHabit\Pages\AdminAllocatePoints.cshtml"
                                             WriteLiteral(item.habitId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 50 "C:\Users\Vikumsri\source\repos\NotifyMyHabit\Pages\AdminAllocatePoints.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.AllocatePointDataModel.habitId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 51 "C:\Users\Vikumsri\source\repos\NotifyMyHabit\Pages\AdminAllocatePoints.cshtml"
                         if (item.habitPoints > 0)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "beef47b8ac686cb563fb3fddf1d9eef0415c47b713248", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "C:\Users\Vikumsri\source\repos\NotifyMyHabit\Pages\AdminAllocatePoints.cshtml"
                              WriteLiteral(item.habitPoints);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 57 "C:\Users\Vikumsri\source\repos\NotifyMyHabit\Pages\AdminAllocatePoints.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.AllocatePointDataModel.habitPoints);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 58 "C:\Users\Vikumsri\source\repos\NotifyMyHabit\Pages\AdminAllocatePoints.cshtml"

                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "beef47b8ac686cb563fb3fddf1d9eef0415c47b716136", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#nullable restore
#line 66 "C:\Users\Vikumsri\source\repos\NotifyMyHabit\Pages\AdminAllocatePoints.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.AllocatePointDataModel.habitPoints);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 67 "C:\Users\Vikumsri\source\repos\NotifyMyHabit\Pages\AdminAllocatePoints.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        <button type=""submit""
                                class=""btn btn-success""
                                onclick=""addpoint()""
                                style=""margin-left: 10px"">
                            Save
                        </button>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n\r\n                <td id=\"hvideo\" hidden>");
#nullable restore
#line 78 "C:\Users\Vikumsri\source\repos\NotifyMyHabit\Pages\AdminAllocatePoints.cshtml"
                                  Write(item.habitVideoUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td style=\"text-align:center\">\r\n                    <button type=\"button\" class=\"btn btn-primary\" onclick=\"viewpage(this)\">View</button>\r\n\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 84 "C:\Users\Vikumsri\source\repos\NotifyMyHabit\Pages\AdminAllocatePoints.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>

    <script>
        function viewpage() {
            var idtext = document.getElementById(""hid"").innerText
            var titleText = document.getElementById(""htitle"").innerText
            var descriptiontext = document.getElementById(""hdescription"").innerText
            var audiotext = document.getElementById(""haudio"").innerText
            var imagetext = document.getElementById(""himage"").innerText
            var statustext = document.getElementById(""hstatus"").innerText
            var pointtext = document.getElementById(""hpoints"").innerText
            var videourltext = document.getElementById(""hvideo"").innerText

            window.localStorage.setItem(""imagetext"", imagetext)
            window.localStorage.setItem(""audio"", audiotext)

            window.location.replace(""/viewsinglehabit?hid="" + idtext + ""&htitle="" + titleText + ""&hdescription="" + descriptiontext + ""&hstatus="" + statustext + ""&hpoints="" + pointtext + ""&hvideo="" + videourltext);

  ");
            WriteLiteral("      }\r\n\r\n        function addpoint() {\r\n            var points = document.getElementById(\"hpoints\").value\r\n        }\r\n    </script>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HabitApp.Pages.AdminAllocatePointsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HabitApp.Pages.AdminAllocatePointsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HabitApp.Pages.AdminAllocatePointsModel>)PageContext?.ViewData;
        public HabitApp.Pages.AdminAllocatePointsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591