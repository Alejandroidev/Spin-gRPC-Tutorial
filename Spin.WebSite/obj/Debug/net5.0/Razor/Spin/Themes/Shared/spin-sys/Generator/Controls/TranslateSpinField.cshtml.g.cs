#pragma checksum "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Themes\Shared\spin-sys\Generator\Controls\TranslateSpinField.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8368e2748c87eed9f10aac7d58c12575b5b6a86b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Spin_Themes_Shared_spin_sys_Generator_Controls_TranslateSpinField), @"mvc.1.0.view", @"/Spin/Themes/Shared/spin-sys/Generator/Controls/TranslateSpinField.cshtml")]
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
#line 2 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Themes\Shared\spin-sys\Generator\Controls\TranslateSpinField.cshtml"
using Spin.Modules.Entity.Backend.Generator.Detail;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Themes\Shared\spin-sys\Generator\Controls\TranslateSpinField.cshtml"
using Spin.Modules.API;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8368e2748c87eed9f10aac7d58c12575b5b6a86b", @"/Spin/Themes/Shared/spin-sys/Generator/Controls/TranslateSpinField.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e902045ac0bdbf79334c35ab32155f142969e063", @"/Spin/_ViewImports.cshtml")]
    public class Spin_Themes_Shared_spin_sys_Generator_Controls_TranslateSpinField : Spin.Base.Extend.Page.SpinWebViewPage<TranslateSpinFieldDetail>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Themes\Shared\spin-sys\Generator\Controls\TranslateSpinField.cshtml"
  
    var Language = LanguageBL.AllowLanguage.Where(a => a != "en");

    string Required = (Model.Requered) ? "required" : "";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"content-language\">\r\n\r\n");
#nullable restore
#line 11 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Themes\Shared\spin-sys\Generator\Controls\TranslateSpinField.cshtml"
     if (Model.Type == "textarea")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <textarea class=\"txt-language\"");
            BeginWriteAttribute("id", " id=\'", 362, "\'", 383, 2);
            WriteAttributeValue("", 367, "txt", 367, 3, true);
#nullable restore
#line 13 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Themes\Shared\spin-sys\Generator\Controls\TranslateSpinField.cshtml"
WriteAttributeValue("", 370, Model.Name, 370, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\'", 384, "\'", 407, 2);
            WriteAttributeValue("", 391, "txt", 391, 3, true);
#nullable restore
#line 13 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Themes\Shared\spin-sys\Generator\Controls\TranslateSpinField.cshtml"
WriteAttributeValue("", 394, Model.Name, 394, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("spin-name", " spin-name=\'", 408, "\'", 450, 1);
#nullable restore
#line 13 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Themes\Shared\spin-sys\Generator\Controls\TranslateSpinField.cshtml"
WriteAttributeValue("", 420, Model.Name.SplitCamelCase(), 420, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("type", " type=\'", 451, "\'", 471, 1);
#nullable restore
#line 13 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Themes\Shared\spin-sys\Generator\Controls\TranslateSpinField.cshtml"
WriteAttributeValue("", 458, Model.Type, 458, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("ng-model", " ng-model=\'", 472, "\'", 501, 1);
#nullable restore
#line 13 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Themes\Shared\spin-sys\Generator\Controls\TranslateSpinField.cshtml"
WriteAttributeValue("", 483, Model.ModelName, 483, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 13 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Themes\Shared\spin-sys\Generator\Controls\TranslateSpinField.cshtml"
                                                                                                                                                                              Write(Required);

#line default
#line hidden
#nullable disable
            WriteLiteral("></textarea>\r\n");
#nullable restore
#line 14 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Themes\Shared\spin-sys\Generator\Controls\TranslateSpinField.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <input class=\"txt-language\"");
            BeginWriteAttribute("id", " id=\'", 585, "\'", 606, 2);
            WriteAttributeValue("", 590, "txt", 590, 3, true);
#nullable restore
#line 17 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Themes\Shared\spin-sys\Generator\Controls\TranslateSpinField.cshtml"
WriteAttributeValue("", 593, Model.Name, 593, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\'", 607, "\'", 630, 2);
            WriteAttributeValue("", 614, "txt", 614, 3, true);
#nullable restore
#line 17 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Themes\Shared\spin-sys\Generator\Controls\TranslateSpinField.cshtml"
WriteAttributeValue("", 617, Model.Name, 617, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("spin-name", " spin-name=\'", 631, "\'", 673, 1);
#nullable restore
#line 17 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Themes\Shared\spin-sys\Generator\Controls\TranslateSpinField.cshtml"
WriteAttributeValue("", 643, Model.Name.SplitCamelCase(), 643, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("type", " type=\'", 674, "\'", 694, 1);
#nullable restore
#line 17 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Themes\Shared\spin-sys\Generator\Controls\TranslateSpinField.cshtml"
WriteAttributeValue("", 681, Model.Type, 681, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("ng-model", " ng-model=\'", 695, "\'", 724, 1);
#nullable restore
#line 17 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Themes\Shared\spin-sys\Generator\Controls\TranslateSpinField.cshtml"
WriteAttributeValue("", 706, Model.ModelName, 706, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 17 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Themes\Shared\spin-sys\Generator\Controls\TranslateSpinField.cshtml"
                                                                                                                                                                           Write(Required);

#line default
#line hidden
#nullable disable
            WriteLiteral(" />\r\n");
#nullable restore
#line 18 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Themes\Shared\spin-sys\Generator\Controls\TranslateSpinField.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div");
            BeginWriteAttribute("id", " id=\"", 757, "\"", 791, 2);
            WriteAttributeValue("", 762, "contentTranslate", 762, 16, true);
#nullable restore
#line 20 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Themes\Shared\spin-sys\Generator\Controls\TranslateSpinField.cshtml"
WriteAttributeValue("", 778, Model.Name, 778, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"content-language-detail\">\r\n");
#nullable restore
#line 21 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Themes\Shared\spin-sys\Generator\Controls\TranslateSpinField.cshtml"
           int IndexLanguage = 0; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Themes\Shared\spin-sys\Generator\Controls\TranslateSpinField.cshtml"
         foreach (string ItemLanguage in Language)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"item-language-detail\">\r\n                <label class=\"lbl-language-detail\"> ");
#nullable restore
#line 25 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Themes\Shared\spin-sys\Generator\Controls\TranslateSpinField.cshtml"
                                               Write(ItemLanguage.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n");
#nullable restore
#line 26 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Themes\Shared\spin-sys\Generator\Controls\TranslateSpinField.cshtml"
                 if (Model.Type == "textarea")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <textarea class=\"txt-language-detail\"");
            BeginWriteAttribute("ng-model", " ng-model=\"", 1184, "\"", 1293, 5);
#nullable restore
#line 28 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Themes\Shared\spin-sys\Generator\Controls\TranslateSpinField.cshtml"
WriteAttributeValue("", 1195, Model.VariableParentName, 1195, 27, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1222, ".spinTranslates[", 1222, 16, true);
#nullable restore
#line 28 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Themes\Shared\spin-sys\Generator\Controls\TranslateSpinField.cshtml"
WriteAttributeValue("", 1238, IndexLanguage, 1238, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1254, "].", 1254, 2, true);
#nullable restore
#line 28 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Themes\Shared\spin-sys\Generator\Controls\TranslateSpinField.cshtml"
WriteAttributeValue("", 1256, Model.Name.FirstCharacterToLower(), 1256, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></textarea>\r\n");
#nullable restore
#line 29 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Themes\Shared\spin-sys\Generator\Controls\TranslateSpinField.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <input class=\"txt-language-detail\"");
            BeginWriteAttribute("ng-model", " ng-model=\"", 1422, "\"", 1531, 5);
#nullable restore
#line 32 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Themes\Shared\spin-sys\Generator\Controls\TranslateSpinField.cshtml"
WriteAttributeValue("", 1433, Model.VariableParentName, 1433, 27, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1460, ".spinTranslates[", 1460, 16, true);
#nullable restore
#line 32 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Themes\Shared\spin-sys\Generator\Controls\TranslateSpinField.cshtml"
WriteAttributeValue("", 1476, IndexLanguage, 1476, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1492, "].", 1492, 2, true);
#nullable restore
#line 32 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Themes\Shared\spin-sys\Generator\Controls\TranslateSpinField.cshtml"
WriteAttributeValue("", 1494, Model.Name.FirstCharacterToLower(), 1494, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 33 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Themes\Shared\spin-sys\Generator\Controls\TranslateSpinField.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                {{");
#nullable restore
#line 35 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Themes\Shared\spin-sys\Generator\Controls\TranslateSpinField.cshtml"
              Write(Model.VariableParentName);

#line default
#line hidden
#nullable disable
            WriteLiteral(".spinTranslates[");
#nullable restore
#line 35 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Themes\Shared\spin-sys\Generator\Controls\TranslateSpinField.cshtml"
                                                         Write(IndexLanguage);

#line default
#line hidden
#nullable disable
            WriteLiteral("].language = \"");
#nullable restore
#line 35 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Themes\Shared\spin-sys\Generator\Controls\TranslateSpinField.cshtml"
                                                                                       Write(ItemLanguage);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"; \"\"}}\r\n\r\n            </div>\r\n");
#nullable restore
#line 38 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Themes\Shared\spin-sys\Generator\Controls\TranslateSpinField.cshtml"
            IndexLanguage++;
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TranslateSpinFieldDetail> Html { get; private set; }
    }
}
#pragma warning restore 1591
