#pragma checksum "C:\Personal\Learning\Repos\Stuff\ContosoUniversity\ContosoUniversity\Pages\Students\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a1306e11cc09b37770c784daecc9c214d6064be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ContosoUniversity.Pages.Students.Pages_Students_Details), @"mvc.1.0.razor-page", @"/Pages/Students/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Students/Details.cshtml", typeof(ContosoUniversity.Pages.Students.Pages_Students_Details), @"{id:int?}")]
namespace ContosoUniversity.Pages.Students
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Personal\Learning\Repos\Stuff\ContosoUniversity\ContosoUniversity\Pages\_ViewImports.cshtml"
using ContosoUniversity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id:int?}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a1306e11cc09b37770c784daecc9c214d6064be", @"/Pages/Students/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4c0473ebe7d620ab1ae06d83bc5bc87bf314407", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Students_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(73, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Personal\Learning\Repos\Stuff\ContosoUniversity\ContosoUniversity\Pages\Students\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(118, 121, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Student</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(240, 52, false);
#line 15 "C:\Personal\Learning\Repos\Stuff\ContosoUniversity\ContosoUniversity\Pages\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Student.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(292, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(336, 48, false);
#line 18 "C:\Personal\Learning\Repos\Stuff\ContosoUniversity\ContosoUniversity\Pages\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.Student.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(384, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(428, 56, false);
#line 21 "C:\Personal\Learning\Repos\Stuff\ContosoUniversity\ContosoUniversity\Pages\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Student.FirstMidName));

#line default
#line hidden
            EndContext();
            BeginContext(484, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(528, 52, false);
#line 24 "C:\Personal\Learning\Repos\Stuff\ContosoUniversity\ContosoUniversity\Pages\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.Student.FirstMidName));

#line default
#line hidden
            EndContext();
            BeginContext(580, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(624, 58, false);
#line 27 "C:\Personal\Learning\Repos\Stuff\ContosoUniversity\ContosoUniversity\Pages\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Student.EnrollmentDate));

#line default
#line hidden
            EndContext();
            BeginContext(682, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(726, 54, false);
#line 30 "C:\Personal\Learning\Repos\Stuff\ContosoUniversity\ContosoUniversity\Pages\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.Student.EnrollmentDate));

#line default
#line hidden
            EndContext();
            BeginContext(780, 190, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            <table class=\"table\">\r\n                <tr>\r\n                    <th>Course Title</th>\r\n                    <th>Grade</th>\r\n                </tr>\r\n");
            EndContext();
#line 38 "C:\Personal\Learning\Repos\Stuff\ContosoUniversity\ContosoUniversity\Pages\Students\Details.cshtml"
                 foreach (var item in Model.Student.Enrollments)
                {

#line default
#line hidden
            BeginContext(1055, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1140, 41, false);
#line 42 "C:\Personal\Learning\Repos\Stuff\ContosoUniversity\ContosoUniversity\Pages\Students\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Course));

#line default
#line hidden
            EndContext();
            BeginContext(1181, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1273, 40, false);
#line 45 "C:\Personal\Learning\Repos\Stuff\ContosoUniversity\ContosoUniversity\Pages\Students\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Grade));

#line default
#line hidden
            EndContext();
            BeginContext(1313, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 48 "C:\Personal\Learning\Repos\Stuff\ContosoUniversity\ContosoUniversity\Pages\Students\Details.cshtml"
                }

#line default
#line hidden
            BeginContext(1392, 67, true);
            WriteLiteral("            </table>\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1459, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f613269000a5410bba5cbe8880eddc15", async() => {
                BeginContext(1513, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 54 "C:\Personal\Learning\Repos\Stuff\ContosoUniversity\ContosoUniversity\Pages\Students\Details.cshtml"
                           WriteLiteral(Model.Student.ID);

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
            BeginContext(1521, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1529, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa71b42754e6453f90f3429c1964011a", async() => {
                BeginContext(1551, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1567, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContosoUniversity.Pages.Students.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ContosoUniversity.Pages.Students.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ContosoUniversity.Pages.Students.DetailsModel>)PageContext?.ViewData;
        public ContosoUniversity.Pages.Students.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
