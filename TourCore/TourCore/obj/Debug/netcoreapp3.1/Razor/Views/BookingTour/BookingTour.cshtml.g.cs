#pragma checksum "C:\Users\dev1\source\repos\TourCore\TourCore\TourCore\Views\BookingTour\BookingTour.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "726f4da11e82fc2cf15b92c602c4fe5cd49a656c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BookingTour_BookingTour), @"mvc.1.0.view", @"/Views/BookingTour/BookingTour.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"726f4da11e82fc2cf15b92c602c4fe5cd49a656c", @"/Views/BookingTour/BookingTour.cshtml")]
    public class Views_BookingTour_BookingTour : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TourCore.Models.ViewModels.TourViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\dev1\source\repos\TourCore\TourCore\TourCore\Views\BookingTour\BookingTour.cshtml"
 using (Html.BeginForm("BookingTour", "BookingTour", FormMethod.Post, new { @class = "row" }))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-sm-6 form-group contact-forms\">\r\n        ");
#nullable restore
#line 6 "C:\Users\dev1\source\repos\TourCore\TourCore\TourCore\Views\BookingTour\BookingTour.cshtml"
   Write(Html.TextBox("Name", "", new { @class = "form-control", @placeholder = "Name" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-sm-6 form-group contact-forms\">\r\n        ");
#nullable restore
#line 9 "C:\Users\dev1\source\repos\TourCore\TourCore\TourCore\Views\BookingTour\BookingTour.cshtml"
   Write(Html.TextBox("Email", "", new { @class = "form-control", @placeholder = "Email" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-sm-6 form-group contact-forms\">\r\n        ");
#nullable restore
#line 12 "C:\Users\dev1\source\repos\TourCore\TourCore\TourCore\Views\BookingTour\BookingTour.cshtml"
   Write(Html.TextBox("Phone", "", new { @class = "form-control", @placeholder = "Phone" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-sm-6 form-group contact-forms\">\r\n        ");
#nullable restore
#line 15 "C:\Users\dev1\source\repos\TourCore\TourCore\TourCore\Views\BookingTour\BookingTour.cshtml"
   Write(Html.TextBox("Address", "", new { @class = "form-control", @placeholder = "Address" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-sm-6 form-group contact-forms\">\r\n        ");
#nullable restore
#line 18 "C:\Users\dev1\source\repos\TourCore\TourCore\TourCore\Views\BookingTour\BookingTour.cshtml"
   Write(Html.TextBox("PeopleGo", "", new { @class = "form-control", @placeholder = "PeopleGo" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>
    <div class=""col-sm-6 form-group contact-forms"">
        <input type=""date"" name=""DOB"" class=""form-control"" placeholder=""Date"" />
    </div>
    <div class=""col-md-12 booking-button"">
        <button type=""submit"" class=""btn btn-block sent-butnn"">Book Now</button>
    </div>
");
#nullable restore
#line 26 "C:\Users\dev1\source\repos\TourCore\TourCore\TourCore\Views\BookingTour\BookingTour.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TourCore.Models.ViewModels.TourViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
