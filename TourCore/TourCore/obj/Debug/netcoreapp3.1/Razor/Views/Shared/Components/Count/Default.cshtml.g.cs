#pragma checksum "C:\Users\dev1\source\repos\TourCore\TourCore\TourCore\Views\Shared\Components\Count\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af223310a0e16b9478e462df9fe166bff068bd9a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Count_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Count/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af223310a0e16b9478e462df9fe166bff068bd9a", @"/Views/Shared/Components/Count/Default.cshtml")]
    public class Views_Shared_Components_Count_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""list_of_members"">
    <div class=""sales"">
        <div class=""icon"">
            <i class=""dollar""></i>
        </div>
        <div class=""icon-text"">
            <h3>15896</h3>
            <p>Sales</p>
        </div>
        <div class=""clearfix""></div>
    </div>
    <div class=""new-users"">
        <div class=""icon"">
            <i class=""user1""></i>
        </div>
        <div class=""icon-text"">
            <h3>");
#nullable restore
#line 17 "C:\Users\dev1\source\repos\TourCore\TourCore\TourCore\Views\Shared\Components\Count\Default.cshtml"
           Write(ViewBag.Number);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
            <p>New Users</p>
        </div>
        <div class=""clearfix""></div>
    </div>
    <div class=""orders"">
        <div class=""icon"">
            <i class=""order""></i>
        </div>
        <div class=""icon-text"">
            <h3>");
#nullable restore
#line 27 "C:\Users\dev1\source\repos\TourCore\TourCore\TourCore\Views\Shared\Components\Count\Default.cshtml"
           Write(ViewBag.Booking);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
            <p>New Orders</p>
        </div>
        <div class=""clearfix""></div>
    </div>
    <div class=""visitors"">
        <div class=""icon"">
            <i class=""visit""></i>
        </div>
        <div class=""icon-text"">
            <h3>85k</h3>
            <p>Visits</p>
        </div>
        <div class=""clearfix""></div>
    </div>
    <div class=""clearfix""></div>
</div>
");
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
