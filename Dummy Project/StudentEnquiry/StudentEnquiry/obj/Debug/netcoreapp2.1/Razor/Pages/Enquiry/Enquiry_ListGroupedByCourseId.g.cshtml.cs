#pragma checksum "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\Enquiry\Enquiry_ListGroupedByCourseId.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84538a5a39c7d4c84e48de95e9453ab751a890e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Enquiry_Enquiry_ListGroupedByCourseId), @"mvc.1.0.razor-page", @"/Pages/Enquiry/Enquiry_ListGroupedByCourseId.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Enquiry/Enquiry_ListGroupedByCourseId.cshtml", typeof(AspNetCore.Pages_Enquiry_Enquiry_ListGroupedByCourseId), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84538a5a39c7d4c84e48de95e9453ab751a890e2", @"/Pages/Enquiry/Enquiry_ListGroupedByCourseId.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62c0313e94265ea202c2b341a7c6893504740388", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Enquiry_Enquiry_ListGroupedByCourseId : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/ui.jqgrid.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/jqgrid-i18n/grid.locale-en.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/jquery-jqgrid-4.13.2.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\Enquiry\Enquiry_ListGroupedByCourseId.cshtml"
  
    ViewData["Title"] = "List of Enquiry By Couse";

#line default
#line hidden
            BeginContext(131, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("AdditionalCss", async() => {
                BeginContext(157, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(163, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "026ad3bb8c8442338e825b4a5e9a62c1", async() => {
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
                BeginContext(219, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(224, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("AdditionalJavaScript", async() => {
                BeginContext(257, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(263, 88, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0aedb3c315604338a6dbfb0292689771", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 12 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\Enquiry\Enquiry_ListGroupedByCourseId.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(351, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(357, 82, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e299f29e7d3e4fc2ac4a2daf6edd98a7", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 13 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\Enquiry\Enquiry_ListGroupedByCourseId.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(439, 2021, true);
                WriteLiteral(@"

    <script type=""text/javascript"">
        $(function () {
            $('#list-grid').jqGrid({
                url: '/Enquiry/Enquiry_ListGroupedByCourseId?handler=GridDataGroupedByCourseId',
                datatype: 'json',
                mtype: 'GET',
                colNames: ['Enquiry Id','Course Id','Student Name','Contact No','Comments', ''],
                colModel: [
                    { name: 'EnquiryId', index: 'EnquiryId', align: 'right' },
                    { name: 'CourseId', index: 'CourseId', align: 'right' },
                    { name: 'StudentName', index: 'StudentName', align: 'left' },
                    { name: 'ContactNo', index: 'ContactNo', align: 'right', formatter: 'integer' },
                    { name: 'Comments', index: 'Comments', align: 'left' },
                    { name: 'CouseName', index: 'CouseName' }
                ],
                pager: $('#list-pager'),
                rowNum: 10,
                pageable: true,
                autoen");
                WriteLiteral(@"code: true,
                jsonReader:
                {
                    page: ""d.page""
                },
                rowList: [5, 10, 20, 50],
                sortname: 'EnquiryId',
                sortorder: ""asc"",
                viewrecords: true,
                caption: 'List of Enquiry By Couse',
                height: '100%',
                width: '1200',
                grouping: true,
                groupingView: {
                    groupField: ['CouseName'],
                    groupColumnShow: [false],
                    groupText: ['<b>{0} ({1} items)</b>'],
                    groupDataSorted: true
                }
            });
        });

        // rename the page parameter to _page because asp.net core razor's page model
        // does not recognize the page parameter when passed
        $.extend(jQuery.jgrid.defaults, {
            prmNames: {
                page: ""_page""
            }
        });
    </script> 
");
                EndContext();
            }
            );
            BeginContext(2463, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(2470, 17, false);
#line 65 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\Enquiry\Enquiry_ListGroupedByCourseId.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(2487, 82, true);
            WriteLiteral("</h2>\r\n<br /><br />\r\n<table id=\"list-grid\"></table>\r\n<div id=\"list-pager\"></div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentEnquiry.Pages.Enquiry_ListGroupedByCourseIdModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<StudentEnquiry.Pages.Enquiry_ListGroupedByCourseIdModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<StudentEnquiry.Pages.Enquiry_ListGroupedByCourseIdModel>)PageContext?.ViewData;
        public StudentEnquiry.Pages.Enquiry_ListGroupedByCourseIdModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
