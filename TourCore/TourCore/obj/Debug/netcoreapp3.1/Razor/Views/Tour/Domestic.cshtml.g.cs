#pragma checksum "C:\Users\Tan\source\repos\TourCore\TourCore\TourCore\Views\Tour\Domestic.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "816e2a97c168b455f2f163c32af504ef02acb25f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tour_Domestic), @"mvc.1.0.view", @"/Views/Tour/Domestic.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"816e2a97c168b455f2f163c32af504ef02acb25f", @"/Views/Tour/Domestic.cshtml")]
    public class Views_Tour_Domestic : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TourCore.Models.ViewModels.TourViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Tan\source\repos\TourCore\TourCore\TourCore\Views\Tour\Domestic.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_LayoutTour.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container py-lg-4 py-sm-3\">\r\n    <h2 class=\"heading text-capitalize text-center\"> Khám phá các Tour du lịch của chúng tôi</h2>\r\n    <br />\r\n    ");
#nullable restore
#line 9 "C:\Users\Tan\source\repos\TourCore\TourCore\TourCore\Views\Tour\Domestic.cshtml"
Write(await Html.PartialAsync("/Views/Tour/FindTourPartial.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    <br />\r\n    <br />\r\n    <br />\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 15 "C:\Users\Tan\source\repos\TourCore\TourCore\TourCore\Views\Tour\Domestic.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-lg-3 col-sm-6 mb-5\">\r\n                <div class=\"image-tour position-relative\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 626, "\"", 683, 1);
#nullable restore
#line 19 "C:\Users\Tan\source\repos\TourCore\TourCore\TourCore\Views\Tour\Domestic.cshtml"
WriteAttributeValue("", 633, Url.Action("TourDetail","Tour",new {@id=item.Id}), 633, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 715, "\"", 770, 1);
#nullable restore
#line 20 "C:\Users\Tan\source\repos\TourCore\TourCore\TourCore\Views\Tour\Domestic.cshtml"
WriteAttributeValue("", 721, Url.Content("/images/tour_images/"+item.Picture), 721, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 771, "\"", 777, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\">\r\n                        <p><span class=\"fa fa-tags\"></span> <span>");
#nullable restore
#line 21 "C:\Users\Tan\source\repos\TourCore\TourCore\TourCore\Views\Tour\Domestic.cshtml"
                                                             Write(item.Cost?.ToString("#,##"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                    </a>\r\n                </div>\r\n                <div class=\"package-info\">\r\n                    <h6 class=\"mt-1\"><span class=\"fa fa-map-marker mr-2\"></span>");
#nullable restore
#line 25 "C:\Users\Tan\source\repos\TourCore\TourCore\TourCore\Views\Tour\Domestic.cshtml"
                                                                           Write(item.NameTour);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                    <h5 class=\"my-2\">");
#nullable restore
#line 26 "C:\Users\Tan\source\repos\TourCore\TourCore\TourCore\Views\Tour\Domestic.cshtml"
                                Write(item.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p");
            BeginWriteAttribute("class", " class=\"", 1177, "\"", 1185, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 27 "C:\Users\Tan\source\repos\TourCore\TourCore\TourCore\Views\Tour\Domestic.cshtml"
                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <ul class=\"listing mt-3\">\r\n                        <li><span class=\"fa fa-clock-o mr-2\"></span><span>");
#nullable restore
#line 29 "C:\Users\Tan\source\repos\TourCore\TourCore\TourCore\Views\Tour\Domestic.cshtml"
                                                                     Write(item.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ngày ");
#nullable restore
#line 29 "C:\Users\Tan\source\repos\TourCore\TourCore\TourCore\Views\Tour\Domestic.cshtml"
                                                                                    Write(item.Night);

#line default
#line hidden
#nullable disable
            WriteLiteral(" đêm</span></li>\r\n                    </ul>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 33 "C:\Users\Tan\source\repos\TourCore\TourCore\TourCore\Views\Tour\Domestic.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TourCore.Models.ViewModels.TourViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
