#pragma checksum "C:\Users\eren\source\repos\NetCoreProje2\NetCoreProje2\Views\Default\BirimDetay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82ca9a190ea3697e66f2bf17eea2228b4ea1ccea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Default_BirimDetay), @"mvc.1.0.view", @"/Views/Default/BirimDetay.cshtml")]
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
#nullable restore
#line 1 "C:\Users\eren\source\repos\NetCoreProje2\NetCoreProje2\Views\_ViewImports.cshtml"
using NetCoreProje2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\eren\source\repos\NetCoreProje2\NetCoreProje2\Views\Default\BirimDetay.cshtml"
using NetCoreProje2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82ca9a190ea3697e66f2bf17eea2228b4ea1ccea", @"/Views/Default/BirimDetay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e85bae66a19b670809a0ac08d41f37ea3c026ef", @"/Views/_ViewImports.cshtml")]
    public class Views_Default_BirimDetay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Personel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\eren\source\repos\NetCoreProje2\NetCoreProje2\Views\Default\BirimDetay.cshtml"
  
    ViewData["Title"] = "BirimDetay";
    Layout = "~/Views/Shared/_TestLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<br/>\r\n<h2>Birim Detay Sayfası</h2>\r\n<br/>\r\n<h3>\r\n\r\n    ");
#nullable restore
#line 12 "C:\Users\eren\source\repos\NetCoreProje2\NetCoreProje2\Views\Default\BirimDetay.cshtml"
Write(ViewBag.brm);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</h3>\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>Ad</th>\r\n        <th>Soyad</th>\r\n        <th>Şehir</th>\r\n        \r\n    </tr>\r\n");
#nullable restore
#line 22 "C:\Users\eren\source\repos\NetCoreProje2\NetCoreProje2\Views\Default\BirimDetay.cshtml"
     foreach (var x in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\eren\source\repos\NetCoreProje2\NetCoreProje2\Views\Default\BirimDetay.cshtml"
           Write(x.PersonelID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td> ");
#nullable restore
#line 26 "C:\Users\eren\source\repos\NetCoreProje2\NetCoreProje2\Views\Default\BirimDetay.cshtml"
            Write(x.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\eren\source\repos\NetCoreProje2\NetCoreProje2\Views\Default\BirimDetay.cshtml"
           Write(x.Soyad);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\eren\source\repos\NetCoreProje2\NetCoreProje2\Views\Default\BirimDetay.cshtml"
           Write(x.Sehir);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n           \r\n        </tr>\r\n");
#nullable restore
#line 31 "C:\Users\eren\source\repos\NetCoreProje2\NetCoreProje2\Views\Default\BirimDetay.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Personel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
