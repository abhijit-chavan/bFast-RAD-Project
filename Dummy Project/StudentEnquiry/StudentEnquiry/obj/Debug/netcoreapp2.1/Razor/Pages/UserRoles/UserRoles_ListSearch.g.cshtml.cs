#pragma checksum "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\UserRoles\UserRoles_ListSearch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73ef6fe0c6df59766100aac68b8edaee2a2f3f44"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_UserRoles_UserRoles_ListSearch), @"mvc.1.0.razor-page", @"/Pages/UserRoles/UserRoles_ListSearch.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/UserRoles/UserRoles_ListSearch.cshtml", typeof(AspNetCore.Pages_UserRoles_UserRoles_ListSearch), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73ef6fe0c6df59766100aac68b8edaee2a2f3f44", @"/Pages/UserRoles/UserRoles_ListSearch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62c0313e94265ea202c2b341a7c6893504740388", @"/Pages/_ViewImports.cshtml")]
    public class Pages_UserRoles_UserRoles_ListSearch : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 3 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\UserRoles\UserRoles_ListSearch.cshtml"
  
    ViewData["Title"] = "List of User Roles";

    string userIdSelectValues = ":";
    string roleIdSelectValues = ":";

    foreach (var item in Model.UserMasterDropDownListData.OrderBy(u => u.UserId))
    {
        userIdSelectValues += ";" + item.UserId + ":" + item.UserId;
    }

    foreach (var item in Model.RoleMasterDropDownListData.OrderBy(r => r.RoleId))
    {
        roleIdSelectValues += ";" + item.RoleId + ":" + item.RoleId;
    }

#line default
#line hidden
            BeginContext(532, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("AdditionalCss", async() => {
                BeginContext(558, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(564, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "71363ca5b2264fc4968ec189edad2f1d", async() => {
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
                BeginContext(620, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(625, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("AdditionalJavaScript", async() => {
                BeginContext(658, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(664, 88, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4a2e22eb4404492b43288fa93ce9629", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 25 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\UserRoles\UserRoles_ListSearch.cshtml"
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
                BeginContext(752, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(758, 82, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f371b6838ffd4cf082eac2a831d70e20", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 26 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\UserRoles\UserRoles_ListSearch.cshtml"
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
                BeginContext(840, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(846, 75, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d15e02dcc47440c1b85702310ac25a74", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#line 27 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\UserRoles\UserRoles_ListSearch.cshtml"
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
                BeginContext(921, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(927, 81, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbc1a120baeb421fafa9f3d595238e57", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#line 28 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\UserRoles\UserRoles_ListSearch.cshtml"
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
                BeginContext(1008, 249, true);
                WriteLiteral("\r\n\r\n    <script type=\"text/javascript\">\r\n        $(function () {\r\n            var checkBoxSelectValues = \":;True:<input type=\'checkbox\' checked disabled /> True;False:<input type=\'checkbox\' disabled /> False\";\r\n            var userIdSelectValues = \"");
                EndContext();
                BeginContext(1258, 18, false);
#line 33 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\UserRoles\UserRoles_ListSearch.cshtml"
                                 Write(userIdSelectValues);

#line default
#line hidden
                EndContext();
                BeginContext(1276, 42, true);
                WriteLiteral("\";\r\n            var roleIdSelectValues = \"");
                EndContext();
                BeginContext(1319, 18, false);
#line 34 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\UserRoles\UserRoles_ListSearch.cshtml"
                                 Write(roleIdSelectValues);

#line default
#line hidden
                EndContext();
                BeginContext(1337, 2960, true);
                WriteLiteral(@""";

            $('#list-grid').jqGrid({
                url: '/UserRoles/UserRoles_ListSearch?handler=GridDataWithFilters',
                datatype: 'json',
                mtype: 'GET',
                colNames: ['User Role Id','User Id','Role Id','Status'],
                colModel: [
                    { name: 'UserRoleId', index: 'UserRoleId', align: 'right' },
                    { name: 'UserId', index: 'UserId', align: 'left', formatter: 'select', stype: 'select', edittype: 'select', editoptions: { value: userIdSelectValues } },
                    { name: 'RoleId', index: 'RoleId', align: 'left', formatter: 'select', stype: 'select', edittype: 'select', editoptions: { value: roleIdSelectValues } },
                    { name: 'Status', index: 'Status', align: 'center', formatter: 'select', stype: 'select', edittype: 'select', editoptions: { value: checkBoxSelectValues } }
                ],
                pager: $('#list-pager'),
                rowNum: 10,
                pageable:");
                WriteLiteral(@" true,
                autoencode: true,
                jsonReader:
                {
                    page: ""d.page""
                },
                rowList: [5, 10, 20, 50],
                sortname: 'UserRoleId',
                sortorder: ""asc"",
                viewrecords: true,
                caption: 'List of User Roles',
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

                for ");
                WriteLiteral(@"(var iRule = 0; iRule < searchData.rules.length; iRule++) {
                    var enteredValue = searchData.rules[iRule].data;

                    if (searchData.rules[iRule].field == ""UserRoleId"" && !isNumeric(enteredValue)) {
                        validationErrors += ""  User Role Id must be a valid number."";
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
            BeginContext(4300, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(4307, 17, false);
#line 99 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\UserRoles\UserRoles_ListSearch.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(4324, 82, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentEnquiry.Pages.UserRoles_ListSearchModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<StudentEnquiry.Pages.UserRoles_ListSearchModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<StudentEnquiry.Pages.UserRoles_ListSearchModel>)PageContext?.ViewData;
        public StudentEnquiry.Pages.UserRoles_ListSearchModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
