#pragma checksum "C:\Users\dev1\source\repos\TourCore\TourCore\TourCore\Views\Shared\Components\Menu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04a37d7532a2970793e5ddb5e1aa48b736654695"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Menu_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Menu/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04a37d7532a2970793e5ddb5e1aa48b736654695", @"/Views/Shared/Components/Menu/Default.cshtml")]
    public class Views_Shared_Components_Menu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<ul class=\"menu ml-auto mt-1\">\r\n    <li class=\"active\"><a");
            BeginWriteAttribute("href", " href=\"", 57, "\"", 91, 1);
#nullable restore
#line 2 "C:\Users\dev1\source\repos\TourCore\TourCore\TourCore\Views\Shared\Components\Menu\Default.cshtml"
WriteAttributeValue("", 64, Url.Action("Index","Home"), 64, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Trang chủ</a></li>\r\n    <li class=\"active\"><a");
            BeginWriteAttribute("href", " href=\"", 138, "\"", 177, 1);
#nullable restore
#line 3 "C:\Users\dev1\source\repos\TourCore\TourCore\TourCore\Views\Shared\Components\Menu\Default.cshtml"
WriteAttributeValue("", 145, Url.Action("ShowInTour","Tour"), 145, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Tour Trong Nước</a></li>\r\n    <li class=\"active\"><a");
            BeginWriteAttribute("href", " href=\"", 230, "\"", 270, 1);
#nullable restore
#line 4 "C:\Users\dev1\source\repos\TourCore\TourCore\TourCore\Views\Shared\Components\Menu\Default.cshtml"
WriteAttributeValue("", 237, Url.Action("ShowOutTour","Tour"), 237, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Tour Nước Ngoài</a></li>\r\n    <li class=\"active\"><a");
            BeginWriteAttribute("href", " href=\"", 323, "\"", 363, 1);
#nullable restore
#line 5 "C:\Users\dev1\source\repos\TourCore\TourCore\TourCore\Views\Shared\Components\Menu\Default.cshtml"
WriteAttributeValue("", 330, Url.Action("ShowOutTour","Tour"), 330, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Đăng nhập</a></li>\r\n    <li class=\"active\"><a");
            BeginWriteAttribute("href", " href=\"", 410, "\"", 450, 1);
#nullable restore
#line 6 "C:\Users\dev1\source\repos\TourCore\TourCore\TourCore\Views\Shared\Components\Menu\Default.cshtml"
WriteAttributeValue("", 417, Url.Action("ShowOutTour","Tour"), 417, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Đăng kí</a></li>\r\n</ul>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
