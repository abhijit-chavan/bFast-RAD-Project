#pragma checksum "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\WorkflowMaster\WorkflowMaster_Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0663782c4eec2363275bc5c8e50c7e648219f0bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_WorkflowMaster_WorkflowMaster_Add), @"mvc.1.0.razor-page", @"/Pages/WorkflowMaster/WorkflowMaster_Add.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/WorkflowMaster/WorkflowMaster_Add.cshtml", typeof(AspNetCore.Pages_WorkflowMaster_WorkflowMaster_Add), null)]
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
#line 1 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\_ViewImports.cshtml"
using StudentEnquiry;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0663782c4eec2363275bc5c8e50c7e648219f0bc", @"/Pages/WorkflowMaster/WorkflowMaster_Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62c0313e94265ea202c2b341a7c6893504740388", @"/Pages/_ViewImports.cshtml")]
    public class Pages_WorkflowMaster_WorkflowMaster_Add : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("AdditionalJavaScript", async() => {
                BeginContext(91, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(98, 52, false);
#line 4 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\WorkflowMaster\WorkflowMaster_Add.cshtml"
Write(await Html.PartialAsync("_ValidationScriptsPartial"));

#line default
#line hidden
                EndContext();
                BeginContext(150, 161, true);
                WriteLiteral("\r\n\r\n    <script type=\"text/javascript\">\r\n        $(function () {\r\n            $(\'.datetextbox\').datepicker({dateFormat: \'m/d/yy\'});\r\n        });\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(314, 23, true);
            WriteLiteral("\r\n<h2>Add Record</h2>\r\n");
            EndContext();
            BeginContext(338, 28, false);
#line 14 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\WorkflowMaster\WorkflowMaster_Add.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
            EndContext();
            BeginContext(366, 13, true);
            WriteLiteral("\r\n<div>\r\n    ");
            EndContext();
            BeginContext(380, 82, false);
#line 16 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\WorkflowMaster\WorkflowMaster_Add.cshtml"
Write(Html.Partial("../Shared/_AddEditWorkflowMasterPartial.cshtml", Model.PartialModel));

#line default
#line hidden
            EndContext();
            BeginContext(462, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentEnquiry.Pages.WorkflowMaster_AddModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<StudentEnquiry.Pages.WorkflowMaster_AddModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<StudentEnquiry.Pages.WorkflowMaster_AddModel>)PageContext?.ViewData;
        public StudentEnquiry.Pages.WorkflowMaster_AddModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
