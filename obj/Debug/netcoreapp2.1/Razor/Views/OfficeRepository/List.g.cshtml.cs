#pragma checksum "E:\ContractingCompany\Views\OfficeRepository\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3dab77b517d7ebbaf4feee942716008a66824ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OfficeRepository_List), @"mvc.1.0.view", @"/Views/OfficeRepository/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/OfficeRepository/List.cshtml", typeof(AspNetCore.Views_OfficeRepository_List))]
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
#line 1 "E:\ContractingCompany\Views\_ViewImports.cshtml"
using ContractingCompany.Models.Office.CareerFld;

#line default
#line hidden
#line 2 "E:\ContractingCompany\Views\_ViewImports.cshtml"
using ContractingCompany.Models.Office.EmployeeFld;

#line default
#line hidden
#line 3 "E:\ContractingCompany\Views\_ViewImports.cshtml"
using ContractingCompany.FormsTagHelper.ViewModels;

#line default
#line hidden
#line 4 "E:\ContractingCompany\Views\_ViewImports.cshtml"
using ContractingCompany.Models.PublicItems.SupplierFld;

#line default
#line hidden
#line 5 "E:\ContractingCompany\Views\_ViewImports.cshtml"
using ContractingCompany.Models.PublicItems.ProductFld;

#line default
#line hidden
#line 6 "E:\ContractingCompany\Views\_ViewImports.cshtml"
using ContractingCompany.Models.PublicItems.EquipmentFld;

#line default
#line hidden
#line 7 "E:\ContractingCompany\Views\_ViewImports.cshtml"
using ContractingCompany.Models.Office.OfficeRepositoryFld;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3dab77b517d7ebbaf4feee942716008a66824ff", @"/Views/OfficeRepository/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"926f807c36caa6f144ea734161502094b9a0b724", @"/Views/_ViewImports.cshtml")]
    public class Views_OfficeRepository_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<OfficeRepository>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateAll", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 81, true);
            WriteLiteral("<h3 class=\"p-2 bg-primary text-white text-center\">قائمة  جرد المخزن العام</h3> \r\n");
            EndContext();
            BeginContext(113, 1091, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c78ddf1312014c819062999efcf1f78c", async() => {
                BeginContext(157, 410, true);
                WriteLiteral(@" 
    <div class=""container-fluid"">
        <table class=""table table-sm table-striped"">
            <thead>
                <tr>
                <th scope=""col"" hidden>ID</th>
                <th scope=""col"">Product</th>
                <th scope=""col"">Code</th>
                <th scope=""col"">Barcode</th>
                <th scope=""col"">Quantity</th>
                </tr>
            </thead>
");
                EndContext();
#line 15 "E:\ContractingCompany\Views\OfficeRepository\List.cshtml"
         foreach (var p in Model)
        {         

#line default
#line hidden
                BeginContext(622, 58, true);
                WriteLiteral("            <tr> \r\n                <td scope=\"row\" hidden>");
                EndContext();
                BeginContext(681, 12, false);
#line 18 "E:\ContractingCompany\Views\OfficeRepository\List.cshtml"
                                  Write(p.Product.ID);

#line default
#line hidden
                EndContext();
                BeginContext(693, 43, true);
                WriteLiteral("</td>                \r\n                <td>");
                EndContext();
                BeginContext(737, 14, false);
#line 19 "E:\ContractingCompany\Views\OfficeRepository\List.cshtml"
               Write(p.Product.Name);

#line default
#line hidden
                EndContext();
                BeginContext(751, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(779, 14, false);
#line 20 "E:\ContractingCompany\Views\OfficeRepository\List.cshtml"
               Write(p.Product.Code);

#line default
#line hidden
                EndContext();
                BeginContext(793, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(821, 17, false);
#line 21 "E:\ContractingCompany\Views\OfficeRepository\List.cshtml"
               Write(p.Product.Barcode);

#line default
#line hidden
                EndContext();
                BeginContext(838, 54, true);
                WriteLiteral("</td>\r\n                <td><input class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 892, "\"", 911, 1);
#line 22 "E:\ContractingCompany\Views\OfficeRepository\List.cshtml"
WriteAttributeValue("", 900, p.Quantity, 900, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(912, 39, true);
                WriteLiteral("></td>            \r\n            </tr>\r\n");
                EndContext();
#line 24 "E:\ContractingCompany\Views\OfficeRepository\List.cshtml"
        }

#line default
#line hidden
                BeginContext(962, 146, true);
                WriteLiteral("        </table>\r\n        <div class=\"text-center m-2\">\r\n            <button type=\"submit\" class=\"btn btn-primary\">Save All</button>\r\n            ");
                EndContext();
                BeginContext(1108, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c3771acd2474f6ba606f951596c1766", async() => {
                    BeginContext(1155, 6, true);
                    WriteLiteral("Cancel");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1165, 32, true);
                WriteLiteral("\r\n        </div>\r\n    </div>  \r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1204, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<OfficeRepository>> Html { get; private set; }
    }
}
#pragma warning restore 1591
