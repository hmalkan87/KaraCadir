#pragma checksum "C:\WORK\KaraCadir\KaraCadir\KaraCadir.Northwind.MvcWebUI\Views\Shared\Components\CategoryList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18e86a6aa2b29a6de0cd738516b6213dbcbd5443"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CategoryList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CategoryList/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18e86a6aa2b29a6de0cd738516b6213dbcbd5443", @"/Views/Shared/Components/CategoryList/Default.cshtml")]
    public class Views_Shared_Components_CategoryList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KaraCadir.Northwind.MvcWebUI.Models.CategoryListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"list-group\">\r\n");
#nullable restore
#line 6 "C:\WORK\KaraCadir\KaraCadir\KaraCadir.Northwind.MvcWebUI\Views\Shared\Components\CategoryList\Default.cshtml"
     foreach (var category in Model.Categories) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a href=\"#\" class=\"list-group-item\">\r\n    ");
#nullable restore
#line 8 "C:\WORK\KaraCadir\KaraCadir\KaraCadir.Northwind.MvcWebUI\Views\Shared\Components\CategoryList\Default.cshtml"
Write(category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </a>\r\n");
#nullable restore
#line 10 "C:\WORK\KaraCadir\KaraCadir\KaraCadir.Northwind.MvcWebUI\Views\Shared\Components\CategoryList\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KaraCadir.Northwind.MvcWebUI.Models.CategoryListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
