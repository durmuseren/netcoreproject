#pragma checksum "C:\Users\eren\source\repos\NetCoreProje2\NetCoreProje2\Views\Personelim\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "207ac2e25bfb0d5902b4aec46637b4f9be99f747"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personelim_Index), @"mvc.1.0.view", @"/Views/Personelim/Index.cshtml")]
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
#line 1 "C:\Users\eren\source\repos\NetCoreProje2\NetCoreProje2\Views\Personelim\Index.cshtml"
using NetCoreProje2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"207ac2e25bfb0d5902b4aec46637b4f9be99f747", @"/Views/Personelim/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e85bae66a19b670809a0ac08d41f37ea3c026ef", @"/Views/_ViewImports.cshtml")]
    public class Views_Personelim_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Personel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\eren\source\repos\NetCoreProje2\NetCoreProje2\Views\Personelim\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_TestLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>Ad</th>\r\n        <th>Şehir</th>\r\n        <th>Birim</th>\r\n        <th>Sil</th>\r\n        <th>Güncelle</th>\r\n        <th></th>\r\n    </tr>\r\n");
#nullable restore
#line 17 "C:\Users\eren\source\repos\NetCoreProje2\NetCoreProje2\Views\Personelim\Index.cshtml"
     foreach (var x in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\eren\source\repos\NetCoreProje2\NetCoreProje2\Views\Personelim\Index.cshtml"
           Write(x.PersonelID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td> ");
#nullable restore
#line 21 "C:\Users\eren\source\repos\NetCoreProje2\NetCoreProje2\Views\Personelim\Index.cshtml"
            Write(x.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\eren\source\repos\NetCoreProje2\NetCoreProje2\Views\Personelim\Index.cshtml"
           Write(x.Soyad);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\eren\source\repos\NetCoreProje2\NetCoreProje2\Views\Personelim\Index.cshtml"
           Write(x.Sehir);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td> ");
#nullable restore
#line 24 "C:\Users\eren\source\repos\NetCoreProje2\NetCoreProje2\Views\Personelim\Index.cshtml"
            Write(x.Birim.BirimAd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 600, "\"", 641, 2);
            WriteAttributeValue("", 607, "/depart/DepartmanSil/", 607, 21, true);
#nullable restore
#line 25 "C:\Users\eren\source\repos\NetCoreProje2\NetCoreProje2\Views\Personelim\Index.cshtml"
WriteAttributeValue("", 628, x.PersonelID, 628, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 698, "\"", 741, 2);
            WriteAttributeValue("", 705, "/depart/DepartmanGetir/", 705, 23, true);
#nullable restore
#line 26 "C:\Users\eren\source\repos\NetCoreProje2\NetCoreProje2\Views\Personelim\Index.cshtml"
WriteAttributeValue("", 728, x.PersonelID, 728, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Güncelle</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 28 "C:\Users\eren\source\repos\NetCoreProje2\NetCoreProje2\Views\Personelim\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Personelim/YeniPersonel/\" class=\"btn btn-primary\">Personel Ekle</a>");
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