#pragma checksum "F:\1-MVC PROJECT\Xceed-Task aya saied mohamed\nnnew master\n\Admin-master\Admin.Presentation\Views\Employee\AllEmployee.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a798da7a0f05ecc8d99dcec8f6a560a0693bb53b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_AllEmployee), @"mvc.1.0.view", @"/Views/Employee/AllEmployee.cshtml")]
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
#nullable restore
#line 1 "F:\1-MVC PROJECT\Xceed-Task aya saied mohamed\nnnew master\n\Admin-master\Admin.Presentation\Views\_ViewImports.cshtml"
using Admin.Presentation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\1-MVC PROJECT\Xceed-Task aya saied mohamed\nnnew master\n\Admin-master\Admin.Presentation\Views\_ViewImports.cshtml"
using Admin.Core.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "F:\1-MVC PROJECT\Xceed-Task aya saied mohamed\nnnew master\n\Admin-master\Admin.Presentation\Views\Employee\AllEmployee.cshtml"
using Admin.Core.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a798da7a0f05ecc8d99dcec8f6a560a0693bb53b", @"/Views/Employee/AllEmployee.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0cd9a02807a616541d036153696f789a5c0f0dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_AllEmployee : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EmployeeVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning btn-lg btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<table class=""table"">
  <thead>
    <tr>
      <th scope=""col"">Name</th>
      <th scope=""col""> National Id</th>
      <th scope=""col"">Birth of Date</th>
      <th scope=""col"">Account</th>
      <th scope=""col"">line of business</th>
       <th scope=""col""> Language </th>

       <th scope=""col"">Language Level</th>

       <th scope=""col"">update</th>
      <th scope=""col"">delete</th>
    </tr>
  </thead>
  <tbody>


");
#nullable restore
#line 23 "F:\1-MVC PROJECT\Xceed-Task aya saied mohamed\nnnew master\n\Admin-master\Admin.Presentation\Views\Employee\AllEmployee.cshtml"
       foreach(var employee in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("          <tr>\r\n      <td>");
#nullable restore
#line 26 "F:\1-MVC PROJECT\Xceed-Task aya saied mohamed\nnnew master\n\Admin-master\Admin.Presentation\Views\Employee\AllEmployee.cshtml"
     Write(employee.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td >");
#nullable restore
#line 27 "F:\1-MVC PROJECT\Xceed-Task aya saied mohamed\nnnew master\n\Admin-master\Admin.Presentation\Views\Employee\AllEmployee.cshtml"
        Write(employee.NationalId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n      <td>");
#nullable restore
#line 28 "F:\1-MVC PROJECT\Xceed-Task aya saied mohamed\nnnew master\n\Admin-master\Admin.Presentation\Views\Employee\AllEmployee.cshtml"
     Write(employee.DateOfBirth);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n      <td>");
#nullable restore
#line 30 "F:\1-MVC PROJECT\Xceed-Task aya saied mohamed\nnnew master\n\Admin-master\Admin.Presentation\Views\Employee\AllEmployee.cshtml"
     Write(employee.Account.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 31 "F:\1-MVC PROJECT\Xceed-Task aya saied mohamed\nnnew master\n\Admin-master\Admin.Presentation\Views\Employee\AllEmployee.cshtml"
     Write(employee.LineofBusiness.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 32 "F:\1-MVC PROJECT\Xceed-Task aya saied mohamed\nnnew master\n\Admin-master\Admin.Presentation\Views\Employee\AllEmployee.cshtml"
     Write(employee.Language.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                \r\n\r\n     \r\n   \r\n\r\n\r\n      <td> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a798da7a0f05ecc8d99dcec8f6a560a0693bb53b7079", async() => {
                WriteLiteral("  Edit    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "F:\1-MVC PROJECT\Xceed-Task aya saied mohamed\nnnew master\n\Admin-master\Admin.Presentation\Views\Employee\AllEmployee.cshtml"
                                                                           WriteLiteral(employee.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n      <td> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a798da7a0f05ecc8d99dcec8f6a560a0693bb53b9418", async() => {
                WriteLiteral(" Delete  ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 45 "F:\1-MVC PROJECT\Xceed-Task aya saied mohamed\nnnew master\n\Admin-master\Admin.Presentation\Views\Employee\AllEmployee.cshtml"
                                                                             WriteLiteral(employee.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n\r\n    </tr>  \r\n");
#nullable restore
#line 48 "F:\1-MVC PROJECT\Xceed-Task aya saied mohamed\nnnew master\n\Admin-master\Admin.Presentation\Views\Employee\AllEmployee.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n    \r\n  </tbody>\r\n</table>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 56 "F:\1-MVC PROJECT\Xceed-Task aya saied mohamed\nnnew master\n\Admin-master\Admin.Presentation\Views\Employee\AllEmployee.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial"); 

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n");
            }
            );
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EmployeeVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
