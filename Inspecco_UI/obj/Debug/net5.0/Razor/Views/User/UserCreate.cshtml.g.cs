#pragma checksum "D:\Projects\Inspecco_UI\Inspecco_UI\Inspecco_UI\Views\User\UserCreate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99b878a401d3d27e6ee5cb54cb48d3775a8cf6fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_UserCreate), @"mvc.1.0.view", @"/Views/User/UserCreate.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99b878a401d3d27e6ee5cb54cb48d3775a8cf6fe", @"/Views/User/UserCreate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae28f089e6e15d22e74f4d60d75ef01d9cfba5f5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_UserCreate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Inspecco_UI.Models.Users>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form form-vertical"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserCreate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Projects\Inspecco_UI\Inspecco_UI\Inspecco_UI\Views\User\UserCreate.cshtml"
  
    ViewData["Title"] = "UserCreate";
    Layout = "~/Views/Shared/_Layout.cshtml";
  

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script src=""https://cdnjs.cloudflare.com/ajax/libs/bootstrap-multiselect/0.9.13/js/bootstrap-multiselect.min.js""></script>
<script src=""https://cdn.ckeditor.com/4.8.0/full-all/ckeditor.js""></script>
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/bootstrap-multiselect/0.9.13/css/bootstrap-multiselect.css"" />

");
#nullable restore
#line 10 "D:\Projects\Inspecco_UI\Inspecco_UI\Inspecco_UI\Views\User\UserCreate.cshtml"
 if (Model == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <section id=""basic-vertical-layouts"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""card"">
                    <div class=""card-header"">
                        <h4 class=""card-title"">Yeni Kayıt Ekle</h4>
                    </div>
                    <div class=""card-body"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99b878a401d3d27e6ee5cb54cb48d3775a8cf6fe6210", async() => {
                WriteLiteral(@"
                            <div class=""row"">
                                        <div class=""col-12"">
                                    <div class=""mb-1"">
                                        <label class=""form-label"" for=""first-name-vertical"">Adı Soyadı</label>
                                        <input type=""text"" autocomplete=""off"" id=""first-name-vertical"" class=""form-control"" name=""NameSurname""");
                BeginWriteAttribute("value", " value=\"", 1385, "\"", 1393, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                                    </div>
                                </div>
                                <div class=""col-12"">
                                    <div class=""mb-1"">
                                        <label class=""form-label"" for=""first-name-vertical"">Kullanıcı Adı</label>
                                        <input type=""text"" autocomplete=""off"" id=""first-name-vertical"" class=""form-control"" name=""UserName""");
                BeginWriteAttribute("value", " value=\"", 1847, "\"", 1855, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                                    </div>
                                </div>
                                              <div class=""col-4"">
                                <div class=""mb-1"">
                                    <label class=""form-label"" for=""first-name-vertical""><h6>Rol Adı</h6></label><br />

                                    <select name=""RolId"" style=""height:39px;width:318%;font-size: 22px;"" class=""form-select form-select-lg"" id=""selectLarge"">
");
#nullable restore
#line 39 "D:\Projects\Inspecco_UI\Inspecco_UI\Inspecco_UI\Views\User\UserCreate.cshtml"
                                         foreach (var RolItem in ViewBag.Rol)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99b878a401d3d27e6ee5cb54cb48d3775a8cf6fe8551", async() => {
#nullable restore
#line 41 "D:\Projects\Inspecco_UI\Inspecco_UI\Inspecco_UI\Views\User\UserCreate.cshtml"
                                                                      Write(RolItem.RolName);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 41 "D:\Projects\Inspecco_UI\Inspecco_UI\Inspecco_UI\Views\User\UserCreate.cshtml"
                                               WriteLiteral(RolItem.RolId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 42 "D:\Projects\Inspecco_UI\Inspecco_UI\Inspecco_UI\Views\User\UserCreate.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    </select>
                                </div>
                            </div>
                                    <div class=""col-12"">
                                    <div class=""mb-1"">
                                        <label class=""form-label"" for=""first-name-vertical"">Tel No</label>
                                        <input autocomplete=""off"" id=""name-vertical"" class=""form-control"" name=""Contact""");
                BeginWriteAttribute("value", " value=\"", 3077, "\"", 3085, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                                    </div>
                                </div>
                                <div class=""col-12"">
                                    <div class=""mb-1"">
                                        <label class=""form-label"" for=""first-name-vertical"">Şifre</label>
                                        <input autocomplete=""off"" id=""name-vertical"" class=""form-control"" name=""Password""");
                BeginWriteAttribute("value", " value=\"", 3513, "\"", 3521, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                                    </div>
                                </div>
                                <div class=""col-12"">
                                    <button type=""submit"" class=""btn btn-primary me-1"">Kaydet</button>
                                </div>
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n");
#nullable restore
#line 68 "D:\Projects\Inspecco_UI\Inspecco_UI\Inspecco_UI\Views\User\UserCreate.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Inspecco_UI.Models.Users> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591