#pragma checksum "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry\CourseEnquiry\Pages\UserRoles\UserRoles_ListForeach.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed5d479fb72b941fe12e1e398caf389cc036e2b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_UserRoles_UserRoles_ListForeach), @"mvc.1.0.razor-page", @"/Pages/UserRoles/UserRoles_ListForeach.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/UserRoles/UserRoles_ListForeach.cshtml", typeof(AspNetCore.Pages_UserRoles_UserRoles_ListForeach), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed5d479fb72b941fe12e1e398caf389cc036e2b9", @"/Pages/UserRoles/UserRoles_ListForeach.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d7adc9b5393aadd02d84d55da8db31774ef9629", @"/Pages/_ViewImports.cshtml")]
    public class Pages_UserRoles_UserRoles_ListForeach : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 3 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry\CourseEnquiry\Pages\UserRoles\UserRoles_ListForeach.cshtml"
  
    ViewData["Title"] = "List of User Roles";
    string bgColor = "#F7F6F3";

#line default
#line hidden
            BeginContext(149, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("AdditionalJavaScript", async() => {
                BeginContext(182, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(188, 76, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c15ad2fa5104c81bbc305d12cca91f9", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 9 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry\CourseEnquiry\Pages\UserRoles\UserRoles_ListForeach.cshtml"
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
                BeginContext(264, 120, true);
                WriteLiteral("\r\n\r\n    <script type=\"text/javascript\">\r\n        var urlAndMethod = \'/UserRoles/UserRoles_ListForeach\';\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(387, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(394, 17, false);
#line 16 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry\CourseEnquiry\Pages\UserRoles\UserRoles_ListForeach.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(411, 177, true);
            WriteLiteral("</h2>\r\n<br /><br />\r\n<div id=\"errorConfirmationDialog\"></div>\r\n<div id=\"errorDialog\"></div>\r\n\r\n<a href=\"/UserRoles/UserRoles_Add?returnUrl=/UserRoles/UserRoles_ListForeach\"><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 588, "\"", 626, 1);
#line 21 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry\CourseEnquiry\Pages\UserRoles\UserRoles_ListForeach.cshtml"
WriteAttributeValue("", 594, Url.Content("~/images/Add.gif"), 594, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(627, 366, true);
            WriteLiteral(@" alt=""Add New User Roles"" style=""border: none;"" /></a>&nbsp;<a href=""/UserRoles/UserRoles_Add?returnUrl=/UserRoles/UserRoles_ListForeach"">Add New User Roles</a>
<br /><br />

<table class=""gridviewGridLines"" cellspacing =""0"" cellpadding=""8"" style=""width:100%;border-collapse:collapse;"">
    <tr style=""color:#2E6E9E;background-color:#DFEFFC;font-weight:bold;"">
");
            EndContext();
#line 26 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry\CourseEnquiry\Pages\UserRoles\UserRoles_ListForeach.cshtml"
         for (int i = 0; i < Model.UserRolesFieldNames.GetLength(0); i++)
        {
            string fieldName = Model.UserRolesFieldNames[i, 0];
            string title = Model.UserRolesFieldNames[i, 1];

            if (Model.FieldToSortWithOrder.Contains(fieldName) && Model.FieldToSortWithOrder.Contains("asc"))
            {

#line default
#line hidden
            BeginContext(1333, 22, true);
            WriteLiteral("                <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1355, "\"", 1405, 3);
            WriteAttributeValue("", 1362, "?sidx=", 1362, 6, true);
#line 33 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry\CourseEnquiry\Pages\UserRoles\UserRoles_ListForeach.cshtml"
WriteAttributeValue("", 1368, fieldName, 1368, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 1378, "&sord=desc&handler=GridData", 1378, 27, true);
            EndWriteAttribute();
            BeginContext(1406, 24, true);
            WriteLiteral(" style=\"color:#2E6E9E;\">");
            EndContext();
            BeginContext(1431, 5, false);
#line 33 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry\CourseEnquiry\Pages\UserRoles\UserRoles_ListForeach.cshtml"
                                                                                            Write(title);

#line default
#line hidden
            EndContext();
            BeginContext(1436, 4, true);
            WriteLiteral("</a>");
            EndContext();
#line 33 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry\CourseEnquiry\Pages\UserRoles\UserRoles_ListForeach.cshtml"
                                                                                                            if (Model.FieldToSortWithOrder == fieldName + " asc") {

#line default
#line hidden
            BeginContext(1496, 4, true);
            WriteLiteral("<img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1500, "\"", 1542, 1);
#line 33 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry\CourseEnquiry\Pages\UserRoles\UserRoles_ListForeach.cshtml"
WriteAttributeValue("", 1506, Url.Content("~/images/ArrowUp.png"), 1506, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1543, 10, true);
            WriteLiteral(" alt=\"\" />");
            EndContext();
#line 33 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry\CourseEnquiry\Pages\UserRoles\UserRoles_ListForeach.cshtml"
                                                                                                                                                                                                                            }

#line default
#line hidden
            BeginContext(1554, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 34 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry\CourseEnquiry\Pages\UserRoles\UserRoles_ListForeach.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(1609, 22, true);
            WriteLiteral("                <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1631, "\"", 1680, 3);
            WriteAttributeValue("", 1638, "?sidx=", 1638, 6, true);
#line 37 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry\CourseEnquiry\Pages\UserRoles\UserRoles_ListForeach.cshtml"
WriteAttributeValue("", 1644, fieldName, 1644, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 1654, "&sord=asc&handler=GridData", 1654, 26, true);
            EndWriteAttribute();
            BeginContext(1681, 24, true);
            WriteLiteral(" style=\"color:#2E6E9E;\">");
            EndContext();
            BeginContext(1706, 5, false);
#line 37 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry\CourseEnquiry\Pages\UserRoles\UserRoles_ListForeach.cshtml"
                                                                                           Write(title);

#line default
#line hidden
            EndContext();
            BeginContext(1711, 4, true);
            WriteLiteral("</a>");
            EndContext();
#line 37 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry\CourseEnquiry\Pages\UserRoles\UserRoles_ListForeach.cshtml"
                                                                                                           if (Model.FieldToSortWithOrder == fieldName + " desc") {

#line default
#line hidden
            BeginContext(1772, 4, true);
            WriteLiteral("<img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1776, "\"", 1820, 1);
#line 37 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry\CourseEnquiry\Pages\UserRoles\UserRoles_ListForeach.cshtml"
WriteAttributeValue("", 1782, Url.Content("~/images/ArrowDown.png"), 1782, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1821, 10, true);
            WriteLiteral(" alt=\"\" />");
            EndContext();
#line 37 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry\CourseEnquiry\Pages\UserRoles\UserRoles_ListForeach.cshtml"
                                                                                                                                                                                                                              }

#line default
#line hidden
            BeginContext(1832, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 38 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry\CourseEnquiry\Pages\UserRoles\UserRoles_ListForeach.cshtml"
            }
        }

#line default
#line hidden
            BeginContext(1865, 63, true);
            WriteLiteral("        <td>&nbsp;</td>\r\n        <td>&nbsp;</td>\r\n    </tr>\r\n\r\n");
            EndContext();
#line 44 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry\CourseEnquiry\Pages\UserRoles\UserRoles_ListForeach.cshtml"
     foreach (var item in Model.UserRolesData)
    {

#line default
#line hidden
            BeginContext(1983, 11, true);
            WriteLiteral("        <tr");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 1994, "\"", 2043, 4);
            WriteAttributeValue("", 2002, "color:#333333;", 2002, 14, true);
            WriteAttributeValue(" ", 2016, "background-color:", 2017, 18, true);
#line 46 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry\CourseEnquiry\Pages\UserRoles\UserRoles_ListForeach.cshtml"
WriteAttributeValue("", 2034, bgColor, 2034, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 2042, ";", 2042, 1, true);
            EndWriteAttribute();
            BeginContext(2044, 33, true);
            WriteLiteral(">\r\n            <td align=\"right\">");
            EndContext();
            BeginContext(2078, 15, false);
#line 47 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry\CourseEnquiry\Pages\UserRoles\UserRoles_ListForeach.cshtml"
                         Write(item.UserRoleId);

#line default
#line hidden
            EndContext();
            BeginContext(2093, 37, true);
            WriteLiteral("</td>\r\n            <td align=\"right\">");
            EndContext();
            BeginContext(2130, 117, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa6de91feca648e8a0f8dacdd26fcb28", async() => {
                BeginContext(2232, 11, false);
#line 48 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry\CourseEnquiry\Pages\UserRoles\UserRoles_ListForeach.cshtml"
                                                                                                                              Write(item.UserId);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2139, "~/UserMaster/UserMaster_Details?id=", 2139, 35, true);
#line 48 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry\CourseEnquiry\Pages\UserRoles\UserRoles_ListForeach.cshtml"
AddHtmlAttributeValue("", 2174, item.UserId, 2174, 12, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 2186, "&returnUrl=/UserRoles/UserRoles_ListForeach", 2186, 43, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2247, 37, true);
            WriteLiteral("</td>\r\n            <td align=\"right\">");
            EndContext();
            BeginContext(2284, 117, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28bf1c01cc144417a7bf4cc5a1120c92", async() => {
                BeginContext(2386, 11, false);
#line 49 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry\CourseEnquiry\Pages\UserRoles\UserRoles_ListForeach.cshtml"
                                                                                                                              Write(item.RoleId);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2293, "~/RoleMaster/RoleMaster_Details?id=", 2293, 35, true);
#line 49 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry\CourseEnquiry\Pages\UserRoles\UserRoles_ListForeach.cshtml"
AddHtmlAttributeValue("", 2328, item.RoleId, 2328, 12, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 2340, "&returnUrl=/UserRoles/UserRoles_ListForeach", 2340, 43, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2401, 67, true);
            WriteLiteral("</td>\r\n            <td align=\"center\"><span><input type=\"checkbox\" ");
            EndContext();
            BeginContext(2470, 40, false);
#line 50 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry\CourseEnquiry\Pages\UserRoles\UserRoles_ListForeach.cshtml"
                                                        Write(item.Status ? "checked=\"checked\"" : "");

#line default
#line hidden
            EndContext();
            BeginContext(2511, 108, true);
            WriteLiteral(" disabled=\"disabled\" /></span></td>\r\n            <td align=\"center\" style=\"width:30px;\">\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2619, "\"", 2716, 3);
            WriteAttributeValue("", 2626, "/UserRoles/UserRoles_Update?id=", 2626, 31, true);
#line 52 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry\CourseEnquiry\Pages\UserRoles\UserRoles_ListForeach.cshtml"
WriteAttributeValue("", 2657, item.UserRoleId, 2657, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 2673, "&returnUrl=/UserRoles/UserRoles_ListForeach", 2673, 43, true);
            EndWriteAttribute();
            BeginContext(2717, 27, true);
            WriteLiteral(" title=\"Click to edit\"><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2744, "\"", 2783, 1);
#line 52 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry\CourseEnquiry\Pages\UserRoles\UserRoles_ListForeach.cshtml"
WriteAttributeValue("", 2750, Url.Content("~/images/Edit.gif"), 2750, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2784, 184, true);
            WriteLiteral(" alt=\"\" style=\"border:none;\" /></a>\r\n            </td>\r\n            <td align=\"center\" style=\"width:30px;\">\r\n                <input type=\"image\" id=\"imgDelete1\" title=\"Click to delete\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2968, "\"", 3009, 1);
#line 55 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry\CourseEnquiry\Pages\UserRoles\UserRoles_ListForeach.cshtml"
WriteAttributeValue("", 2974, Url.Content("~/images/Delete.png"), 2974, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 3010, "\"", 3051, 3);
            WriteAttributeValue("", 3020, "deleteItem(\'", 3020, 12, true);
#line 55 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry\CourseEnquiry\Pages\UserRoles\UserRoles_ListForeach.cshtml"
WriteAttributeValue("", 3032, item.UserRoleId, 3032, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 3048, "\');", 3048, 3, true);
            EndWriteAttribute();
            BeginContext(3052, 66, true);
            WriteLiteral(" style=\"border-style:none;\" />\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 58 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry\CourseEnquiry\Pages\UserRoles\UserRoles_ListForeach.cshtml"

        bgColor = bgColor == "#F7F6F3" ? "White" : "#F7F6F3";
    }

#line default
#line hidden
            BeginContext(3190, 157, true);
            WriteLiteral("\r\n    <tr class=\"gridviewPagerStyle\" align=\"center\" style=\"background-color:#DFEFFC;\">\r\n        <td colspan=\"6\">\r\n            <table>\r\n                <tr>\r\n");
            EndContext();
#line 66 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry\CourseEnquiry\Pages\UserRoles\UserRoles_ListForeach.cshtml"
                     if (Model.CurrentPage > Model.NumberOfPagesToShow)
                    {

#line default
#line hidden
            BeginContext(3443, 30, true);
            WriteLiteral("                        <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3473, "\"", 3556, 5);
            WriteAttributeValue("", 3480, "?sidx=", 3480, 6, true);
#line 68 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry\CourseEnquiry\Pages\UserRoles\UserRoles_ListForeach.cshtml"
WriteAttributeValue("", 3486, Model.FieldToSort, 3486, 18, false);

#line default
#line hidden
            WriteAttributeValue("", 3504, "&sord=", 3504, 6, true);
#line 68 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry\CourseEnquiry\Pages\UserRoles\UserRoles_ListForeach.cshtml"
WriteAttributeValue("", 3510, Model.FieldSortOrder, 3510, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 3531, "&_page=1&handler=GridData", 3531, 25, true);
            EndWriteAttribute();
            BeginContext(3557, 72, true);
            WriteLiteral(" style=\"color:#000000;\">< First</a></td>\r\n                        <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3629, "\"", 3733, 7);
            WriteAttributeValue("", 3636, "?sidx=", 3636, 6, true);
#line 69 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry\CourseEnquiry\Pages\UserRoles\UserRoles_ListForeach.cshtml"
WriteAttributeValue("", 3642, Model.FieldToSort, 3642, 18, false);

#line default
#line hidden
            WriteAttributeValue("", 3660, "&sord=", 3660, 6, true);
#line 69 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry\CourseEnquiry\Pages\UserRoles\UserRoles_ListForeach.cshtml"
WriteAttributeValue("", 3666, Model.FieldSortOrder, 3666, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 3687, "&_page=", 3687, 7, true);
#line 69 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry\CourseEnquiry\Pages\UserRoles\UserRoles_ListForeach.cshtml"
WriteAttributeValue("", 3694, Model.StartPage - 1, 3694, 22, false);

#line default
#line hidden
            WriteAttributeValue("", 3716, "&handler=GridData", 3716, 17, true);
            EndWriteAttribute();
            BeginContext(3734, 38, true);
            WriteLiteral(" style=\"color:#000000;\">...</a></td>\r\n");
            EndContext();
#line 70 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry\CourseEnquiry\Pages\UserRoles\UserRoles_ListForeach.cshtml"
                    }

#line default
#line hidden
            BeginContext(3795, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 72 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry\CourseEnquiry\Pages\UserRoles\UserRoles_ListForeach.cshtml"
                     for (int pageNumber = Model.StartPage; pageNumber <= Model.EndPage; pageNumber++)
                    {
                        if (pageNumber == Model.CurrentPage)
                        {

#line default
#line hidden
            BeginContext(4013, 62, true);
            WriteLiteral("                            <td><span style=\"font-size:12px;\">");
            EndContext();
            BeginContext(4076, 10, false);
#line 76 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry\CourseEnquiry\Pages\UserRoles\UserRoles_ListForeach.cshtml"
                                                         Write(pageNumber);

#line default
#line hidden
            EndContext();
            BeginContext(4086, 14, true);
            WriteLiteral("</span></td>\r\n");
            EndContext();
#line 77 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry\CourseEnquiry\Pages\UserRoles\UserRoles_ListForeach.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(4184, 34, true);
            WriteLiteral("                            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4218, "\"", 4311, 7);
            WriteAttributeValue("", 4225, "?sidx=", 4225, 6, true);
#line 80 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry\CourseEnquiry\Pages\UserRoles\UserRoles_ListForeach.cshtml"
WriteAttributeValue("", 4231, Model.FieldToSort, 4231, 18, false);

#line default
#line hidden
            WriteAttributeValue("", 4249, "&sord=", 4249, 6, true);
#line 80 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry\CourseEnquiry\Pages\UserRoles\UserRoles_ListForeach.cshtml"
WriteAttributeValue("", 4255, Model.FieldSortOrder, 4255, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 4276, "&_page=", 4276, 7, true);
#line 80 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry\CourseEnquiry\Pages\UserRoles\UserRoles_ListForeach.cshtml"
WriteAttributeValue("", 4283, pageNumber, 4283, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 4294, "&handler=GridData", 4294, 17, true);
            EndWriteAttribute();
            BeginContext(4312, 24, true);
            WriteLiteral(" style=\"color:#000000;\">");
            EndContext();
            BeginContext(4337, 10, false);
#line 80 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry\CourseEnquiry\Pages\UserRoles\UserRoles_ListForeach.cshtml"
                                                                                                                                                   Write(pageNumber);

#line default
#line hidden
            EndContext();
            BeginContext(4347, 11, true);
            WriteLiteral("</a></td>\r\n");
            EndContext();
#line 81 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry\CourseEnquiry\Pages\UserRoles\UserRoles_ListForeach.cshtml"
                        }
                    }

#line default
#line hidden
            BeginContext(4408, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 84 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry\CourseEnquiry\Pages\UserRoles\UserRoles_ListForeach.cshtml"
                     if (Model.EndPage < Model.TotalPages)
                    {

#line default
#line hidden
            BeginContext(4493, 30, true);
            WriteLiteral("                        <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4523, "\"", 4625, 7);
            WriteAttributeValue("", 4530, "?sidx=", 4530, 6, true);
#line 86 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry\CourseEnquiry\Pages\UserRoles\UserRoles_ListForeach.cshtml"
WriteAttributeValue("", 4536, Model.FieldToSort, 4536, 18, false);

#line default
#line hidden
            WriteAttributeValue("", 4554, "&sord=", 4554, 6, true);
#line 86 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry\CourseEnquiry\Pages\UserRoles\UserRoles_ListForeach.cshtml"
WriteAttributeValue("", 4560, Model.FieldSortOrder, 4560, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 4581, "&_page=", 4581, 7, true);
#line 86 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry\CourseEnquiry\Pages\UserRoles\UserRoles_ListForeach.cshtml"
WriteAttributeValue("", 4588, Model.EndPage + 1, 4588, 20, false);

#line default
#line hidden
            WriteAttributeValue("", 4608, "&handler=GridData", 4608, 17, true);
            EndWriteAttribute();
            BeginContext(4626, 68, true);
            WriteLiteral(" style=\"color:#000000;\">...</a></td>\r\n                        <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4694, "\"", 4793, 7);
            WriteAttributeValue("", 4701, "?sidx=", 4701, 6, true);
#line 87 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry\CourseEnquiry\Pages\UserRoles\UserRoles_ListForeach.cshtml"
WriteAttributeValue("", 4707, Model.FieldToSort, 4707, 18, false);

#line default
#line hidden
            WriteAttributeValue("", 4725, "&sord=", 4725, 6, true);
#line 87 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry\CourseEnquiry\Pages\UserRoles\UserRoles_ListForeach.cshtml"
WriteAttributeValue("", 4731, Model.FieldSortOrder, 4731, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 4752, "&_page=", 4752, 7, true);
#line 87 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry\CourseEnquiry\Pages\UserRoles\UserRoles_ListForeach.cshtml"
WriteAttributeValue("", 4759, Model.TotalPages, 4759, 17, false);

#line default
#line hidden
            WriteAttributeValue("", 4776, "&handler=GridData", 4776, 17, true);
            EndWriteAttribute();
            BeginContext(4794, 41, true);
            WriteLiteral(" style=\"color:#000000;\">Last ></a></td>\r\n");
            EndContext();
#line 88 "C:\Users\dell\Desktop\.net core Project\Dummy Project\CourseEnquiry\CourseEnquiry\Pages\UserRoles\UserRoles_ListForeach.cshtml"
                    }

#line default
#line hidden
            BeginContext(4858, 81, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CourseEnquiry.Pages.UserRoles_ListForeachModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CourseEnquiry.Pages.UserRoles_ListForeachModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CourseEnquiry.Pages.UserRoles_ListForeachModel>)PageContext?.ViewData;
        public CourseEnquiry.Pages.UserRoles_ListForeachModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
