#pragma checksum "C:\Users\Dad S. Wonkulah Jr\source\repos\EmployeeDepartmentSkillGenderManagementSystem.UI\EmployeeDepartmentSkillGenderManagementSystem.UI\Pages\SkillList\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6b4966385152df9b2c76bd24eb6b756e3c9a655"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(EmployeeDepartmentSkillGenderManagementSystem.UI.Pages.SkillList.Pages_SkillList_Index), @"mvc.1.0.razor-page", @"/Pages/SkillList/Index.cshtml")]
namespace EmployeeDepartmentSkillGenderManagementSystem.UI.Pages.SkillList
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Dad S. Wonkulah Jr\source\repos\EmployeeDepartmentSkillGenderManagementSystem.UI\EmployeeDepartmentSkillGenderManagementSystem.UI\Pages\_ViewImports.cshtml"
using EmployeeDepartmentSkillGenderManagementSystem.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dad S. Wonkulah Jr\source\repos\EmployeeDepartmentSkillGenderManagementSystem.UI\EmployeeDepartmentSkillGenderManagementSystem.UI\Pages\_ViewImports.cshtml"
using EmployeeDepartmentSkillGenderManagementSystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Dad S. Wonkulah Jr\source\repos\EmployeeDepartmentSkillGenderManagementSystem.UI\EmployeeDepartmentSkillGenderManagementSystem.UI\Pages\_ViewImports.cshtml"
using EmployeeManagementSystem.UserInterfaceApiCall;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6b4966385152df9b2c76bd24eb6b756e3c9a655", @"/Pages/SkillList/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f51b391edaad3f409eec8a2015cf59230432bd5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_SkillList_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_skillIterationPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Dad S. Wonkulah Jr\source\repos\EmployeeDepartmentSkillGenderManagementSystem.UI\EmployeeDepartmentSkillGenderManagementSystem.UI\Pages\SkillList\Index.cshtml"
  
    ViewData["Title"] = "Skill List";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2 class=\"display-4 mt-2\" style=\"font-size:7vw\">\r\n    Skill List<i class=\"oi oi-dashboard\" style=\"font-size:40px\"></i>\r\n</h2>\r\n<hr />\r\n");
#nullable restore
#line 11 "C:\Users\Dad S. Wonkulah Jr\source\repos\EmployeeDepartmentSkillGenderManagementSystem.UI\EmployeeDepartmentSkillGenderManagementSystem.UI\Pages\SkillList\Index.cshtml"
 if (Model.Skills.Any())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"ml-auto mb-2 mr-3\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b6b4966385152df9b2c76bd24eb6b756e3c9a6556461", async() => {
                WriteLiteral("Create new record");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n    </div>\r\n");
#nullable restore
#line 16 "C:\Users\Dad S. Wonkulah Jr\source\repos\EmployeeDepartmentSkillGenderManagementSystem.UI\EmployeeDepartmentSkillGenderManagementSystem.UI\Pages\SkillList\Index.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Dad S. Wonkulah Jr\source\repos\EmployeeDepartmentSkillGenderManagementSystem.UI\EmployeeDepartmentSkillGenderManagementSystem.UI\Pages\SkillList\Index.cshtml"
 if (Model.Skills.Any())
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""row"">
        <div class=""col-sm-12"">
            <div class=""table-responsive"">
                <table class=""table table-striped table-bordered table-hover"">
                    <thead>
                        <tr>
                            <th>Sex</th>
                            <th>Action</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 30 "C:\Users\Dad S. Wonkulah Jr\source\repos\EmployeeDepartmentSkillGenderManagementSystem.UI\EmployeeDepartmentSkillGenderManagementSystem.UI\Pages\SkillList\Index.cshtml"
                         foreach (var skill in Model.Skills)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b6b4966385152df9b2c76bd24eb6b756e3c9a6559111", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 32 "C:\Users\Dad S. Wonkulah Jr\source\repos\EmployeeDepartmentSkillGenderManagementSystem.UI\EmployeeDepartmentSkillGenderManagementSystem.UI\Pages\SkillList\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = skill;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 33 "C:\Users\Dad S. Wonkulah Jr\source\repos\EmployeeDepartmentSkillGenderManagementSystem.UI\EmployeeDepartmentSkillGenderManagementSystem.UI\Pages\SkillList\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 41 "C:\Users\Dad S. Wonkulah Jr\source\repos\EmployeeDepartmentSkillGenderManagementSystem.UI\EmployeeDepartmentSkillGenderManagementSystem.UI\Pages\SkillList\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""row"">
        <div class=""col-sm-12"">
            <div class=""card-deck"">
                <div class=""card"">
                    <div class=""card-header"">
                        <h3 class=""card-text"">
                            No record yet to be display! <i class=""oi oi-dashboard"" style=""font-size:20px""></i>
                        </h3>
                    </div>
                    <div class=""card-body"">
                        <h5 class=""card-text"">
                            Click on the button below to create new record
                            <i class=""oi oi-arrow-bottom""></i>
                        </h5>
                    </div>
                    <div class=""card-footer"">
                        <div class=""row"">
                            <div class=""col-sm-12"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b6b4966385152df9b2c76bd24eb6b756e3c9a65512379", async() => {
                WriteLiteral("\r\n                                    Create new record\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 74 "C:\Users\Dad S. Wonkulah Jr\source\repos\EmployeeDepartmentSkillGenderManagementSystem.UI\EmployeeDepartmentSkillGenderManagementSystem.UI\Pages\SkillList\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmployeeDepartmentSkillGenderManagementSystem.UI.Pages.SkillList.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EmployeeDepartmentSkillGenderManagementSystem.UI.Pages.SkillList.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EmployeeDepartmentSkillGenderManagementSystem.UI.Pages.SkillList.IndexModel>)PageContext?.ViewData;
        public EmployeeDepartmentSkillGenderManagementSystem.UI.Pages.SkillList.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
