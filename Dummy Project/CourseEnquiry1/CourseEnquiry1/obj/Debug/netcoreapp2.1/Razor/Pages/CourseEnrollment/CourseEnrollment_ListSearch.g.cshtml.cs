#pragma checksum "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry1\CourseEnquiry1\Pages\CourseEnrollment\CourseEnrollment_ListSearch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67f488447077b1d7013c449d340c3f00def90bec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_CourseEnrollment_CourseEnrollment_ListSearch), @"mvc.1.0.razor-page", @"/Pages/CourseEnrollment/CourseEnrollment_ListSearch.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/CourseEnrollment/CourseEnrollment_ListSearch.cshtml", typeof(AspNetCore.Pages_CourseEnrollment_CourseEnrollment_ListSearch), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67f488447077b1d7013c449d340c3f00def90bec", @"/Pages/CourseEnrollment/CourseEnrollment_ListSearch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"412d996c943f5298bb418d0b914c13c0ef3ee2a1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_CourseEnrollment_CourseEnrollment_ListSearch : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/ui.jqgrid.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/jqgrid-i18n/grid.locale-en.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/jquery-jqgrid-4.13.2.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/jqgrid-listsearch.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/jquery.searchFilter.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry1\CourseEnquiry1\Pages\CourseEnrollment\CourseEnrollment_ListSearch.cshtml"
  
    ViewData["Title"] = "List of Course Enrollment";

    string courseNameSelectValues = ":";
    string studentNameSelectValues = ":";

    foreach (var item in Model.CourseDropDownListData.OrderBy(c => c.CourseId))
    {
        courseNameSelectValues += ";" + item.CourseId + ":" + item.CourseId;
    }

    foreach (var item in Model.StudentDropDownListData.OrderBy(s => s.StudenId))
    {
        studentNameSelectValues += ";" + item.StudenId + ":" + item.StudenId;
    }

#line default
#line hidden
            BeginContext(569, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("AdditionalCss", async() => {
                BeginContext(595, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(601, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8e0857b0282d4cd688f0db03f60e2971", async() => {
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
                BeginContext(657, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(662, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("AdditionalJavaScript", async() => {
                BeginContext(695, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(701, 88, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ee73e3742614f3d8f10d9670ec52a99", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 25 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry1\CourseEnquiry1\Pages\CourseEnrollment\CourseEnrollment_ListSearch.cshtml"
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
                BeginContext(789, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(795, 82, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74de86ab1dd9467db5e9e616b87b8755", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 26 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry1\CourseEnquiry1\Pages\CourseEnrollment\CourseEnrollment_ListSearch.cshtml"
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
                BeginContext(877, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(883, 75, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9cb98a3a7924c71ad4781d96a17cba1", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#line 27 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry1\CourseEnquiry1\Pages\CourseEnrollment\CourseEnrollment_ListSearch.cshtml"
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
                BeginContext(958, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(964, 81, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d4474cc2bb046c6837d059d4b4fd25d", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#line 28 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry1\CourseEnquiry1\Pages\CourseEnrollment\CourseEnrollment_ListSearch.cshtml"
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
                BeginContext(1045, 253, true);
                WriteLiteral("\r\n\r\n    <script type=\"text/javascript\">\r\n        $(function () {\r\n            var checkBoxSelectValues = \":;True:<input type=\'checkbox\' checked disabled /> True;False:<input type=\'checkbox\' disabled /> False\";\r\n            var courseNameSelectValues = \"");
                EndContext();
                BeginContext(1299, 22, false);
#line 33 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry1\CourseEnquiry1\Pages\CourseEnrollment\CourseEnrollment_ListSearch.cshtml"
                                     Write(courseNameSelectValues);

#line default
#line hidden
                EndContext();
                BeginContext(1321, 47, true);
                WriteLiteral("\";\r\n            var studentNameSelectValues = \"");
                EndContext();
                BeginContext(1369, 23, false);
#line 34 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry1\CourseEnquiry1\Pages\CourseEnrollment\CourseEnrollment_ListSearch.cshtml"
                                      Write(studentNameSelectValues);

#line default
#line hidden
                EndContext();
                BeginContext(1392, 2959, true);
                WriteLiteral(@""";

            $('#list-grid').jqGrid({
                url: '/CourseEnrollment/CourseEnrollment_ListSearch?handler=GridDataWithFilters',
                datatype: 'json',
                mtype: 'GET',
                colNames: ['Enrollment Id','Course Name','Student Name','Comments'],
                colModel: [
                    { name: 'EnrollmentId', index: 'EnrollmentId', align: 'right' },
                    { name: 'CourseName', index: 'CourseName', align: 'left', formatter: 'select', stype: 'select', edittype: 'select', editoptions: { value: courseNameSelectValues } },
                    { name: 'StudentName', index: 'StudentName', align: 'left', formatter: 'select', stype: 'select', edittype: 'select', editoptions: { value: studentNameSelectValues } },
                    { name: 'Comments', index: 'Comments', align: 'left', searchoptions: { sopt: ['cn']} }
                ],
                pager: $('#list-pager'),
                rowNum: 10,
                pageable: true,
     ");
                WriteLiteral(@"           autoencode: true,
                jsonReader:
                {
                    page: ""d.page""
                },
                rowList: [5, 10, 20, 50],
                sortname: 'EnrollmentId',
                sortorder: ""asc"",
                viewrecords: true,
                caption: 'List of Course Enrollment',
                height: '100%',
                width: '1200',
                ignoreCase: true
            }).jqGrid('navGrid', '#list-pager', { edit: false, add: false, del: false, search: false, refresh: false });

            $('#list-grid').jqGrid('filterToolbar', { stringResult: true, searchOnEnter: false, beforeSearch: function () {
                // verify entered data before searching
                var postData = $('#list-grid').jqGrid('getGridParam', 'postData');
                var searchData = $.parseJSON(postData.filters);
                var isThereValidationErrors = false;
                var validationErrors = """";

                for (var");
                WriteLiteral(@" iRule = 0; iRule < searchData.rules.length; iRule++) {
                    var enteredValue = searchData.rules[iRule].data;

                    if (searchData.rules[iRule].field == ""EnrollmentId"" && !isNumeric(enteredValue)) {
                        validationErrors += ""  Enrollment Id must be a valid number."";
                        isThereValidationErrors = true;
                    }
                }

                if(isThereValidationErrors)
                    alert($.trim(validationErrors));

                return isThereValidationErrors;
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
            BeginContext(4354, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(4361, 17, false);
#line 99 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry1\CourseEnquiry1\Pages\CourseEnrollment\CourseEnrollment_ListSearch.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(4378, 82, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CourseEnquiry1.Pages.CourseEnrollment_ListSearchModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CourseEnquiry1.Pages.CourseEnrollment_ListSearchModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CourseEnquiry1.Pages.CourseEnrollment_ListSearchModel>)PageContext?.ViewData;
        public CourseEnquiry1.Pages.CourseEnrollment_ListSearchModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
