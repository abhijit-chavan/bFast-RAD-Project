#pragma checksum "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry1\CourseEnquiry1\Pages\CourseEnrollment\CourseEnrollment_Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "099258267b5d7de904200dd9813ce54eff07959c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_CourseEnrollment_CourseEnrollment_Update), @"mvc.1.0.razor-page", @"/Pages/CourseEnrollment/CourseEnrollment_Update.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/CourseEnrollment/CourseEnrollment_Update.cshtml", typeof(AspNetCore.Pages_CourseEnrollment_CourseEnrollment_Update), null)]
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
#line 1 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry1\CourseEnquiry1\Pages\_ViewImports.cshtml"
using CourseEnquiry1;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"099258267b5d7de904200dd9813ce54eff07959c", @"/Pages/CourseEnrollment/CourseEnrollment_Update.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"412d996c943f5298bb418d0b914c13c0ef3ee2a1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_CourseEnrollment_CourseEnrollment_Update : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("AdditionalJavaScript", async() => {
                BeginContext(96, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(103, 52, false);
#line 4 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry1\CourseEnquiry1\Pages\CourseEnrollment\CourseEnrollment_Update.cshtml"
Write(await Html.PartialAsync("_ValidationScriptsPartial"));

#line default
#line hidden
                EndContext();
                BeginContext(155, 161, true);
                WriteLiteral("\r\n\r\n    <script type=\"text/javascript\">\r\n        $(function () {\r\n            $(\'.datetextbox\').datepicker({dateFormat: \'m/d/yy\'});\r\n        });\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(319, 26, true);
            WriteLiteral("\r\n<h2>Update Record</h2>\r\n");
            EndContext();
            BeginContext(346, 28, false);
#line 14 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry1\CourseEnquiry1\Pages\CourseEnrollment\CourseEnrollment_Update.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
            EndContext();
            BeginContext(374, 13, true);
            WriteLiteral("\r\n<div>\r\n    ");
            EndContext();
            BeginContext(388, 84, false);
#line 16 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry1\CourseEnquiry1\Pages\CourseEnrollment\CourseEnrollment_Update.cshtml"
Write(Html.Partial("../Shared/_AddEditCourseEnrollmentPartial.cshtml", Model.PartialModel));

#line default
#line hidden
            EndContext();
            BeginContext(472, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CourseEnquiry1.Pages.CourseEnrollment_UpdateModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CourseEnquiry1.Pages.CourseEnrollment_UpdateModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CourseEnquiry1.Pages.CourseEnrollment_UpdateModel>)PageContext?.ViewData;
        public CourseEnquiry1.Pages.CourseEnrollment_UpdateModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
