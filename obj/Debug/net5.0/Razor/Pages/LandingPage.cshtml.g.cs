#pragma checksum "C:\Users\Vikumsri\source\repos\NotifyMyHabit\Pages\LandingPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a46a669c10944a72d8eded915069ca2a4c2f8554"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HabitApp.Pages.Pages_LandingPage), @"mvc.1.0.razor-page", @"/Pages/LandingPage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/land")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a46a669c10944a72d8eded915069ca2a4c2f8554", @"/Pages/LandingPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0d8de3ee89885d71118c8112e0d377848ef63c3", @"/Pages/_ViewImports.cshtml")]
    public class Pages_LandingPage : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container mt-5\" style=\"margin-left: 350px\">\r\n\t<div class=\"card\" style=\"width:18rem; align-content:center\">\r\n      <img");
            BeginWriteAttribute("src", " src=\"", 194, "\"", 228, 1);
#nullable restore
#line 8 "C:\Users\Vikumsri\source\repos\NotifyMyHabit\Pages\LandingPage.cshtml"
WriteAttributeValue("", 200, Model.HabitModel.habitImage, 200, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"...\">\r\n      <div class=\"card-body\">\r\n          <h5 class=\"card-title\">");
#nullable restore
#line 10 "C:\Users\Vikumsri\source\repos\NotifyMyHabit\Pages\LandingPage.cshtml"
                            Write(Model.HabitModel.habitTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n          <p class=\"card-text\">");
#nullable restore
#line 11 "C:\Users\Vikumsri\source\repos\NotifyMyHabit\Pages\LandingPage.cshtml"
                          Write(Model.HabitModel.habitDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
        <a href=""#"" class=""btn btn-primary"" style=""margin-left:80px"" onclick=""viewPage()"">See more</a>
      </div>
    </div>
</div>

<script>
    
    
    function viewPage()
    {
        console.log('qfliwqhvoewh')
        var email = window.localStorage.getItem(""email"")
        if (email == null) {
            window.location.href = ""/login""
        } else {
            window.location.href = ""/viewhabit""
        }
    }
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HabitApp.Pages.LandingPageModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HabitApp.Pages.LandingPageModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HabitApp.Pages.LandingPageModel>)PageContext?.ViewData;
        public HabitApp.Pages.LandingPageModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
