#pragma checksum "C:\Users\GLLPC\source\repos\BlogSitesi\BlogSitesi\Views\Shared\Components\CommentList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35145ea3e7f13d5ff5da265bc0e3f2a205ec0fbf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CommentList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CommentList/Default.cshtml")]
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
#line 1 "C:\Users\GLLPC\source\repos\BlogSitesi\BlogSitesi\Views\_ViewImports.cshtml"
using BlogSitesi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\GLLPC\source\repos\BlogSitesi\BlogSitesi\Views\_ViewImports.cshtml"
using BlogSitesi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35145ea3e7f13d5ff5da265bc0e3f2a205ec0fbf", @"/Views/Shared/Components/CommentList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f38976513bc2a2a55f76afac4884edad712a2208", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CommentList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BlogSitesi.Models.UserComment>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\GLLPC\source\repos\BlogSitesi\BlogSitesi\Views\Shared\Components\CommentList\Default.cshtml"
 foreach(var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 5 "C:\Users\GLLPC\source\repos\BlogSitesi\BlogSitesi\Views\Shared\Components\CommentList\Default.cshtml"
  Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>");
#nullable restore
#line 6 "C:\Users\GLLPC\source\repos\BlogSitesi\BlogSitesi\Views\Shared\Components\CommentList\Default.cshtml"
  Write(item.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 7 "C:\Users\GLLPC\source\repos\BlogSitesi\BlogSitesi\Views\Shared\Components\CommentList\Default.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BlogSitesi.Models.UserComment>> Html { get; private set; }
    }
}
#pragma warning restore 1591