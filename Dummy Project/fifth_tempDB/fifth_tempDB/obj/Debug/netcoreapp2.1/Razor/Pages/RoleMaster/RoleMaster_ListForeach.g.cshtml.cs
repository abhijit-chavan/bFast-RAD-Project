#pragma checksum "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\RoleMaster\RoleMaster_ListForeach.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5823dd150ac3fc4959c499eb876d3cc41ed75992"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_RoleMaster_RoleMaster_ListForeach), @"mvc.1.0.razor-page", @"/Pages/RoleMaster/RoleMaster_ListForeach.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/RoleMaster/RoleMaster_ListForeach.cshtml", typeof(AspNetCore.Pages_RoleMaster_RoleMaster_ListForeach), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5823dd150ac3fc4959c499eb876d3cc41ed75992", @"/Pages/RoleMaster/RoleMaster_ListForeach.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c03d768fe4c1090bb61b28ea762c3ac2c2dda16f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_RoleMaster_RoleMaster_ListForeach : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 3 "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\RoleMaster\RoleMaster_ListForeach.cshtml"
  
    ViewData["Title"] = "List of Role Master";
    string bgColor = "#F7F6F3";

#line default
#line hidden
            BeginContext(150, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("AdditionalJavaScript", async() => {
                BeginContext(183, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(189, 76, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4bf5172a981048a3ba5169aa91c17f5a", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 9 "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\RoleMaster\RoleMaster_ListForeach.cshtml"
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
                BeginContext(265, 122, true);
                WriteLiteral("\r\n\r\n    <script type=\"text/javascript\">\r\n        var urlAndMethod = \'/RoleMaster/RoleMaster_ListForeach\';\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(390, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(397, 17, false);
#line 16 "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\RoleMaster\RoleMaster_ListForeach.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(414, 181, true);
            WriteLiteral("</h2>\r\n<br /><br />\r\n<div id=\"errorConfirmationDialog\"></div>\r\n<div id=\"errorDialog\"></div>\r\n\r\n<a href=\"/RoleMaster/RoleMaster_Add?returnUrl=/RoleMaster/RoleMaster_ListForeach\"><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 595, "\"", 633, 1);
#line 21 "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\RoleMaster\RoleMaster_ListForeach.cshtml"
WriteAttributeValue("", 601, Url.Content("~/images/Add.gif"), 601, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(634, 372, true);
            WriteLiteral(@" alt=""Add New Role Master"" style=""border: none;"" /></a>&nbsp;<a href=""/RoleMaster/RoleMaster_Add?returnUrl=/RoleMaster/RoleMaster_ListForeach"">Add New Role Master</a>
<br /><br />

<table class=""gridviewGridLines"" cellspacing =""0"" cellpadding=""8"" style=""width:100%;border-collapse:collapse;"">
    <tr style=""color:#2E6E9E;background-color:#DFEFFC;font-weight:bold;"">
");
            EndContext();
#line 26 "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\RoleMaster\RoleMaster_ListForeach.cshtml"
         for (int i = 0; i < Model.RoleMasterFieldNames.GetLength(0); i++)
        {
            string fieldName = Model.RoleMasterFieldNames[i, 0];
            string title = Model.RoleMasterFieldNames[i, 1];

            if (Model.FieldToSortWithOrder.Contains(fieldName) && Model.FieldToSortWithOrder.Contains("asc"))
            {

#line default
#line hidden
            BeginContext(1349, 22, true);
            WriteLiteral("                <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1371, "\"", 1421, 3);
            WriteAttributeValue("", 1378, "?sidx=", 1378, 6, true);
#line 33 "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\RoleMaster\RoleMaster_ListForeach.cshtml"
WriteAttributeValue("", 1384, fieldName, 1384, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 1394, "&sord=desc&handler=GridData", 1394, 27, true);
            EndWriteAttribute();
            BeginContext(1422, 24, true);
            WriteLiteral(" style=\"color:#2E6E9E;\">");
            EndContext();
            BeginContext(1447, 5, false);
#line 33 "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\RoleMaster\RoleMaster_ListForeach.cshtml"
                                                                                            Write(title);

#line default
#line hidden
            EndContext();
            BeginContext(1452, 4, true);
            WriteLiteral("</a>");
            EndContext();
#line 33 "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\RoleMaster\RoleMaster_ListForeach.cshtml"
                                                                                                            if (Model.FieldToSortWithOrder == fieldName + " asc") {

#line default
#line hidden
            BeginContext(1512, 4, true);
            WriteLiteral("<img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1516, "\"", 1558, 1);
#line 33 "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\RoleMaster\RoleMaster_ListForeach.cshtml"
WriteAttributeValue("", 1522, Url.Content("~/images/ArrowUp.png"), 1522, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1559, 10, true);
            WriteLiteral(" alt=\"\" />");
            EndContext();
#line 33 "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\RoleMaster\RoleMaster_ListForeach.cshtml"
                                                                                                                                                                                                                            }

#line default
#line hidden
            BeginContext(1570, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 34 "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\RoleMaster\RoleMaster_ListForeach.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(1625, 22, true);
            WriteLiteral("                <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1647, "\"", 1696, 3);
            WriteAttributeValue("", 1654, "?sidx=", 1654, 6, true);
#line 37 "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\RoleMaster\RoleMaster_ListForeach.cshtml"
WriteAttributeValue("", 1660, fieldName, 1660, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 1670, "&sord=asc&handler=GridData", 1670, 26, true);
            EndWriteAttribute();
            BeginContext(1697, 24, true);
            WriteLiteral(" style=\"color:#2E6E9E;\">");
            EndContext();
            BeginContext(1722, 5, false);
#line 37 "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\RoleMaster\RoleMaster_ListForeach.cshtml"
                                                                                           Write(title);

#line default
#line hidden
            EndContext();
            BeginContext(1727, 4, true);
            WriteLiteral("</a>");
            EndContext();
#line 37 "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\RoleMaster\RoleMaster_ListForeach.cshtml"
                                                                                                           if (Model.FieldToSortWithOrder == fieldName + " desc") {

#line default
#line hidden
            BeginContext(1788, 4, true);
            WriteLiteral("<img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1792, "\"", 1836, 1);
#line 37 "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\RoleMaster\RoleMaster_ListForeach.cshtml"
WriteAttributeValue("", 1798, Url.Content("~/images/ArrowDown.png"), 1798, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1837, 10, true);
            WriteLiteral(" alt=\"\" />");
            EndContext();
#line 37 "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\RoleMaster\RoleMaster_ListForeach.cshtml"
                                                                                                                                                                                                                              }

#line default
#line hidden
            BeginContext(1848, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 38 "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\RoleMaster\RoleMaster_ListForeach.cshtml"
            }
        }

#line default
#line hidden
            BeginContext(1881, 63, true);
            WriteLiteral("        <td>&nbsp;</td>\r\n        <td>&nbsp;</td>\r\n    </tr>\r\n\r\n");
            EndContext();
#line 44 "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\RoleMaster\RoleMaster_ListForeach.cshtml"
     foreach (var item in Model.RoleMasterData)
    {

#line default
#line hidden
            BeginContext(2000, 11, true);
            WriteLiteral("        <tr");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 2011, "\"", 2060, 4);
            WriteAttributeValue("", 2019, "color:#333333;", 2019, 14, true);
            WriteAttributeValue(" ", 2033, "background-color:", 2034, 18, true);
#line 46 "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\RoleMaster\RoleMaster_ListForeach.cshtml"
WriteAttributeValue("", 2051, bgColor, 2051, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 2059, ";", 2059, 1, true);
            EndWriteAttribute();
            BeginContext(2061, 33, true);
            WriteLiteral(">\r\n            <td align=\"right\">");
            EndContext();
            BeginContext(2095, 11, false);
#line 47 "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\RoleMaster\RoleMaster_ListForeach.cshtml"
                         Write(item.RoleId);

#line default
#line hidden
            EndContext();
            BeginContext(2106, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(2130, 20, false);
#line 48 "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\RoleMaster\RoleMaster_ListForeach.cshtml"
           Write(item.RoleDescription);

#line default
#line hidden
            EndContext();
            BeginContext(2150, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(2174, 28, false);
#line 49 "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\RoleMaster\RoleMaster_ListForeach.cshtml"
           Write(item.CreatedOn.ToString("d"));

#line default
#line hidden
            EndContext();
            BeginContext(2202, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(2226, 14, false);
#line 50 "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\RoleMaster\RoleMaster_ListForeach.cshtml"
           Write(item.CreatedBy);

#line default
#line hidden
            EndContext();
            BeginContext(2240, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(2265, 67, false);
#line 51 "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\RoleMaster\RoleMaster_ListForeach.cshtml"
            Write(item.ModifiedOn.HasValue ? item.ModifiedOn.Value.ToString("d") : "");

#line default
#line hidden
            EndContext();
            BeginContext(2333, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(2357, 15, false);
#line 52 "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\RoleMaster\RoleMaster_ListForeach.cshtml"
           Write(item.ModifiedBy);

#line default
#line hidden
            EndContext();
            BeginContext(2372, 78, true);
            WriteLiteral("</td>\r\n            <td align=\"center\" style=\"width:30px;\">\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2450, "\"", 2547, 3);
            WriteAttributeValue("", 2457, "/RoleMaster/RoleMaster_Update?id=", 2457, 33, true);
#line 54 "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\RoleMaster\RoleMaster_ListForeach.cshtml"
WriteAttributeValue("", 2490, item.RoleId, 2490, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 2502, "&returnUrl=/RoleMaster/RoleMaster_ListForeach", 2502, 45, true);
            EndWriteAttribute();
            BeginContext(2548, 27, true);
            WriteLiteral(" title=\"Click to edit\"><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2575, "\"", 2614, 1);
#line 54 "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\RoleMaster\RoleMaster_ListForeach.cshtml"
WriteAttributeValue("", 2581, Url.Content("~/images/Edit.gif"), 2581, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2615, 184, true);
            WriteLiteral(" alt=\"\" style=\"border:none;\" /></a>\r\n            </td>\r\n            <td align=\"center\" style=\"width:30px;\">\r\n                <input type=\"image\" id=\"imgDelete1\" title=\"Click to delete\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2799, "\"", 2840, 1);
#line 57 "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\RoleMaster\RoleMaster_ListForeach.cshtml"
WriteAttributeValue("", 2805, Url.Content("~/images/Delete.png"), 2805, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 2841, "\"", 2878, 3);
            WriteAttributeValue("", 2851, "deleteItem(\'", 2851, 12, true);
#line 57 "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\RoleMaster\RoleMaster_ListForeach.cshtml"
WriteAttributeValue("", 2863, item.RoleId, 2863, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 2875, "\');", 2875, 3, true);
            EndWriteAttribute();
            BeginContext(2879, 66, true);
            WriteLiteral(" style=\"border-style:none;\" />\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 60 "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\RoleMaster\RoleMaster_ListForeach.cshtml"

        bgColor = bgColor == "#F7F6F3" ? "White" : "#F7F6F3";
    }

#line default
#line hidden
            BeginContext(3017, 157, true);
            WriteLiteral("\r\n    <tr class=\"gridviewPagerStyle\" align=\"center\" style=\"background-color:#DFEFFC;\">\r\n        <td colspan=\"8\">\r\n            <table>\r\n                <tr>\r\n");
            EndContext();
#line 68 "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\RoleMaster\RoleMaster_ListForeach.cshtml"
                     if (Model.CurrentPage > Model.NumberOfPagesToShow)
                    {

#line default
#line hidden
            BeginContext(3270, 30, true);
            WriteLiteral("                        <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3300, "\"", 3383, 5);
            WriteAttributeValue("", 3307, "?sidx=", 3307, 6, true);
#line 70 "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\RoleMaster\RoleMaster_ListForeach.cshtml"
WriteAttributeValue("", 3313, Model.FieldToSort, 3313, 18, false);

#line default
#line hidden
            WriteAttributeValue("", 3331, "&sord=", 3331, 6, true);
#line 70 "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\RoleMaster\RoleMaster_ListForeach.cshtml"
WriteAttributeValue("", 3337, Model.FieldSortOrder, 3337, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 3358, "&_page=1&handler=GridData", 3358, 25, true);
            EndWriteAttribute();
            BeginContext(3384, 72, true);
            WriteLiteral(" style=\"color:#000000;\">< First</a></td>\r\n                        <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3456, "\"", 3560, 7);
            WriteAttributeValue("", 3463, "?sidx=", 3463, 6, true);
#line 71 "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\RoleMaster\RoleMaster_ListForeach.cshtml"
WriteAttributeValue("", 3469, Model.FieldToSort, 3469, 18, false);

#line default
#line hidden
            WriteAttributeValue("", 3487, "&sord=", 3487, 6, true);
#line 71 "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\RoleMaster\RoleMaster_ListForeach.cshtml"
WriteAttributeValue("", 3493, Model.FieldSortOrder, 3493, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 3514, "&_page=", 3514, 7, true);
#line 71 "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\RoleMaster\RoleMaster_ListForeach.cshtml"
WriteAttributeValue("", 3521, Model.StartPage - 1, 3521, 22, false);

#line default
#line hidden
            WriteAttributeValue("", 3543, "&handler=GridData", 3543, 17, true);
            EndWriteAttribute();
            BeginContext(3561, 38, true);
            WriteLiteral(" style=\"color:#000000;\">...</a></td>\r\n");
            EndContext();
#line 72 "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\RoleMaster\RoleMaster_ListForeach.cshtml"
                    }

#line default
#line hidden
            BeginContext(3622, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 74 "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\RoleMaster\RoleMaster_ListForeach.cshtml"
                     for (int pageNumber = Model.StartPage; pageNumber <= Model.EndPage; pageNumber++)
                    {
                        if (pageNumber == Model.CurrentPage)
                        {

#line default
#line hidden
            BeginContext(3840, 62, true);
            WriteLiteral("                            <td><span style=\"font-size:12px;\">");
            EndContext();
            BeginContext(3903, 10, false);
#line 78 "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\RoleMaster\RoleMaster_ListForeach.cshtml"
                                                         Write(pageNumber);

#line default
#line hidden
            EndContext();
            BeginContext(3913, 14, true);
            WriteLiteral("</span></td>\r\n");
            EndContext();
#line 79 "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\RoleMaster\RoleMaster_ListForeach.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(4011, 34, true);
            WriteLiteral("                            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4045, "\"", 4138, 7);
            WriteAttributeValue("", 4052, "?sidx=", 4052, 6, true);
#line 82 "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\RoleMaster\RoleMaster_ListForeach.cshtml"
WriteAttributeValue("", 4058, Model.FieldToSort, 4058, 18, false);

#line default
#line hidden
            WriteAttributeValue("", 4076, "&sord=", 4076, 6, true);
#line 82 "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\RoleMaster\RoleMaster_ListForeach.cshtml"
WriteAttributeValue("", 4082, Model.FieldSortOrder, 4082, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 4103, "&_page=", 4103, 7, true);
#line 82 "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\RoleMaster\RoleMaster_ListForeach.cshtml"
WriteAttributeValue("", 4110, pageNumber, 4110, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 4121, "&handler=GridData", 4121, 17, true);
            EndWriteAttribute();
            BeginContext(4139, 24, true);
            WriteLiteral(" style=\"color:#000000;\">");
            EndContext();
            BeginContext(4164, 10, false);
#line 82 "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\RoleMaster\RoleMaster_ListForeach.cshtml"
                                                                                                                                                   Write(pageNumber);

#line default
#line hidden
            EndContext();
            BeginContext(4174, 11, true);
            WriteLiteral("</a></td>\r\n");
            EndContext();
#line 83 "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\RoleMaster\RoleMaster_ListForeach.cshtml"
                        }
                    }

#line default
#line hidden
            BeginContext(4235, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 86 "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\RoleMaster\RoleMaster_ListForeach.cshtml"
                     if (Model.EndPage < Model.TotalPages)
                    {

#line default
#line hidden
            BeginContext(4320, 30, true);
            WriteLiteral("                        <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4350, "\"", 4452, 7);
            WriteAttributeValue("", 4357, "?sidx=", 4357, 6, true);
#line 88 "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\RoleMaster\RoleMaster_ListForeach.cshtml"
WriteAttributeValue("", 4363, Model.FieldToSort, 4363, 18, false);

#line default
#line hidden
            WriteAttributeValue("", 4381, "&sord=", 4381, 6, true);
#line 88 "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\RoleMaster\RoleMaster_ListForeach.cshtml"
WriteAttributeValue("", 4387, Model.FieldSortOrder, 4387, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 4408, "&_page=", 4408, 7, true);
#line 88 "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\RoleMaster\RoleMaster_ListForeach.cshtml"
WriteAttributeValue("", 4415, Model.EndPage + 1, 4415, 20, false);

#line default
#line hidden
            WriteAttributeValue("", 4435, "&handler=GridData", 4435, 17, true);
            EndWriteAttribute();
            BeginContext(4453, 68, true);
            WriteLiteral(" style=\"color:#000000;\">...</a></td>\r\n                        <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4521, "\"", 4620, 7);
            WriteAttributeValue("", 4528, "?sidx=", 4528, 6, true);
#line 89 "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\RoleMaster\RoleMaster_ListForeach.cshtml"
WriteAttributeValue("", 4534, Model.FieldToSort, 4534, 18, false);

#line default
#line hidden
            WriteAttributeValue("", 4552, "&sord=", 4552, 6, true);
#line 89 "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\RoleMaster\RoleMaster_ListForeach.cshtml"
WriteAttributeValue("", 4558, Model.FieldSortOrder, 4558, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 4579, "&_page=", 4579, 7, true);
#line 89 "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\RoleMaster\RoleMaster_ListForeach.cshtml"
WriteAttributeValue("", 4586, Model.TotalPages, 4586, 17, false);

#line default
#line hidden
            WriteAttributeValue("", 4603, "&handler=GridData", 4603, 17, true);
            EndWriteAttribute();
            BeginContext(4621, 41, true);
            WriteLiteral(" style=\"color:#000000;\">Last ></a></td>\r\n");
            EndContext();
#line 90 "C:\Users\dell\Desktop\.net core Project\Dummy Project\fifth_tempDB\fifth_tempDB\Pages\RoleMaster\RoleMaster_ListForeach.cshtml"
                    }

#line default
#line hidden
            BeginContext(4685, 81, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<fifth_tempDB.Pages.RoleMaster_ListForeachModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<fifth_tempDB.Pages.RoleMaster_ListForeachModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<fifth_tempDB.Pages.RoleMaster_ListForeachModel>)PageContext?.ViewData;
        public fifth_tempDB.Pages.RoleMaster_ListForeachModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
