#pragma checksum "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Shared\spin-sys\Generator\PermissionDeny.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57c402261d7e45a8dc12c15895c3a088981c19d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Spin_Shared_spin_sys_Generator_PermissionDeny), @"mvc.1.0.view", @"/Spin/Shared/spin-sys/Generator/PermissionDeny.cshtml")]
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
#line 3 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\_ViewImports.cshtml"
using Spin.WebSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\_ViewImports.cshtml"
using Spin.Base.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\_ViewImports.cshtml"
using Spin.Helper.Extend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\_ViewImports.cshtml"
using Spin.Modules.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\_ViewImports.cshtml"
using Spin.Base.Helper.Extend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\_ViewImports.cshtml"
using Spin.Base.Helper.Company;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57c402261d7e45a8dc12c15895c3a088981c19d7", @"/Spin/Shared/spin-sys/Generator/PermissionDeny.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e902045ac0bdbf79334c35ab32155f142969e063", @"/Spin/_ViewImports.cshtml")]
    public class Spin_Shared_spin_sys_Generator_PermissionDeny : Spin.Base.Extend.Page.SpinWebViewPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Shared\spin-sys\Generator\PermissionDeny.cshtml"
  
    SpinViewPage.AddStyle("/spin-sys/dist/css/PermissionDeny.min.css");
    //SpinViewPage.AddStyle("/spin-sys/src/css/PermissionDeny.css");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"content-page\">\r\n    <div class=\"row content-page align-items-center\">\r\n        <div class=\"col-6 img-state\">\r\n            <img");
            BeginWriteAttribute("class", " class=\"", 294, "\"", 302, 0);
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 303, "\"", 348, 1);
#nullable restore
#line 11 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Shared\spin-sys\Generator\PermissionDeny.cshtml"
WriteAttributeValue("", 309, SpinViewPage.RelativePath("503.svg"), 309, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
        </div>
        <div class=""col-6"">
            <div class=""number-status"">
                301
            </div>
            <div class=""text-status"">
                SORRY
            </div>
            <div class=""title-status"">
                DENY PERMISSION
            </div>
            <div>
                ");
#nullable restore
#line 24 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Shared\spin-sys\Generator\PermissionDeny.cshtml"
           Write(ViewBag.MessageError);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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