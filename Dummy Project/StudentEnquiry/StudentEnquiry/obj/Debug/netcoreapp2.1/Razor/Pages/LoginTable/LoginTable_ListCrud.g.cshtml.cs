#pragma checksum "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\LoginTable\LoginTable_ListCrud.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4cc182649adf427c9cc6f0c2648fc3ff8a96efd3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_LoginTable_LoginTable_ListCrud), @"mvc.1.0.razor-page", @"/Pages/LoginTable/LoginTable_ListCrud.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/LoginTable/LoginTable_ListCrud.cshtml", typeof(AspNetCore.Pages_LoginTable_LoginTable_ListCrud), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cc182649adf427c9cc6f0c2648fc3ff8a96efd3", @"/Pages/LoginTable/LoginTable_ListCrud.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62c0313e94265ea202c2b341a7c6893504740388", @"/Pages/_ViewImports.cshtml")]
    public class Pages_LoginTable_LoginTable_ListCrud : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/ui.jqgrid.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/jqgrid-i18n/grid.locale-en.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/jquery-jqgrid-4.13.2.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/jqgrid-listcrud.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("adminid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("readonly", new global::Microsoft.AspNetCore.Html.HtmlString("readonly"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("password"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onblur", new global::Microsoft.AspNetCore.Html.HtmlString("isDataValid()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\LoginTable\LoginTable_ListCrud.cshtml"
  
    ViewData["Title"] = "List of Login Table";

#line default
#line hidden
            BeginContext(116, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("AdditionalCss", async() => {
                BeginContext(142, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(148, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f179d8271f57404a95b7f2df515875d3", async() => {
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
                BeginContext(204, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(209, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("AdditionalJavaScript", async() => {
                BeginContext(242, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(248, 88, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e1af0e11a2248eba2f1a201c0e587ae", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 12 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\LoginTable\LoginTable_ListCrud.cshtml"
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
                BeginContext(336, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(342, 82, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b22d2d3c893e44ceb76834ea5209f688", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 13 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\LoginTable\LoginTable_ListCrud.cshtml"
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
                BeginContext(424, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(431, 52, false);
#line 14 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\LoginTable\LoginTable_ListCrud.cshtml"
Write(await Html.PartialAsync("_ValidationScriptsPartial"));

#line default
#line hidden
                EndContext();
                BeginContext(483, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(489, 73, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2eeddd23c1aa4d20bc86da98aa059f6c", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#line 15 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\LoginTable\LoginTable_ListCrud.cshtml"
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
                BeginContext(562, 4982, true);
                WriteLiteral(@"

    <script type=""text/javascript"">
        var addEditTitle = ""LoginTable"";
        var urlAndMethod = ""/LoginTable/LoginTable_ListCrud"";

        function addItem() {
            clearFields();
            resetValidationErrors();
            showHideItem(null);
            $(""#adminid"").attr('disabled', true);
        }

        function editItem(adminid, password) {
            clearFields();
            resetValidationErrors();
            showHideItem(adminid);

            $(""#adminid"").attr('disabled', false);
            $(""#adminid"").val(adminid);
            $(""#password"").val(password.replace(/~APOS/g, ""'"").replace(/~QUOT/g, '""').replace(/~NEWL/g, '\n'));
 
            return false;
        }

        function clearFields() {
            $(""#adminid"").val('');
            $(""#password"").val('');
        }

        function getSerializedData() {
            var adminid = $('#adminid').val();

            if (adminid == '')
                adminid = '-1';

     ");
                WriteLiteral(@"       var serializedData =
                ""'Adminid':'"" + adminid + ""',"" +
                ""'Password':'"" + $('#password').val().replace(/~APOS/g, ""'"").replace(/~QUOT/g, '""').replace(/~NEWL/g, '\n').replace(/'/g, ""\\'"") + ""'"";

            return serializedData;
        }

        function isDataValid() {
            var isValid = true;

            // get item values that needs to be validated
            var password = $('#password').val();

            // clear all validation messages
            $('#passwordValidation').text('');

            // validation
            if (password == '') { isValid = false; $(""#passwordValidation"").text('Password is required.'); }
            if (password.length > 50) { isValid = false; $(""#passwordValidation"").text('Password must be 50 characters or less.'); }

            if (isValid)
                return true;
            else
                return false;
        }

 
        function editFormatter(cellvalue, options, rowObject) {
      ");
                WriteLiteral(@"      return cellvalue;
        }
 
        function deleteFormatter(cellvalue, options, rowObject) {
            return cellvalue;
        }
 
        $(function () {
            InitializeAddUpdateRecordDialog();
            $('.datetextbox').datepicker({ dateFormat: ""m/d/yy"" });

            $('#list-grid').jqGrid({
                url: '/LoginTable/LoginTable_ListCrud?handler=GridData',
                datatype: 'json',
                mtype: 'GET',
                colNames: ['Adminid','Password', '', ''],
                colModel: [
                    { name: 'Adminid', index: 'Adminid', align: 'right' },
                    { name: 'Password', index: 'Password', align: 'left' },
                    { name: 'editoperation', index: 'editoperation', align: 'center', width: 40, sortable: false, formatter: editFormatter },
                    { name: 'deleteoperation', index: 'deleteoperation', align: 'center', width: 40, sortable: false, formatter: deleteFormatter },
                ],");
                WriteLiteral(@"
                pager: $('#list-pager'),
                rowNum: 10,
                pageable: true,
                autoencode: true,
                jsonReader:
                {
                    page: ""d.page""
                },
                rowList: [5, 10, 20, 50],
                sortname: 'Adminid',
                sortorder: ""asc"",
                viewrecords: true,
                caption: 'List of Login Table',
                height: '100%',
                width: '1200',
                gridComplete: function () {
                    var ids = jQuery(""#list-grid"").jqGrid('getDataIDs');
                    for (var i = 0; i < ids.length; i++) {
                        var currentid = ids[i];
                        var adminid = jQuery(""#list-grid"").jqGrid('getCell', ids[i], 'Adminid');
                        var password = jQuery(""#list-grid"").jqGrid('getCell', ids[i], 'Password').replace(/'/g, '~APOS').replace(/""/g, '~QUOT').replace(/\n/g, '~NEWL');

               ");
                WriteLiteral(@"         editLink = ""<a href='#' onclick=\""editItem('"" + adminid + ""','"" + password + ""')\""><img src='/images/Edit.gif' style='border:none;' /></a>"";
                        deleteLink = ""<a href='#' onclick=\""deleteItem('"" + currentid + ""')\""><img src='/images/Delete.png' style='border:none;' /></a>"";
                        jQuery(""#list-grid"").jqGrid('setRowData', ids[i], { editoperation: editLink });
                        jQuery(""#list-grid"").jqGrid('setRowData', ids[i], { deleteoperation: deleteLink });
                    }
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
            BeginContext(5547, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(5554, 17, false);
#line 142 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\LoginTable\LoginTable_ListCrud.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(5571, 82, true);
            WriteLiteral("</h2>\r\n<br /><br />\r\n<div id=\"addUpdateRecordDialog\" title=\"Add New LoginTable\">\r\n");
            EndContext();
            BeginContext(5653, 1602, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "616feb5941334f51a88e10b32d158ba3", async() => {
                BeginContext(5673, 170, true);
                WriteLiteral("\r\n    <div>\r\n        <fieldset>\r\n            <legend></legend>\r\n            <table>\r\n                <tr id=\"trPrimaryKey\">\r\n                    <td class=\"editor-label\">");
                EndContext();
                BeginContext(5843, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "740e706c2af34a28beaa188fd99c8494", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 151 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\LoginTable\LoginTable_ListCrud.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.LoginTable.Adminid);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5887, 118, true);
                WriteLiteral(":</td>\r\n                    <td><span style=\"color: red;\">*</span></td>\r\n                    <td class=\"editor-field\">");
                EndContext();
                BeginContext(6005, 71, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d8eecc7cc1044e618e09ece3db073310", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 153 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\LoginTable\LoginTable_ListCrud.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.LoginTable.Adminid);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6076, 149, true);
                WriteLiteral("</td>\r\n                    <td class=\"editor-field\"></td>\r\n                </tr>\r\n                <tr>\r\n                    <td class=\"editor-label\">");
                EndContext();
                BeginContext(6225, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "529ab28bafca43ceabeab3df8439a285", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 157 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\LoginTable\LoginTable_ListCrud.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.LoginTable.Password);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6270, 118, true);
                WriteLiteral(":</td>\r\n                    <td><span style=\"color: red;\">*</span></td>\r\n                    <td class=\"editor-field\">");
                EndContext();
                BeginContext(6388, 76, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "983ec840e5ac4e2f8b9de4a678dfaf94", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 159 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\LoginTable\LoginTable_ListCrud.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.LoginTable.Password);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6464, 784, true);
                WriteLiteral(@"</td>
                    <td class=""editor-field""><span id=""passwordValidation"" style=""color: red;""></span></td>
                </tr>
                <tr>
                    <td colspan=""2""></td>
                    <td colspan=""2"">
                        <br />
                        <input id=""inputAdd"" name=""inputAdd"" type=""button"" value=""Add"" class=""button-150"" onclick=""saveNewItem()"" />
                        <input id=""inputUpdate"" name=""inputUpdate"" type=""button"" value=""Update"" class=""button-150"" onclick=""updateCurrentItem()"" />
                        <input type=""button"" value=""Cancel"" onclick=""closeDialog(); return false;"" class=""button-100"" />
                    </td>
                </tr>
            </table>
        </fieldset>
    </div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7255, 122, true);
            WriteLiteral("\r\n</div>\r\n\r\n<div id=\"errorConfirmationDialog\"></div>\r\n<div id=\"errorDialog\"></div>\r\n\r\n<a href=\"#\" onclick=\"addItem()\"><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 7377, "\"", 7415, 1);
#line 180 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\LoginTable\LoginTable_ListCrud.cshtml"
WriteAttributeValue("", 7383, Url.Content("~/images/Add.gif"), 7383, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7416, 193, true);
            WriteLiteral(" alt=\"Add New LoginTable\" style=\"border: none;\" /></a>&nbsp;<a href=\"#\" onclick=\"addItem()\">Add New LoginTable</a>\r\n<br /><br />\r\n\r\n<table id=\"list-grid\"></table>\r\n<div id=\"list-pager\"></div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentEnquiry.Pages.LoginTable_ListCrudModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<StudentEnquiry.Pages.LoginTable_ListCrudModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<StudentEnquiry.Pages.LoginTable_ListCrudModel>)PageContext?.ViewData;
        public StudentEnquiry.Pages.LoginTable_ListCrudModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
