#pragma checksum "D:\Projects\Inspecco_UI\Inspecco_UI\Inspecco_UI\Views\Company\CompanyList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9098547f16bfc9d18206bf9d448e09c7d57a7e67"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Company_CompanyList), @"mvc.1.0.view", @"/Views/Company/CompanyList.cshtml")]
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
#line 1 "D:\Projects\Inspecco_UI\Inspecco_UI\Inspecco_UI\Views\_ViewImports.cshtml"
using Inspecco_UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\Inspecco_UI\Inspecco_UI\Inspecco_UI\Views\_ViewImports.cshtml"
using Inspecco_UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9098547f16bfc9d18206bf9d448e09c7d57a7e67", @"/Views/Company/CompanyList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae28f089e6e15d22e74f4d60d75ef01d9cfba5f5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Company_CompanyList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Inspecco_UI.Models.Company>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-left: -1em; margin-bottom: 1em; width: 5em;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Company/CompanyCreate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Projects\Inspecco_UI\Inspecco_UI\Inspecco_UI\Views\Company\CompanyList.cshtml"
  
    ViewData["Title"] = "CompanyList";
    Layout = "~/Views/Shared/_Layout.cshtml";
    var Permission = ViewData["PermissionList"] as SeesionModel;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"col-12 col-sm-6 col-md-4 col-lg-4 col-xl-4\">\r\n");
#nullable restore
#line 9 "D:\Projects\Inspecco_UI\Inspecco_UI\Inspecco_UI\Views\Company\CompanyList.cshtml"
     if (Permission.Role.Permission.FirstOrDefault(a => a.PermissionName.Trim() == "Create") != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9098547f16bfc9d18206bf9d448e09c7d57a7e674984", async() => {
                WriteLiteral("Ekle");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 12 "D:\Projects\Inspecco_UI\Inspecco_UI\Inspecco_UI\Views\Company\CompanyList.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div class=\"row\" id=\"table-responsive\">\r\n    <div class=\"col-12\">\r\n        <div class=\"card\">\r\n            <div class=\"table-responsive\">\r\n                <table class=\"table mb-0\">\r\n                    <thead>\r\n                        <tr>\r\n");
#nullable restore
#line 21 "D:\Projects\Inspecco_UI\Inspecco_UI\Inspecco_UI\Views\Company\CompanyList.cshtml"
                             if (Permission.Role.Permission.FirstOrDefault(a => a.PermissionName == "Update") != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <th scope=\"col\" class=\"t col-xl-1\">D??zenle</th>\r\n");
#nullable restore
#line 24 "D:\Projects\Inspecco_UI\Inspecco_UI\Inspecco_UI\Views\Company\CompanyList.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\Projects\Inspecco_UI\Inspecco_UI\Inspecco_UI\Views\Company\CompanyList.cshtml"
                             if (Permission.Role.Permission.FirstOrDefault(a => a.PermissionName == "Delete") != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <th scope=\"col\" class=\"t col-xl-1\">Sil</th>\r\n");
#nullable restore
#line 28 "D:\Projects\Inspecco_UI\Inspecco_UI\Inspecco_UI\Views\Company\CompanyList.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "D:\Projects\Inspecco_UI\Inspecco_UI\Inspecco_UI\Views\Company\CompanyList.cshtml"
                             if (Permission.Role.Permission.FirstOrDefault(a => a.PermissionName == "Read") != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <th scope=\"col\" class=\" col-xl-2\">Firma Ad??</th>\r\n                                <th scope=\"col\" class=\" col-xl-4\">A????klama</th>\r\n");
#nullable restore
#line 33 "D:\Projects\Inspecco_UI\Inspecco_UI\Inspecco_UI\Views\Company\CompanyList.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n\r\n");
#nullable restore
#line 38 "D:\Projects\Inspecco_UI\Inspecco_UI\Inspecco_UI\Views\Company\CompanyList.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n\r\n");
#nullable restore
#line 42 "D:\Projects\Inspecco_UI\Inspecco_UI\Inspecco_UI\Views\Company\CompanyList.cshtml"
                                 if (Permission.Role.Permission.FirstOrDefault(a => a.PermissionName == "Update") != null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td class=\"col-xl-1\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 2097, "\"", 2140, 2);
            WriteAttributeValue("", 2104, "/Company/CompanyEdit/", 2104, 21, true);
#nullable restore
#line 45 "D:\Projects\Inspecco_UI\Inspecco_UI\Inspecco_UI\Views\Company\CompanyList.cshtml"
WriteAttributeValue("", 2125, item.CompanyId, 2125, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\" btn btn-outline-success btn-sm \"><i data-feather=\'edit\'></i>D??zenle </a>\r\n                                    </td>\r\n");
#nullable restore
#line 47 "D:\Projects\Inspecco_UI\Inspecco_UI\Inspecco_UI\Views\Company\CompanyList.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "D:\Projects\Inspecco_UI\Inspecco_UI\Inspecco_UI\Views\Company\CompanyList.cshtml"
                                 if (Permission.Role.Permission.FirstOrDefault(a => a.PermissionName == "Delete") != null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td class=\"col-xl-1\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 2562, "\"", 2607, 2);
            WriteAttributeValue("", 2569, "/Company/CompanyDelete/", 2569, 23, true);
#nullable restore
#line 51 "D:\Projects\Inspecco_UI\Inspecco_UI\Inspecco_UI\Views\Company\CompanyList.cshtml"
WriteAttributeValue("", 2592, item.CompanyId, 2592, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-outline-danger \"><i data-feather=\'trash-2\'></i> Sil</a>\r\n                                    </td>\r\n");
#nullable restore
#line 53 "D:\Projects\Inspecco_UI\Inspecco_UI\Inspecco_UI\Views\Company\CompanyList.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "D:\Projects\Inspecco_UI\Inspecco_UI\Inspecco_UI\Views\Company\CompanyList.cshtml"
                                 if (Permission.Role.Permission.FirstOrDefault(a => a.PermissionName == "Read") != null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td class=\"col-xl-2\">");
#nullable restore
#line 56 "D:\Projects\Inspecco_UI\Inspecco_UI\Inspecco_UI\Views\Company\CompanyList.cshtml"
                                                    Write(item.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td colspan=\"4\">");
#nullable restore
#line 57 "D:\Projects\Inspecco_UI\Inspecco_UI\Inspecco_UI\Views\Company\CompanyList.cshtml"
                                               Write(Html.Raw(item.CompanyDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 58 "D:\Projects\Inspecco_UI\Inspecco_UI\Inspecco_UI\Views\Company\CompanyList.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tr>\r\n");
#nullable restore
#line 60 "D:\Projects\Inspecco_UI\Inspecco_UI\Inspecco_UI\Views\Company\CompanyList.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Inspecco_UI.Models.Company>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
