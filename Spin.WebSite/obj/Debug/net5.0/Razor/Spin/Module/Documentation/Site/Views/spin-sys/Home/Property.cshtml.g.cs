#pragma checksum "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\Property.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af68ab0a4ff59591c65a5753f35ea26fd67cf8f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Spin_Module_Documentation_Site_Views_spin_sys_Home_Property), @"mvc.1.0.view", @"/Spin/Module/Documentation/Site/Views/spin-sys/Home/Property.cshtml")]
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
#line 2 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\Property.cshtml"
using Spin.Base.Documentation.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\Property.cshtml"
using Spin.Base.Documentation.Language;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af68ab0a4ff59591c65a5753f35ea26fd67cf8f7", @"/Spin/Module/Documentation/Site/Views/spin-sys/Home/Property.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e902045ac0bdbf79334c35ab32155f142969e063", @"/Spin/_ViewImports.cshtml")]
    public class Spin_Module_Documentation_Site_Views_spin_sys_Home_Property : Spin.Base.Extend.Page.SpinWebViewPage<ClassBaseDocument>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\Property.cshtml"
 if (Model.Members.Any(a => a.TypeMember == TypeMember.Property && !a.IsPrivate))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"content-information\">\r\n        <h2>");
#nullable restore
#line 11 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\Property.cshtml"
       Write(DocumentationLanguage.Properties);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n");
#nullable restore
#line 13 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\Property.cshtml"
         foreach (var ItemProperty in Model.Members.Where(a => a.TypeMember == TypeMember.Property))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row item-content-information\">\r\n                <div class=\"col\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 522, "\"", 579, 2);
            WriteAttributeValue("", 529, "/Documentation/Home/Index/", 529, 26, true);
#nullable restore
#line 17 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\Property.cshtml"
WriteAttributeValue("", 555, ItemProperty.FullName, 555, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        ");
#nullable restore
#line 18 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\Property.cshtml"
                   Write(ItemProperty.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 18 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\Property.cshtml"
                                         Write(ItemProperty.TypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </a>\r\n                </div>\r\n\r\n                <div class=\"col\">\r\n                    ");
#nullable restore
#line 23 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\Property.cshtml"
               Write(ItemProperty.GetTranslate(a => a.Summary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 26 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\Property.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 28 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\Property.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ClassBaseDocument> Html { get; private set; }
    }
}
#pragma warning restore 1591
