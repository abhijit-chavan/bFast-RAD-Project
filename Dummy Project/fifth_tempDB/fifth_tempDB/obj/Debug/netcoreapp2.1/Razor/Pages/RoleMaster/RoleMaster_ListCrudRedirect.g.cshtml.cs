#pragma checksum "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\RoleMaster\RoleMaster_ListCrudRedirect.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7b1d1262c0def4b3184ba8f916e71053d7a57bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_RoleMaster_RoleMaster_ListCrudRedirect), @"mvc.1.0.razor-page", @"/Pages/RoleMaster/RoleMaster_ListCrudRedirect.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/RoleMaster/RoleMaster_ListCrudRedirect.cshtml", typeof(AspNetCore.Pages_RoleMaster_RoleMaster_ListCrudRedirect), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7b1d1262c0def4b3184ba8f916e71053d7a57bb", @"/Pages/RoleMaster/RoleMaster_ListCrudRedirect.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c03d768fe4c1090bb61b28ea762c3ac2c2dda16f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_RoleMaster_RoleMaster_ListCrudRedirect : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/ui.jqgrid.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/jqgrid-i18n/grid.locale-en.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/jquery-jqgrid-4.13.2.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/jqgrid-listcrudredirect.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\RoleMaster\RoleMaster_ListCrudRedirect.cshtml"
  
    ViewData["Title"] = "List of Role Master";

#line default
#line hidden
            BeginContext(122, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("AdditionalCss", async() => {
                BeginContext(148, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(154, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e5356839d0a643cc9586e9d708c57b5e", async() => {
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
                BeginContext(210, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(215, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("AdditionalJavaScript", async() => {
                BeginContext(248, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(254, 88, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e890795675a4ebca515f041db77a22f", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 12 "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\RoleMaster\RoleMaster_ListCrudRedirect.cshtml"
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
                BeginContext(342, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(348, 82, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad52d65d7c2a458ca4f038503274324c", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 13 "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\RoleMaster\RoleMaster_ListCrudRedirect.cshtml"
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
                BeginContext(430, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(436, 81, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e15067be1e3140dca453ee0f9cacf491", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#line 14 "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\RoleMaster\RoleMaster_ListCrudRedirect.cshtml"
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
                BeginContext(517, 3212, true);
                WriteLiteral(@"

    <script type=""text/javascript"">
        var urlAndMethod = '/RoleMaster/RoleMaster_ListCrudRedirect';

 
        function editFormatter(cellvalue, options, rowObject) {
            return cellvalue;
        }
 
        function deleteFormatter(cellvalue, options, rowObject) {
            return cellvalue;
        }
 
        $(function () {
            $('#list-grid').jqGrid({
                url: '/RoleMaster/RoleMaster_ListCrudRedirect?handler=GridData',
                datatype: 'json',
                mtype: 'GET',
                colNames: ['Role Id','Role Description','Created On','Created By','Modified On','Modified By', '', ''],
                colModel: [
                    { name: 'RoleId', index: 'RoleId', align: 'right' },
                    { name: 'RoleDescription', index: 'RoleDescription', align: 'left' },
                    { name: 'CreatedOn', index: 'CreatedOn', align: 'left', sorttype: ""date"" },
                    { name: 'CreatedBy', index: 'CreatedBy', a");
                WriteLiteral(@"lign: 'left' },
                    { name: 'ModifiedOn', index: 'ModifiedOn', align: 'left', sorttype: ""date"" },
                    { name: 'ModifiedBy', index: 'ModifiedBy', align: 'left' },
                    { name: 'editoperation', index: 'editoperation', align: 'center', width: 40, sortable: false , formatter: editFormatter },
                    { name: 'deleteoperation', index: 'deleteoperation', align: 'center', width: 40, sortable: false , formatter: deleteFormatter },
                ],
                pager: $('#list-pager'),
                rowNum: 10,
                pageable: true,
                autoencode: true,
                jsonReader:
                {
                    page: ""d.page""
                },
                rowList: [5, 10, 20, 50],
                sortname: 'RoleId',
                sortorder: ""asc"",
                viewrecords: true,
                caption: 'List of Role Master',
                height: '100%',
                width: '1200',
     ");
                WriteLiteral(@"           gridComplete: function () {
                    var ids = jQuery(""#list-grid"").jqGrid('getDataIDs');
                    for (var i = 0; i < ids.length; i++) {
                        var currentid = ids[i];
                        editLink = ""<a href='/RoleMaster/RoleMaster_Update?id="" + currentid + ""&returnUrl=/RoleMaster/RoleMaster_ListCrudRedirect'><img src='/images/Edit.gif' style='border:none;' /></a>"";
                        deleteLink = ""<a href='#' onclick=\""deleteItem('"" + currentid + ""')\""><img src='/images/Delete.png' style='border:none;' /></a>"";
                        jQuery(""#list-grid"").jqGrid('setRowData', ids[i], { editoperation: editLink });
                        jQuery(""#list-grid"").jqGrid('setRowData', ids[i], { deleteoperation: deleteLink });
                    }
                }
            });
        });

        // rename the page parameter to _page because asp.net core razor's page model
        // does not recognize the page parameter when passed
   ");
                WriteLiteral("     $.extend(jQuery.jgrid.defaults, {\r\n            prmNames: {\r\n                page: \"_page\"\r\n            }\r\n        });\r\n    </script> \r\n");
                EndContext();
            }
            );
            BeginContext(3732, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(3739, 17, false);
#line 82 "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\RoleMaster\RoleMaster_ListCrudRedirect.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(3756, 186, true);
            WriteLiteral("</h2>\r\n<br /><br />\r\n<div id=\"errorConfirmationDialog\"></div>\r\n<div id=\"errorDialog\"></div>\r\n\r\n<a href=\"/RoleMaster/RoleMaster_Add?returnUrl=/RoleMaster/RoleMaster_ListCrudRedirect\"><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3942, "\"", 3980, 1);
#line 87 "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\RoleMaster\RoleMaster_ListCrudRedirect.cshtml"
WriteAttributeValue("", 3948, Url.Content("~/images/Add.gif"), 3948, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3981, 248, true);
            WriteLiteral(" alt=\"Add New RoleMaster\" style=\"border: none;\" /></a>&nbsp;<a href=\"/RoleMaster/RoleMaster_Add?returnUrl=/RoleMaster/RoleMaster_ListCrudRedirect\">Add New RoleMaster</a>\r\n<br /><br />\r\n\r\n<table id=\"list-grid\"></table>\r\n<div id=\"list-pager\"></div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<fifth_tempDB.Pages.RoleMaster_ListCrudRedirectModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<fifth_tempDB.Pages.RoleMaster_ListCrudRedirectModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<fifth_tempDB.Pages.RoleMaster_ListCrudRedirectModel>)PageContext?.ViewData;
        public fifth_tempDB.Pages.RoleMaster_ListCrudRedirectModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
