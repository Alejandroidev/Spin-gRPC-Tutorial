#pragma checksum "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\CodeGenerate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc5655e6ea174ba65d841f78cc7d5968463d4db8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Spin_Module_Documentation_Site_Views_spin_sys_Home_CodeGenerate), @"mvc.1.0.view", @"/Spin/Module/Documentation/Site/Views/spin-sys/Home/CodeGenerate.cshtml")]
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
#nullable restore
#line 2 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\CodeGenerate.cshtml"
using Spin.Base.Documentation.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\CodeGenerate.cshtml"
using Spin.Base.Documentation.Language;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc5655e6ea174ba65d841f78cc7d5968463d4db8", @"/Spin/Module/Documentation/Site/Views/spin-sys/Home/CodeGenerate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e902045ac0bdbf79334c35ab32155f142969e063", @"/Spin/_ViewImports.cshtml")]
    public class Spin_Module_Documentation_Site_Views_spin_sys_Home_CodeGenerate : Spin.Base.Extend.Page.SpinWebViewPage<MemberDocument>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\CodeGenerate.cshtml"
  
    //https://highlightjs.org/usage/

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""sample-section"">
    <div class=""d-flex bd-highlight mb-3 title-sample"">
        <div class=""p-2 bd-highlight"">
            C#
        </div>
        <div class=""ml-auto bd-highlight content-copy"">
            <button id=""copyInstance"" class=""btn-copy"" type=""button"">
                <div class=""p-2 copy-code"">
                    <i class=""far fa-copy""></i>
                    ");
#nullable restore
#line 17 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\CodeGenerate.cshtml"
               Write(DocumentationLanguage.Copy);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
                <div class=""p-2 copied-code"">
                    <i class=""fas fa-check""></i>
                </div>
            </button>
        </div>
    </div>
    <div>
        <div id=""codeInstance"" class=""area-code"">");
#nullable restore
#line 26 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\CodeGenerate.cshtml"
                                            Write(Html.Raw(Model.CreateCode()));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div>\r\n            <pre><code class=\"cs\">");
#nullable restore
#line 28 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\CodeGenerate.cshtml"
                             Write(Html.Raw(Model.CreateCode()));

#line default
#line hidden
#nullable disable
            WriteLiteral("</code></pre>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MemberDocument> Html { get; private set; }
    }
}
#pragma warning restore 1591
