#pragma checksum "C:\Users\Jayden\Source\Repos\Schafsnj\GVSU-CIS350-APPS\APPS_WEB_APP\APPS-Web_APP\Views\Manager\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5794f4a34aaf021ea419921c3e02de865ee37d07"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manager_Delete), @"mvc.1.0.view", @"/Views/Manager/Delete.cshtml")]
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
#line 1 "C:\Users\Jayden\Source\Repos\Schafsnj\GVSU-CIS350-APPS\APPS_WEB_APP\APPS-Web_APP\Views\_ViewImports.cshtml"
using APPS_Web_APP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jayden\Source\Repos\Schafsnj\GVSU-CIS350-APPS\APPS_WEB_APP\APPS-Web_APP\Views\_ViewImports.cshtml"
using APPS_Web_APP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5794f4a34aaf021ea419921c3e02de865ee37d07", @"/Views/Manager/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d7c6903fa2267db31cbc265e29440ab851fbed3", @"/Views/_ViewImports.cshtml")]
    public class Views_Manager_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<APPS_Web_APP.Models.User>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5794f4a34aaf021ea419921c3e02de865ee37d073508", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 11 "C:\Users\Jayden\Source\Repos\Schafsnj\GVSU-CIS350-APPS\APPS_WEB_APP\APPS-Web_APP\Views\Manager\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "C:\Users\Jayden\Source\Repos\Schafsnj\GVSU-CIS350-APPS\APPS_WEB_APP\APPS-Web_APP\Views\Manager\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\Jayden\Source\Repos\Schafsnj\GVSU-CIS350-APPS\APPS_WEB_APP\APPS-Web_APP\Views\Manager\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\Jayden\Source\Repos\Schafsnj\GVSU-CIS350-APPS\APPS_WEB_APP\APPS-Web_APP\Views\Manager\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\Jayden\Source\Repos\Schafsnj\GVSU-CIS350-APPS\APPS_WEB_APP\APPS-Web_APP\Views\Manager\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 30 "C:\Users\Jayden\Source\Repos\Schafsnj\GVSU-CIS350-APPS\APPS_WEB_APP\APPS-Web_APP\Views\Manager\Delete.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 34 "C:\Users\Jayden\Source\Repos\Schafsnj\GVSU-CIS350-APPS\APPS_WEB_APP\APPS-Web_APP\Views\Manager\Delete.cshtml"
           Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\Jayden\Source\Repos\Schafsnj\GVSU-CIS350-APPS\APPS_WEB_APP\APPS-Web_APP\Views\Manager\Delete.cshtml"
           Write(Html.DisplayFor(modelItem => item.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\Jayden\Source\Repos\Schafsnj\GVSU-CIS350-APPS\APPS_WEB_APP\APPS-Web_APP\Views\Manager\Delete.cshtml"
           Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\Jayden\Source\Repos\Schafsnj\GVSU-CIS350-APPS\APPS_WEB_APP\APPS-Web_APP\Views\Manager\Delete.cshtml"
           Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\Jayden\Source\Repos\Schafsnj\GVSU-CIS350-APPS\APPS_WEB_APP\APPS-Web_APP\Views\Manager\Delete.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n \r\n            <td>\r\n                ");
#nullable restore
#line 50 "C:\Users\Jayden\Source\Repos\Schafsnj\GVSU-CIS350-APPS\APPS_WEB_APP\APPS-Web_APP\Views\Manager\Delete.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 51 "C:\Users\Jayden\Source\Repos\Schafsnj\GVSU-CIS350-APPS\APPS_WEB_APP\APPS-Web_APP\Views\Manager\Delete.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 52 "C:\Users\Jayden\Source\Repos\Schafsnj\GVSU-CIS350-APPS\APPS_WEB_APP\APPS-Web_APP\Views\Manager\Delete.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 55 "C:\Users\Jayden\Source\Repos\Schafsnj\GVSU-CIS350-APPS\APPS_WEB_APP\APPS-Web_APP\Views\Manager\Delete.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<APPS_Web_APP.Models.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
