#pragma checksum "D:\Cambrian Classes\Semester 2\.net\project\TableManagementSystem\TableManagementSystem\TableManagementSystem\Pages\Admin\Booking\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ab9c1e1e06837781ca6f338bac48b0ca57b785d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TableManagementSystem.Pages.Admin.Booking.Pages_Admin_Booking_Index), @"mvc.1.0.razor-page", @"/Pages/Admin/Booking/Index.cshtml")]
namespace TableManagementSystem.Pages.Admin.Booking
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
#line 1 "D:\Cambrian Classes\Semester 2\.net\project\TableManagementSystem\TableManagementSystem\TableManagementSystem\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Cambrian Classes\Semester 2\.net\project\TableManagementSystem\TableManagementSystem\TableManagementSystem\Pages\_ViewImports.cshtml"
using TableManagementSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Cambrian Classes\Semester 2\.net\project\TableManagementSystem\TableManagementSystem\TableManagementSystem\Pages\_ViewImports.cshtml"
using TableManagementSystem.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ab9c1e1e06837781ca6f338bac48b0ca57b785d", @"/Pages/Admin/Booking/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b9bcd028190362a8766077f6cf1dfcfff5a82a1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Booking_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Cambrian Classes\Semester 2\.net\project\TableManagementSystem\TableManagementSystem\TableManagementSystem\Pages\Admin\Booking\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Booking Table</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ab9c1e1e06837781ca6f338bac48b0ca57b785d5145", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "D:\Cambrian Classes\Semester 2\.net\project\TableManagementSystem\TableManagementSystem\TableManagementSystem\Pages\Admin\Booking\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.bookingTable[0].FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "D:\Cambrian Classes\Semester 2\.net\project\TableManagementSystem\TableManagementSystem\TableManagementSystem\Pages\Admin\Booking\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.bookingTable[0].LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "D:\Cambrian Classes\Semester 2\.net\project\TableManagementSystem\TableManagementSystem\TableManagementSystem\Pages\Admin\Booking\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.bookingTable[0].PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "D:\Cambrian Classes\Semester 2\.net\project\TableManagementSystem\TableManagementSystem\TableManagementSystem\Pages\Admin\Booking\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.bookingTable[0].Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "D:\Cambrian Classes\Semester 2\.net\project\TableManagementSystem\TableManagementSystem\TableManagementSystem\Pages\Admin\Booking\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.bookingTable[0].Meals));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "D:\Cambrian Classes\Semester 2\.net\project\TableManagementSystem\TableManagementSystem\TableManagementSystem\Pages\Admin\Booking\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.bookingTable[0].Table));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "D:\Cambrian Classes\Semester 2\.net\project\TableManagementSystem\TableManagementSystem\TableManagementSystem\Pages\Admin\Booking\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.bookingTable[0].FoodId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "D:\Cambrian Classes\Semester 2\.net\project\TableManagementSystem\TableManagementSystem\TableManagementSystem\Pages\Admin\Booking\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.bookingTable[0].Flower));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 41 "D:\Cambrian Classes\Semester 2\.net\project\TableManagementSystem\TableManagementSystem\TableManagementSystem\Pages\Admin\Booking\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.bookingTable[0].TablePositions));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 44 "D:\Cambrian Classes\Semester 2\.net\project\TableManagementSystem\TableManagementSystem\TableManagementSystem\Pages\Admin\Booking\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.bookingTable[0].DateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 47 "D:\Cambrian Classes\Semester 2\.net\project\TableManagementSystem\TableManagementSystem\TableManagementSystem\Pages\Admin\Booking\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.bookingTable[0].SpecialNotes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 50 "D:\Cambrian Classes\Semester 2\.net\project\TableManagementSystem\TableManagementSystem\TableManagementSystem\Pages\Admin\Booking\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.bookingTable[0].Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 56 "D:\Cambrian Classes\Semester 2\.net\project\TableManagementSystem\TableManagementSystem\TableManagementSystem\Pages\Admin\Booking\Index.cshtml"
 foreach (var item in Model.bookingTable) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 59 "D:\Cambrian Classes\Semester 2\.net\project\TableManagementSystem\TableManagementSystem\TableManagementSystem\Pages\Admin\Booking\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 62 "D:\Cambrian Classes\Semester 2\.net\project\TableManagementSystem\TableManagementSystem\TableManagementSystem\Pages\Admin\Booking\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 65 "D:\Cambrian Classes\Semester 2\.net\project\TableManagementSystem\TableManagementSystem\TableManagementSystem\Pages\Admin\Booking\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 68 "D:\Cambrian Classes\Semester 2\.net\project\TableManagementSystem\TableManagementSystem\TableManagementSystem\Pages\Admin\Booking\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 71 "D:\Cambrian Classes\Semester 2\.net\project\TableManagementSystem\TableManagementSystem\TableManagementSystem\Pages\Admin\Booking\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Meals.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 74 "D:\Cambrian Classes\Semester 2\.net\project\TableManagementSystem\TableManagementSystem\TableManagementSystem\Pages\Admin\Booking\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Table.TableName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 77 "D:\Cambrian Classes\Semester 2\.net\project\TableManagementSystem\TableManagementSystem\TableManagementSystem\Pages\Admin\Booking\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Type.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 80 "D:\Cambrian Classes\Semester 2\.net\project\TableManagementSystem\TableManagementSystem\TableManagementSystem\Pages\Admin\Booking\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Flower.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 83 "D:\Cambrian Classes\Semester 2\.net\project\TableManagementSystem\TableManagementSystem\TableManagementSystem\Pages\Admin\Booking\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TablePositions.Position));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 86 "D:\Cambrian Classes\Semester 2\.net\project\TableManagementSystem\TableManagementSystem\TableManagementSystem\Pages\Admin\Booking\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 89 "D:\Cambrian Classes\Semester 2\.net\project\TableManagementSystem\TableManagementSystem\TableManagementSystem\Pages\Admin\Booking\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SpecialNotes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 92 "D:\Cambrian Classes\Semester 2\.net\project\TableManagementSystem\TableManagementSystem\TableManagementSystem\Pages\Admin\Booking\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ab9c1e1e06837781ca6f338bac48b0ca57b785d16147", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 95 "D:\Cambrian Classes\Semester 2\.net\project\TableManagementSystem\TableManagementSystem\TableManagementSystem\Pages\Admin\Booking\Index.cshtml"
                                       WriteLiteral(item.Id);

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
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ab9c1e1e06837781ca6f338bac48b0ca57b785d18374", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 96 "D:\Cambrian Classes\Semester 2\.net\project\TableManagementSystem\TableManagementSystem\TableManagementSystem\Pages\Admin\Booking\Index.cshtml"
                                          WriteLiteral(item.Id);

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
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ab9c1e1e06837781ca6f338bac48b0ca57b785d20607", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 97 "D:\Cambrian Classes\Semester 2\.net\project\TableManagementSystem\TableManagementSystem\TableManagementSystem\Pages\Admin\Booking\Index.cshtml"
                                         WriteLiteral(item.Id);

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
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 100 "D:\Cambrian Classes\Semester 2\.net\project\TableManagementSystem\TableManagementSystem\TableManagementSystem\Pages\Admin\Booking\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TableManagementSystem.Pages.Admin.Booking.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TableManagementSystem.Pages.Admin.Booking.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TableManagementSystem.Pages.Admin.Booking.IndexModel>)PageContext?.ViewData;
        public TableManagementSystem.Pages.Admin.Booking.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591