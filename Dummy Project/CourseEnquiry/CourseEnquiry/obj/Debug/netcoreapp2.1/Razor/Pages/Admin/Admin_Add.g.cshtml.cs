#pragma checksum "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry\CourseEnquiry\Pages\Admin\Admin_Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82ec516a9d4c2de6e821ac76ca67b14cf8cf197e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Admin_Admin_Add), @"mvc.1.0.razor-page", @"/Pages/Admin/Admin_Add.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Admin/Admin_Add.cshtml", typeof(AspNetCore.Pages_Admin_Admin_Add), null)]
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
#line 1 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry\CourseEnquiry\Pages\_ViewImports.cshtml"
using CourseEnquiry;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82ec516a9d4c2de6e821ac76ca67b14cf8cf197e", @"/Pages/Admin/Admin_Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d7adc9b5393aadd02d84d55da8db31774ef9629", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Admin_Add : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("AdditionalJavaScript", async() => {
                BeginContext(81, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(88, 52, false);
#line 4 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry\CourseEnquiry\Pages\Admin\Admin_Add.cshtml"
Write(await Html.PartialAsync("_ValidationScriptsPartial"));

#line default
#line hidden
                EndContext();
                BeginContext(140, 161, true);
                WriteLiteral("\r\n\r\n    <script type=\"text/javascript\">\r\n        $(function () {\r\n            $(\'.datetextbox\').datepicker({dateFormat: \'m/d/yy\'});\r\n        });\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(304, 23, true);
            WriteLiteral("\r\n<h2>Add Record</h2>\r\n");
            EndContext();
            BeginContext(328, 28, false);
#line 14 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry\CourseEnquiry\Pages\Admin\Admin_Add.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
            EndContext();
            BeginContext(356, 13, true);
            WriteLiteral("\r\n<div>\r\n    ");
            EndContext();
            BeginContext(370, 73, false);
#line 16 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry\CourseEnquiry\Pages\Admin\Admin_Add.cshtml"
Write(Html.Partial("../Shared/_AddEditAdminPartial.cshtml", Model.PartialModel));

#line default
#line hidden
            EndContext();
            BeginContext(443, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CourseEnquiry.Pages.Admin_AddModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CourseEnquiry.Pages.Admin_AddModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CourseEnquiry.Pages.Admin_AddModel>)PageContext?.ViewData;
        public CourseEnquiry.Pages.Admin_AddModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
