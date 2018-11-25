#pragma checksum "H:\ContractingCompany\Views\OfficeRepository\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04932904bf789c7648d28183b9a43b1e1d3d8a9d"
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
#line 1 "H:\ContractingCompany\Views\_ViewImports.cshtml"
using ContractingCompany.Models.Office.CareerFld;

#line default
#line hidden
#line 2 "H:\ContractingCompany\Views\_ViewImports.cshtml"
using ContractingCompany.Models.Office.EmployeeFld;

#line default
#line hidden
#line 3 "H:\ContractingCompany\Views\_ViewImports.cshtml"
using ContractingCompany.FormsTagHelper.ViewModels;

#line default
#line hidden
#line 4 "H:\ContractingCompany\Views\_ViewImports.cshtml"
using ContractingCompany.Models.PublicItems.SupplierFld;

#line default
#line hidden
#line 5 "H:\ContractingCompany\Views\_ViewImports.cshtml"
using ContractingCompany.Models.PublicItems.ProductFld;

#line default
#line hidden
#line 6 "H:\ContractingCompany\Views\_ViewImports.cshtml"
using ContractingCompany.Models.PublicItems.EquipmentFld;

#line default
#line hidden
#line 7 "H:\ContractingCompany\Views\_ViewImports.cshtml"
using ContractingCompany.Models.Office.OfficeRepositoryFld;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04932904bf789c7648d28183b9a43b1e1d3d8a9d", @"/Views/OfficeRepository/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"926f807c36caa6f144ea734161502094b9a0b724", @"/Views/_ViewImports.cshtml")]
    public class Views_OfficeRepository_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IQueryable<OfficeRepository>>
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
            BeginContext(37, 81, true);
            WriteLiteral("<h3 class=\"p-2 bg-primary text-white text-center\">قائمة  جرد المخزن العام</h3> \r\n");
            EndContext();
            BeginContext(118, 1028, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd1b29a318b64ee08898356269e538f1", async() => {
                BeginContext(162, 352, true);
                WriteLiteral(@" 
    <div class=""container-fluid"">
        <table class=""table"">
            <thead>
                <tr>
                <th scope=""col"" hidden>ID</th>
                <th scope=""col"">Product</th>
                <th scope=""col"">Code</th>
                <th scope=""col"">Barcode</th>
          
                </tr>
            </thead>
");
                EndContext();
#line 15 "H:\ContractingCompany\Views\OfficeRepository\List.cshtml"
         foreach (var p in ViewBag.Products)
        {

#line default
#line hidden
                BeginContext(571, 57, true);
                WriteLiteral("            <tr>\r\n                <td scope=\"row\" hidden>");
                EndContext();
                BeginContext(629, 4, false);
#line 18 "H:\ContractingCompany\Views\OfficeRepository\List.cshtml"
                                  Write(p.ID);

#line default
#line hidden
                EndContext();
                BeginContext(633, 42, true);
                WriteLiteral("</td>                \r\n                <td");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 675, "\"", 689, 1);
#line 19 "H:\ContractingCompany\Views\OfficeRepository\List.cshtml"
WriteAttributeValue("", 682, p.Name, 682, 7, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 690, "\"", 705, 1);
#line 19 "H:\ContractingCompany\Views\OfficeRepository\List.cshtml"
WriteAttributeValue("", 698, p.Name, 698, 7, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(706, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(708, 6, false);
#line 19 "H:\ContractingCompany\Views\OfficeRepository\List.cshtml"
                                              Write(p.Name);

#line default
#line hidden
                EndContext();
                BeginContext(714, 26, true);
                WriteLiteral("</td>\r\n                <td");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 740, "\"", 754, 1);
#line 20 "H:\ContractingCompany\Views\OfficeRepository\List.cshtml"
WriteAttributeValue("", 747, p.Code, 747, 7, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 755, "\"", 770, 1);
#line 20 "H:\ContractingCompany\Views\OfficeRepository\List.cshtml"
WriteAttributeValue("", 763, p.Code, 763, 7, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(771, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(773, 6, false);
#line 20 "H:\ContractingCompany\Views\OfficeRepository\List.cshtml"
                                              Write(p.Code);

#line default
#line hidden
                EndContext();
                BeginContext(779, 26, true);
                WriteLiteral("</td>\r\n                <td");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 805, "\"", 822, 1);
#line 21 "H:\ContractingCompany\Views\OfficeRepository\List.cshtml"
WriteAttributeValue("", 812, p.Barcode, 812, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 823, "\"", 841, 1);
#line 21 "H:\ContractingCompany\Views\OfficeRepository\List.cshtml"
WriteAttributeValue("", 831, p.Barcode, 831, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(842, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(844, 9, false);
#line 21 "H:\ContractingCompany\Views\OfficeRepository\List.cshtml"
                                                    Write(p.Barcode);

#line default
#line hidden
                EndContext();
                BeginContext(853, 40, true);
                WriteLiteral("</td>\r\n            \r\n            </tr>\r\n");
                EndContext();
#line 24 "H:\ContractingCompany\Views\OfficeRepository\List.cshtml"
        }

#line default
#line hidden
                BeginContext(904, 146, true);
                WriteLiteral("        </table>\r\n        <div class=\"text-center m-2\">\r\n            <button type=\"submit\" class=\"btn btn-primary\">Save All</button>\r\n            ");
                EndContext();
                BeginContext(1050, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c35286e992e44eec8883613018606645", async() => {
                    BeginContext(1097, 6, true);
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
                BeginContext(1107, 32, true);
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
            BeginContext(1146, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IQueryable<OfficeRepository>> Html { get; private set; }
    }
}
#pragma warning restore 1591
