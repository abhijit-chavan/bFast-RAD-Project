#pragma checksum "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\WorkflowStepsMaster\WorkflowStepsMaster_ListForeach.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6faa29ea9dbe9765fd30597a9042d66a79068fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_WorkflowStepsMaster_WorkflowStepsMaster_ListForeach), @"mvc.1.0.razor-page", @"/Pages/WorkflowStepsMaster/WorkflowStepsMaster_ListForeach.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/WorkflowStepsMaster/WorkflowStepsMaster_ListForeach.cshtml", typeof(AspNetCore.Pages_WorkflowStepsMaster_WorkflowStepsMaster_ListForeach), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6faa29ea9dbe9765fd30597a9042d66a79068fd", @"/Pages/WorkflowStepsMaster/WorkflowStepsMaster_ListForeach.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62c0313e94265ea202c2b341a7c6893504740388", @"/Pages/_ViewImports.cshtml")]
    public class Pages_WorkflowStepsMaster_WorkflowStepsMaster_ListForeach : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/jqgrid-listforeach.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\WorkflowStepsMaster\WorkflowStepsMaster_ListForeach.cshtml"
  
    ViewData["Title"] = "List of Workflow Steps Master";
    string bgColor = "#F7F6F3";

#line default
#line hidden
            BeginContext(171, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("AdditionalJavaScript", async() => {
                BeginContext(204, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(210, 76, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2bf70b0416694c0e8b3965f039df3a58", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 9 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\WorkflowStepsMaster\WorkflowStepsMaster_ListForeach.cshtml"
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
                BeginContext(286, 140, true);
                WriteLiteral("\r\n\r\n    <script type=\"text/javascript\">\r\n        var urlAndMethod = \'/WorkflowStepsMaster/WorkflowStepsMaster_ListForeach\';\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(429, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(436, 17, false);
#line 16 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\WorkflowStepsMaster\WorkflowStepsMaster_ListForeach.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(453, 217, true);
            WriteLiteral("</h2>\r\n<br /><br />\r\n<div id=\"errorConfirmationDialog\"></div>\r\n<div id=\"errorDialog\"></div>\r\n\r\n<a href=\"/WorkflowStepsMaster/WorkflowStepsMaster_Add?returnUrl=/WorkflowStepsMaster/WorkflowStepsMaster_ListForeach\"><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 670, "\"", 708, 1);
#line 21 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\WorkflowStepsMaster\WorkflowStepsMaster_ListForeach.cshtml"
WriteAttributeValue("", 676, Url.Content("~/images/Add.gif"), 676, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(709, 428, true);
            WriteLiteral(@" alt=""Add New Workflow Steps Master"" style=""border: none;"" /></a>&nbsp;<a href=""/WorkflowStepsMaster/WorkflowStepsMaster_Add?returnUrl=/WorkflowStepsMaster/WorkflowStepsMaster_ListForeach"">Add New Workflow Steps Master</a>
<br /><br />

<table class=""gridviewGridLines"" cellspacing =""0"" cellpadding=""8"" style=""width:100%;border-collapse:collapse;"">
    <tr style=""color:#2E6E9E;background-color:#DFEFFC;font-weight:bold;"">
");
            EndContext();
#line 26 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\WorkflowStepsMaster\WorkflowStepsMaster_ListForeach.cshtml"
         for (int i = 0; i < Model.WorkflowStepsMasterFieldNames.GetLength(0); i++)
        {
            string fieldName = Model.WorkflowStepsMasterFieldNames[i, 0];
            string title = Model.WorkflowStepsMasterFieldNames[i, 1];

            if (Model.FieldToSortWithOrder.Contains(fieldName) && Model.FieldToSortWithOrder.Contains("asc"))
            {

#line default
#line hidden
            BeginContext(1507, 22, true);
            WriteLiteral("                <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1529, "\"", 1579, 3);
            WriteAttributeValue("", 1536, "?sidx=", 1536, 6, true);
#line 33 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\WorkflowStepsMaster\WorkflowStepsMaster_ListForeach.cshtml"
WriteAttributeValue("", 1542, fieldName, 1542, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 1552, "&sord=desc&handler=GridData", 1552, 27, true);
            EndWriteAttribute();
            BeginContext(1580, 24, true);
            WriteLiteral(" style=\"color:#2E6E9E;\">");
            EndContext();
            BeginContext(1605, 5, false);
#line 33 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\WorkflowStepsMaster\WorkflowStepsMaster_ListForeach.cshtml"
                                                                                            Write(title);

#line default
#line hidden
            EndContext();
            BeginContext(1610, 4, true);
            WriteLiteral("</a>");
            EndContext();
#line 33 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\WorkflowStepsMaster\WorkflowStepsMaster_ListForeach.cshtml"
                                                                                                            if (Model.FieldToSortWithOrder == fieldName + " asc") {

#line default
#line hidden
            BeginContext(1670, 4, true);
            WriteLiteral("<img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1674, "\"", 1716, 1);
#line 33 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\WorkflowStepsMaster\WorkflowStepsMaster_ListForeach.cshtml"
WriteAttributeValue("", 1680, Url.Content("~/images/ArrowUp.png"), 1680, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1717, 10, true);
            WriteLiteral(" alt=\"\" />");
            EndContext();
#line 33 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\WorkflowStepsMaster\WorkflowStepsMaster_ListForeach.cshtml"
                                                                                                                                                                                                                            }

#line default
#line hidden
            BeginContext(1728, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 34 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\WorkflowStepsMaster\WorkflowStepsMaster_ListForeach.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(1783, 22, true);
            WriteLiteral("                <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1805, "\"", 1854, 3);
            WriteAttributeValue("", 1812, "?sidx=", 1812, 6, true);
#line 37 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\WorkflowStepsMaster\WorkflowStepsMaster_ListForeach.cshtml"
WriteAttributeValue("", 1818, fieldName, 1818, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 1828, "&sord=asc&handler=GridData", 1828, 26, true);
            EndWriteAttribute();
            BeginContext(1855, 24, true);
            WriteLiteral(" style=\"color:#2E6E9E;\">");
            EndContext();
            BeginContext(1880, 5, false);
#line 37 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\WorkflowStepsMaster\WorkflowStepsMaster_ListForeach.cshtml"
                                                                                           Write(title);

#line default
#line hidden
            EndContext();
            BeginContext(1885, 4, true);
            WriteLiteral("</a>");
            EndContext();
#line 37 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\WorkflowStepsMaster\WorkflowStepsMaster_ListForeach.cshtml"
                                                                                                           if (Model.FieldToSortWithOrder == fieldName + " desc") {

#line default
#line hidden
            BeginContext(1946, 4, true);
            WriteLiteral("<img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1950, "\"", 1994, 1);
#line 37 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\WorkflowStepsMaster\WorkflowStepsMaster_ListForeach.cshtml"
WriteAttributeValue("", 1956, Url.Content("~/images/ArrowDown.png"), 1956, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1995, 10, true);
            WriteLiteral(" alt=\"\" />");
            EndContext();
#line 37 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\WorkflowStepsMaster\WorkflowStepsMaster_ListForeach.cshtml"
                                                                                                                                                                                                                              }

#line default
#line hidden
            BeginContext(2006, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 38 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\WorkflowStepsMaster\WorkflowStepsMaster_ListForeach.cshtml"
            }
        }

#line default
#line hidden
            BeginContext(2039, 63, true);
            WriteLiteral("        <td>&nbsp;</td>\r\n        <td>&nbsp;</td>\r\n    </tr>\r\n\r\n");
            EndContext();
#line 44 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\WorkflowStepsMaster\WorkflowStepsMaster_ListForeach.cshtml"
     foreach (var item in Model.WorkflowStepsMasterData)
    {

#line default
#line hidden
            BeginContext(2167, 11, true);
            WriteLiteral("        <tr");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 2178, "\"", 2227, 4);
            WriteAttributeValue("", 2186, "color:#333333;", 2186, 14, true);
            WriteAttributeValue(" ", 2200, "background-color:", 2201, 18, true);
#line 46 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\WorkflowStepsMaster\WorkflowStepsMaster_ListForeach.cshtml"
WriteAttributeValue("", 2218, bgColor, 2218, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 2226, ";", 2226, 1, true);
            EndWriteAttribute();
            BeginContext(2228, 33, true);
            WriteLiteral(">\r\n            <td align=\"right\">");
            EndContext();
            BeginContext(2262, 11, false);
#line 47 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\WorkflowStepsMaster\WorkflowStepsMaster_ListForeach.cshtml"
                         Write(item.StepId);

#line default
#line hidden
            EndContext();
            BeginContext(2273, 37, true);
            WriteLiteral("</td>\r\n            <td align=\"right\">");
            EndContext();
            BeginContext(2310, 153, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8108229c68f84478892c32720e8c7520", async() => {
                BeginContext(2444, 15, false);
#line 48 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\WorkflowStepsMaster\WorkflowStepsMaster_ListForeach.cshtml"
                                                                                                                                                              Write(item.WorKflowId);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2319, "~/WorkflowMaster/WorkflowMaster_Details?id=", 2319, 43, true);
#line 48 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\WorkflowStepsMaster\WorkflowStepsMaster_ListForeach.cshtml"
AddHtmlAttributeValue("", 2362, item.WorKflowId, 2362, 16, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 2378, "&returnUrl=/WorkflowStepsMaster/WorkflowStepsMaster_ListForeach", 2378, 63, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2463, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(2487, 18, false);
#line 49 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\WorkflowStepsMaster\WorkflowStepsMaster_ListForeach.cshtml"
           Write(item.ApprovalLevel);

#line default
#line hidden
            EndContext();
            BeginContext(2505, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(2529, 16, false);
#line 50 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\WorkflowStepsMaster\WorkflowStepsMaster_ListForeach.cshtml"
           Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(2545, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(2569, 16, false);
#line 51 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\WorkflowStepsMaster\WorkflowStepsMaster_ListForeach.cshtml"
           Write(item.AutoApprove);

#line default
#line hidden
            EndContext();
            BeginContext(2585, 37, true);
            WriteLiteral("</td>\r\n            <td align=\"right\">");
            EndContext();
            BeginContext(2623, 13, false);
#line 52 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\WorkflowStepsMaster\WorkflowStepsMaster_ListForeach.cshtml"
                         Write(item.WaitTime);

#line default
#line hidden
            EndContext();
            BeginContext(2636, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(2660, 14, false);
#line 53 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\WorkflowStepsMaster\WorkflowStepsMaster_ListForeach.cshtml"
           Write(item.CreatedBy);

#line default
#line hidden
            EndContext();
            BeginContext(2674, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(2698, 28, false);
#line 54 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\WorkflowStepsMaster\WorkflowStepsMaster_ListForeach.cshtml"
           Write(item.CreatedOn.ToString("d"));

#line default
#line hidden
            EndContext();
            BeginContext(2726, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(2750, 14, false);
#line 55 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\WorkflowStepsMaster\WorkflowStepsMaster_ListForeach.cshtml"
           Write(item.UpdatedBy);

#line default
#line hidden
            EndContext();
            BeginContext(2764, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(2788, 28, false);
#line 56 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\WorkflowStepsMaster\WorkflowStepsMaster_ListForeach.cshtml"
           Write(item.UpdatedOn.ToString("d"));

#line default
#line hidden
            EndContext();
            BeginContext(2816, 78, true);
            WriteLiteral("</td>\r\n            <td align=\"center\" style=\"width:30px;\">\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2894, "\"", 3027, 3);
            WriteAttributeValue("", 2901, "/WorkflowStepsMaster/WorkflowStepsMaster_Update?id=", 2901, 51, true);
#line 58 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\WorkflowStepsMaster\WorkflowStepsMaster_ListForeach.cshtml"
WriteAttributeValue("", 2952, item.StepId, 2952, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 2964, "&returnUrl=/WorkflowStepsMaster/WorkflowStepsMaster_ListForeach", 2964, 63, true);
            EndWriteAttribute();
            BeginContext(3028, 27, true);
            WriteLiteral(" title=\"Click to edit\"><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3055, "\"", 3094, 1);
#line 58 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\WorkflowStepsMaster\WorkflowStepsMaster_ListForeach.cshtml"
WriteAttributeValue("", 3061, Url.Content("~/images/Edit.gif"), 3061, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3095, 184, true);
            WriteLiteral(" alt=\"\" style=\"border:none;\" /></a>\r\n            </td>\r\n            <td align=\"center\" style=\"width:30px;\">\r\n                <input type=\"image\" id=\"imgDelete1\" title=\"Click to delete\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3279, "\"", 3320, 1);
#line 61 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\WorkflowStepsMaster\WorkflowStepsMaster_ListForeach.cshtml"
WriteAttributeValue("", 3285, Url.Content("~/images/Delete.png"), 3285, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 3321, "\"", 3358, 3);
            WriteAttributeValue("", 3331, "deleteItem(\'", 3331, 12, true);
#line 61 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\WorkflowStepsMaster\WorkflowStepsMaster_ListForeach.cshtml"
WriteAttributeValue("", 3343, item.StepId, 3343, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 3355, "\');", 3355, 3, true);
            EndWriteAttribute();
            BeginContext(3359, 66, true);
            WriteLiteral(" style=\"border-style:none;\" />\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 64 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\WorkflowStepsMaster\WorkflowStepsMaster_ListForeach.cshtml"

        bgColor = bgColor == "#F7F6F3" ? "White" : "#F7F6F3";
    }

#line default
#line hidden
            BeginContext(3497, 158, true);
            WriteLiteral("\r\n    <tr class=\"gridviewPagerStyle\" align=\"center\" style=\"background-color:#DFEFFC;\">\r\n        <td colspan=\"12\">\r\n            <table>\r\n                <tr>\r\n");
            EndContext();
#line 72 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\WorkflowStepsMaster\WorkflowStepsMaster_ListForeach.cshtml"
                     if (Model.CurrentPage > Model.NumberOfPagesToShow)
                    {

#line default
#line hidden
            BeginContext(3751, 30, true);
            WriteLiteral("                        <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3781, "\"", 3864, 5);
            WriteAttributeValue("", 3788, "?sidx=", 3788, 6, true);
#line 74 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\WorkflowStepsMaster\WorkflowStepsMaster_ListForeach.cshtml"
WriteAttributeValue("", 3794, Model.FieldToSort, 3794, 18, false);

#line default
#line hidden
            WriteAttributeValue("", 3812, "&sord=", 3812, 6, true);
#line 74 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\WorkflowStepsMaster\WorkflowStepsMaster_ListForeach.cshtml"
WriteAttributeValue("", 3818, Model.FieldSortOrder, 3818, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 3839, "&_page=1&handler=GridData", 3839, 25, true);
            EndWriteAttribute();
            BeginContext(3865, 72, true);
            WriteLiteral(" style=\"color:#000000;\">< First</a></td>\r\n                        <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3937, "\"", 4041, 7);
            WriteAttributeValue("", 3944, "?sidx=", 3944, 6, true);
#line 75 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\WorkflowStepsMaster\WorkflowStepsMaster_ListForeach.cshtml"
WriteAttributeValue("", 3950, Model.FieldToSort, 3950, 18, false);

#line default
#line hidden
            WriteAttributeValue("", 3968, "&sord=", 3968, 6, true);
#line 75 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\WorkflowStepsMaster\WorkflowStepsMaster_ListForeach.cshtml"
WriteAttributeValue("", 3974, Model.FieldSortOrder, 3974, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 3995, "&_page=", 3995, 7, true);
#line 75 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\WorkflowStepsMaster\WorkflowStepsMaster_ListForeach.cshtml"
WriteAttributeValue("", 4002, Model.StartPage - 1, 4002, 22, false);

#line default
#line hidden
            WriteAttributeValue("", 4024, "&handler=GridData", 4024, 17, true);
            EndWriteAttribute();
            BeginContext(4042, 38, true);
            WriteLiteral(" style=\"color:#000000;\">...</a></td>\r\n");
            EndContext();
#line 76 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\WorkflowStepsMaster\WorkflowStepsMaster_ListForeach.cshtml"
                    }

#line default
#line hidden
            BeginContext(4103, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 78 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\WorkflowStepsMaster\WorkflowStepsMaster_ListForeach.cshtml"
                     for (int pageNumber = Model.StartPage; pageNumber <= Model.EndPage; pageNumber++)
                    {
                        if (pageNumber == Model.CurrentPage)
                        {

#line default
#line hidden
            BeginContext(4321, 62, true);
            WriteLiteral("                            <td><span style=\"font-size:12px;\">");
            EndContext();
            BeginContext(4384, 10, false);
#line 82 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\WorkflowStepsMaster\WorkflowStepsMaster_ListForeach.cshtml"
                                                         Write(pageNumber);

#line default
#line hidden
            EndContext();
            BeginContext(4394, 14, true);
            WriteLiteral("</span></td>\r\n");
            EndContext();
#line 83 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\WorkflowStepsMaster\WorkflowStepsMaster_ListForeach.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(4492, 34, true);
            WriteLiteral("                            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4526, "\"", 4619, 7);
            WriteAttributeValue("", 4533, "?sidx=", 4533, 6, true);
#line 86 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\WorkflowStepsMaster\WorkflowStepsMaster_ListForeach.cshtml"
WriteAttributeValue("", 4539, Model.FieldToSort, 4539, 18, false);

#line default
#line hidden
            WriteAttributeValue("", 4557, "&sord=", 4557, 6, true);
#line 86 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\WorkflowStepsMaster\WorkflowStepsMaster_ListForeach.cshtml"
WriteAttributeValue("", 4563, Model.FieldSortOrder, 4563, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 4584, "&_page=", 4584, 7, true);
#line 86 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\WorkflowStepsMaster\WorkflowStepsMaster_ListForeach.cshtml"
WriteAttributeValue("", 4591, pageNumber, 4591, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 4602, "&handler=GridData", 4602, 17, true);
            EndWriteAttribute();
            BeginContext(4620, 24, true);
            WriteLiteral(" style=\"color:#000000;\">");
            EndContext();
            BeginContext(4645, 10, false);
#line 86 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\WorkflowStepsMaster\WorkflowStepsMaster_ListForeach.cshtml"
                                                                                                                                                   Write(pageNumber);

#line default
#line hidden
            EndContext();
            BeginContext(4655, 11, true);
            WriteLiteral("</a></td>\r\n");
            EndContext();
#line 87 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\WorkflowStepsMaster\WorkflowStepsMaster_ListForeach.cshtml"
                        }
                    }

#line default
#line hidden
            BeginContext(4716, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 90 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\WorkflowStepsMaster\WorkflowStepsMaster_ListForeach.cshtml"
                     if (Model.EndPage < Model.TotalPages)
                    {

#line default
#line hidden
            BeginContext(4801, 30, true);
            WriteLiteral("                        <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4831, "\"", 4933, 7);
            WriteAttributeValue("", 4838, "?sidx=", 4838, 6, true);
#line 92 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\WorkflowStepsMaster\WorkflowStepsMaster_ListForeach.cshtml"
WriteAttributeValue("", 4844, Model.FieldToSort, 4844, 18, false);

#line default
#line hidden
            WriteAttributeValue("", 4862, "&sord=", 4862, 6, true);
#line 92 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\WorkflowStepsMaster\WorkflowStepsMaster_ListForeach.cshtml"
WriteAttributeValue("", 4868, Model.FieldSortOrder, 4868, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 4889, "&_page=", 4889, 7, true);
#line 92 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\WorkflowStepsMaster\WorkflowStepsMaster_ListForeach.cshtml"
WriteAttributeValue("", 4896, Model.EndPage + 1, 4896, 20, false);

#line default
#line hidden
            WriteAttributeValue("", 4916, "&handler=GridData", 4916, 17, true);
            EndWriteAttribute();
            BeginContext(4934, 68, true);
            WriteLiteral(" style=\"color:#000000;\">...</a></td>\r\n                        <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5002, "\"", 5101, 7);
            WriteAttributeValue("", 5009, "?sidx=", 5009, 6, true);
#line 93 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\WorkflowStepsMaster\WorkflowStepsMaster_ListForeach.cshtml"
WriteAttributeValue("", 5015, Model.FieldToSort, 5015, 18, false);

#line default
#line hidden
            WriteAttributeValue("", 5033, "&sord=", 5033, 6, true);
#line 93 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\WorkflowStepsMaster\WorkflowStepsMaster_ListForeach.cshtml"
WriteAttributeValue("", 5039, Model.FieldSortOrder, 5039, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 5060, "&_page=", 5060, 7, true);
#line 93 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\WorkflowStepsMaster\WorkflowStepsMaster_ListForeach.cshtml"
WriteAttributeValue("", 5067, Model.TotalPages, 5067, 17, false);

#line default
#line hidden
            WriteAttributeValue("", 5084, "&handler=GridData", 5084, 17, true);
            EndWriteAttribute();
            BeginContext(5102, 41, true);
            WriteLiteral(" style=\"color:#000000;\">Last ></a></td>\r\n");
            EndContext();
#line 94 "C:\Users\dell\Desktop\.net core Project\Dummy Project\StudentEnquiry\StudentEnquiry\Pages\WorkflowStepsMaster\WorkflowStepsMaster_ListForeach.cshtml"
                    }

#line default
#line hidden
            BeginContext(5166, 81, true);
            WriteLiteral("                </tr>\r\n            </table>\r\n        </td>\r\n    </tr>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentEnquiry.Pages.WorkflowStepsMaster_ListForeachModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<StudentEnquiry.Pages.WorkflowStepsMaster_ListForeachModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<StudentEnquiry.Pages.WorkflowStepsMaster_ListForeachModel>)PageContext?.ViewData;
        public StudentEnquiry.Pages.WorkflowStepsMaster_ListForeachModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
