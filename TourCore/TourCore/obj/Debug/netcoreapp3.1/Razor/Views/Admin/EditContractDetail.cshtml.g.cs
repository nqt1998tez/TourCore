#pragma checksum "C:\Users\Tan\source\repos\TourCore\TourCore\TourCore\Views\Admin\EditContractDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc052b997a1d9ca381ad4d947772d76a630c990f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_EditContractDetail), @"mvc.1.0.view", @"/Views/Admin/EditContractDetail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc052b997a1d9ca381ad4d947772d76a630c990f", @"/Views/Admin/EditContractDetail.cshtml")]
    public class Views_Admin_EditContractDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TourCore.Models.ViewModels.ContractDetailViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Tan\source\repos\TourCore\TourCore\TourCore\Views\Admin\EditContractDetail.cshtml"
  
    ViewData["Title"] = "EditContractDetail";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    h2 {
        color: firebrick;
    }
    select{
        font-size:20px;
        padding:10px;
        color:firebrick;
    }
    input[type=submit]
    {
        font-size:20px;
        padding:10px;
        color:forestgreen;
        margin-left:10px;
    }
</style>
<h1 style=""text-align:center;color:brown"">Thanh toán Tour ");
#nullable restore
#line 23 "C:\Users\Tan\source\repos\TourCore\TourCore\TourCore\Views\Admin\EditContractDetail.cshtml"
                                                     Write(Model.NameTour);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<br />\r\n<div>\r\n    <img");
            BeginWriteAttribute("src", " src=\"", 566, "\"", 624, 1);
#nullable restore
#line 26 "C:\Users\Tan\source\repos\TourCore\TourCore\TourCore\Views\Admin\EditContractDetail.cshtml"
WriteAttributeValue("", 572, Url.Content("/images/tour_images/" + Model.Picture), 572, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:200px;height:200px;\" />\r\n</div>\r\n<br />\r\n<div>\r\n    <h2>Khách hàng : ");
#nullable restore
#line 30 "C:\Users\Tan\source\repos\TourCore\TourCore\TourCore\Views\Admin\EditContractDetail.cshtml"
                Write(Model.NameCustomer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n</div>\r\n<div>\r\n    <h2>Giá tiền : ");
#nullable restore
#line 33 "C:\Users\Tan\source\repos\TourCore\TourCore\TourCore\Views\Admin\EditContractDetail.cshtml"
              Write(Model.Cost.Value.ToString("#,##"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</h2>\r\n</div>\r\n<div>\r\n    <h2>Tình trạng thanh toán: ");
#nullable restore
#line 36 "C:\Users\Tan\source\repos\TourCore\TourCore\TourCore\Views\Admin\EditContractDetail.cshtml"
                          Write(Model.Paid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n</div>\r\n<div>\r\n    <h2>Số người đi : ");
#nullable restore
#line 39 "C:\Users\Tan\source\repos\TourCore\TourCore\TourCore\Views\Admin\EditContractDetail.cshtml"
                 Write(Model.PeopleGo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n</div>\r\n<br />\r\n<br />\r\n");
#nullable restore
#line 43 "C:\Users\Tan\source\repos\TourCore\TourCore\TourCore\Views\Admin\EditContractDetail.cshtml"
 using (Html.BeginForm("EditContractDetail", "Admin", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"hidden\" name=\"Id\"");
            BeginWriteAttribute("value", " value=\"", 1070, "\"", 1087, 1);
#nullable restore
#line 45 "C:\Users\Tan\source\repos\TourCore\TourCore\TourCore\Views\Admin\EditContractDetail.cshtml"
WriteAttributeValue("", 1078, Model.Id, 1078, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n        <select name=\"Paid\">\r\n            <option value=\"false\">Chưa thanh toán</option>\r\n            <option value=\"true\">Thanh toán rồi</option>\r\n        </select>\r\n        <input type=\"submit\" />\r\n");
#nullable restore
#line 51 "C:\Users\Tan\source\repos\TourCore\TourCore\TourCore\Views\Admin\EditContractDetail.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TourCore.Models.ViewModels.ContractDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
