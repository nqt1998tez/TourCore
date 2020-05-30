#pragma checksum "C:\Users\Tan\source\repos\TourCore\TourCore\TourCore\Views\Admin\InsertTour.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5db2018c37a32e3bab7730ed06ca09b5d4e3836"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_InsertTour), @"mvc.1.0.view", @"/Views/Admin/InsertTour.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5db2018c37a32e3bab7730ed06ca09b5d4e3836", @"/Views/Admin/InsertTour.cshtml")]
    public class Views_Admin_InsertTour : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TourCore.Models.Commands.InsertTourCommand>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Tan\source\repos\TourCore\TourCore\TourCore\Views\Admin\InsertTour.cshtml"
  
    ViewData["Title"] = "InsertTour";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 style=\"text-align:center;color:brown;text-transform:uppercase\">Thêm tour mới</h1>\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n");
#nullable restore
#line 12 "C:\Users\Tan\source\repos\TourCore\TourCore\TourCore\Views\Admin\InsertTour.cshtml"
         using (Html.BeginForm("InsertTour", "Admin", FormMethod.Post, new { @enctype = "multipart/form-data" }))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Code"" class=""control-label"">Mã Tour</label>
                <input name=""Code"" class=""form-control"" />
                <span asp-validation-for=""Code"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""NameTour"" class=""control-label"">Tên tour</label>
                <input name=""NameTour"" class=""form-control"" />
                <span asp-validation-for=""NameTour"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Day"" class=""control-label"">Ngày</label>
                <input name=""Day"" class=""form-control"" />
                <span asp-validation-for=""Day"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Night"" class=""control-label"">Đêm</label>
         ");
            WriteLiteral(@"       <input name=""Night"" class=""form-control"" />
                <span asp-validation-for=""Night"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Cost"" class=""control-label"">Giá Tour</label>
                <input name=""Cost"" class=""form-control"" />
                <span asp-validation-for=""Cost"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Picture"" class=""control-label"">Hình Ảnh</label>
                <input name=""Picture"" class=""form-control input-file"" type=""file"" />
                <span asp-validation-for=""Picture"" class=""text-danger"" style=""color:red"">");
#nullable restore
#line 43 "C:\Users\Tan\source\repos\TourCore\TourCore\TourCore\Views\Admin\InsertTour.cshtml"
                                                                                    Write(ViewBag.Picture);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n");
            WriteLiteral(@"            <div class=""form-group"">
                <label asp-for=""Discount"" class=""control-label"">Giảm giá</label>
                <input name=""Discount"" class=""form-control"" />
                <span asp-validation-for=""Discount"" class=""text-danger""></span>
            </div>
");
            WriteLiteral(@"            <div class=""form-group"">
                <label class=""control-label"">Trong nước hay nước ngoài</label>
                <select class=""form-control"" name=""CheckNational"">
                    <option value=""0"">Tour Trong Nước</option>
                    <option value=""1"">Tour Nước Ngoài</option>
                </select>
                <span asp-validation-for=""OutTour"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Quantity"" class=""control-label"">Số lượng</label>
                <input name=""Quantity"" class=""form-control"" />
                <span asp-validation-for=""Quantity"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Description"" class=""control-label"">Mô tả chi tiết</label>
                <input name=""Description"" class=""form-control"" />
                <span asp-validation-for=""Description"" class=""text-danger""></span>
            </div>");
            WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Thêm tour mới\" class=\"btn btn-primary\" />\r\n            </div>\r\n");
#nullable restore
#line 73 "C:\Users\Tan\source\repos\TourCore\TourCore\TourCore\Views\Admin\InsertTour.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TourCore.Models.Commands.InsertTourCommand> Html { get; private set; }
    }
}
#pragma warning restore 1591