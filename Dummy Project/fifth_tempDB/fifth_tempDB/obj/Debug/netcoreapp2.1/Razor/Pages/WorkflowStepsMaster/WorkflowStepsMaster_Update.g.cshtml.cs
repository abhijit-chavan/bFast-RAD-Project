#pragma checksum "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\WorkflowStepsMaster\WorkflowStepsMaster_Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19adee6cdf04680af97ada075a44dcfec2960c81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_WorkflowStepsMaster_WorkflowStepsMaster_Update), @"mvc.1.0.razor-page", @"/Pages/WorkflowStepsMaster/WorkflowStepsMaster_Update.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/WorkflowStepsMaster/WorkflowStepsMaster_Update.cshtml", typeof(AspNetCore.Pages_WorkflowStepsMaster_WorkflowStepsMaster_Update), null)]
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
#line 1 "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\_ViewImports.cshtml"
using fifth_tempDB;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19adee6cdf04680af97ada075a44dcfec2960c81", @"/Pages/WorkflowStepsMaster/WorkflowStepsMaster_Update.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c03d768fe4c1090bb61b28ea762c3ac2c2dda16f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_WorkflowStepsMaster_WorkflowStepsMaster_Update : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("AdditionalJavaScript", async() => {
                BeginContext(97, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(104, 52, false);
#line 4 "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\WorkflowStepsMaster\WorkflowStepsMaster_Update.cshtml"
Write(await Html.PartialAsync("_ValidationScriptsPartial"));

#line default
#line hidden
                EndContext();
                BeginContext(156, 161, true);
                WriteLiteral("\r\n\r\n    <script type=\"text/javascript\">\r\n        $(function () {\r\n            $(\'.datetextbox\').datepicker({dateFormat: \'m/d/yy\'});\r\n        });\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(320, 26, true);
            WriteLiteral("\r\n<h2>Update Record</h2>\r\n");
            EndContext();
            BeginContext(347, 28, false);
#line 14 "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\WorkflowStepsMaster\WorkflowStepsMaster_Update.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
            EndContext();
            BeginContext(375, 13, true);
            WriteLiteral("\r\n<div>\r\n    ");
            EndContext();
            BeginContext(389, 87, false);
#line 16 "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\WorkflowStepsMaster\WorkflowStepsMaster_Update.cshtml"
Write(Html.Partial("../Shared/_AddEditWorkflowStepsMasterPartial.cshtml", Model.PartialModel));

#line default
#line hidden
            EndContext();
            BeginContext(476, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<fifth_tempDB.Pages.WorkflowStepsMaster_UpdateModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<fifth_tempDB.Pages.WorkflowStepsMaster_UpdateModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<fifth_tempDB.Pages.WorkflowStepsMaster_UpdateModel>)PageContext?.ViewData;
        public fifth_tempDB.Pages.WorkflowStepsMaster_UpdateModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
