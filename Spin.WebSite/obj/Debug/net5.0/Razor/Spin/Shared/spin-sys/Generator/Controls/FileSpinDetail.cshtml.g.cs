#pragma checksum "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Shared\spin-sys\Generator\Controls\FileSpinDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ba60bc079e27f22322e4ca951c5fdcd5b76279b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Spin_Shared_spin_sys_Generator_Controls_FileSpinDetail), @"mvc.1.0.view", @"/Spin/Shared/spin-sys/Generator/Controls/FileSpinDetail.cshtml")]
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
#line 2 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Shared\spin-sys\Generator\Controls\FileSpinDetail.cshtml"
using Spin.Modules.Entity.Backend.Generator.Detail;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ba60bc079e27f22322e4ca951c5fdcd5b76279b", @"/Spin/Shared/spin-sys/Generator/Controls/FileSpinDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e902045ac0bdbf79334c35ab32155f142969e063", @"/Spin/_ViewImports.cshtml")]
    public class Spin_Shared_spin_sys_Generator_Controls_FileSpinDetail : Spin.Base.Extend.Page.SpinWebViewPage<FileSpinField>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-image-loading"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/loadingImage.gif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div");
            BeginWriteAttribute("id", " id=\'", 83, "\'", 111, 2);
            WriteAttributeValue("", 88, "contentImage", 88, 12, true);
#nullable restore
#line 6 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Shared\spin-sys\Generator\Controls\FileSpinDetail.cshtml"
WriteAttributeValue("", 100, Model.Id, 100, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" spin-upload-file");
            BeginWriteAttribute("ng-model", " ng-model=\"", 129, "\"", 158, 1);
#nullable restore
#line 6 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Shared\spin-sys\Generator\Controls\FileSpinDetail.cshtml"
WriteAttributeValue("", 140, Model.ModelName, 140, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\'", 159, "\'", 215, 4);
            WriteAttributeValue("", 167, "row", 167, 3, true);
            WriteAttributeValue(" ", 170, "item-image-content", 171, 19, true);
            WriteAttributeValue(" ", 189, "load-files", 190, 11, true);
#nullable restore
#line 6 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Shared\spin-sys\Generator\Controls\FileSpinDetail.cshtml"
WriteAttributeValue(" ", 200, Model.Style, 201, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("spin-accept", " spin-accept=\"", 216, "\"", 246, 1);
#nullable restore
#line 6 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Shared\spin-sys\Generator\Controls\FileSpinDetail.cshtml"
WriteAttributeValue("", 230, Model.Extension, 230, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("spin-typeload", " spin-typeload=\"", 247, "\"", 278, 1);
#nullable restore
#line 6 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Shared\spin-sys\Generator\Controls\FileSpinDetail.cshtml"
WriteAttributeValue("", 263, Model.TypeName, 263, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("spin-namefile", " spin-namefile=\"", 279, "\"", 295, 0);
            EndWriteAttribute();
            BeginWriteAttribute("spin-randomname", " spin-randomname=\"", 296, "\"", 354, 1);
#nullable restore
#line 6 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Shared\spin-sys\Generator\Controls\FileSpinDetail.cshtml"
WriteAttributeValue("", 314, Model.RandonName.ToString().ToLower(), 314, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("spin-outData", " spin-outData=\"", 355, "\"", 414, 2);
            WriteAttributeValue("", 370, "entity.", 370, 7, true);
#nullable restore
#line 6 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Shared\spin-sys\Generator\Controls\FileSpinDetail.cshtml"
WriteAttributeValue("", 377, Model.Name.FirstCharacterToLower(), 377, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" spin-multipleFile=\"false\">\n\n    <input");
            BeginWriteAttribute("id", " id=\'", 454, "\'", 480, 2);
            WriteAttributeValue("", 459, "inputImage", 459, 10, true);
#nullable restore
#line 8 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Shared\spin-sys\Generator\Controls\FileSpinDetail.cshtml"
WriteAttributeValue("", 469, Model.Id, 469, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"uploadInput\" type=\"file\" />\n\n    <div");
            BeginWriteAttribute("id", " id=\'", 526, "\'", 547, 2);
            WriteAttributeValue("", 531, "image", 531, 5, true);
#nullable restore
#line 10 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Shared\spin-sys\Generator\Controls\FileSpinDetail.cshtml"
WriteAttributeValue("", 536, Model.Id, 536, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\'content-image content-image-file\'>\n        <i");
            BeginWriteAttribute("ng-if", " ng-if=\'", 601, "\'", 783, 15);
            WriteAttributeValue("", 609, "entity.", 609, 7, true);
#nullable restore
#line 11 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Shared\spin-sys\Generator\Controls\FileSpinDetail.cshtml"
WriteAttributeValue("", 616, Model.Name.FirstCharacterToLower(), 616, 37, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 653, ".trim()", 653, 7, true);
            WriteAttributeValue(" ", 660, "==", 661, 3, true);
            WriteAttributeValue(" ", 663, "\"\"", 664, 3, true);
            WriteAttributeValue(" ", 666, "||", 667, 3, true);
            WriteAttributeValue(" ", 669, "entity.", 670, 8, true);
#nullable restore
#line 11 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Shared\spin-sys\Generator\Controls\FileSpinDetail.cshtml"
WriteAttributeValue("", 677, Model.Name.FirstCharacterToLower(), 677, 37, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 714, "==", 715, 3, true);
            WriteAttributeValue(" ", 717, "null", 718, 5, true);
            WriteAttributeValue(" ", 722, "||", 723, 3, true);
            WriteAttributeValue(" ", 725, "entity.", 726, 8, true);
#nullable restore
#line 11 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Shared\spin-sys\Generator\Controls\FileSpinDetail.cshtml"
WriteAttributeValue("", 733, Model.Name.FirstCharacterToLower(), 733, 37, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 770, "==", 771, 3, true);
            WriteAttributeValue(" ", 773, "undefined", 774, 10, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"fas fa-minus-square fa-5x\"></i>\n        <a");
            BeginWriteAttribute("ng-if", " ng-if=\'", 834, "\'", 1016, 15);
            WriteAttributeValue("", 842, "entity.", 842, 7, true);
#nullable restore
#line 12 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Shared\spin-sys\Generator\Controls\FileSpinDetail.cshtml"
WriteAttributeValue("", 849, Model.Name.FirstCharacterToLower(), 849, 37, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 886, ".trim()", 886, 7, true);
            WriteAttributeValue(" ", 893, "!=", 894, 3, true);
            WriteAttributeValue(" ", 896, "\"\"", 897, 3, true);
            WriteAttributeValue(" ", 899, "&&", 900, 3, true);
            WriteAttributeValue(" ", 902, "entity.", 903, 8, true);
#nullable restore
#line 12 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Shared\spin-sys\Generator\Controls\FileSpinDetail.cshtml"
WriteAttributeValue("", 910, Model.Name.FirstCharacterToLower(), 910, 37, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 947, "!=", 948, 3, true);
            WriteAttributeValue(" ", 950, "null", 951, 5, true);
            WriteAttributeValue(" ", 955, "&&", 956, 3, true);
            WriteAttributeValue(" ", 958, "entity.", 959, 8, true);
#nullable restore
#line 12 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Shared\spin-sys\Generator\Controls\FileSpinDetail.cshtml"
WriteAttributeValue("", 966, Model.Name.FirstCharacterToLower(), 966, 37, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1003, "!=", 1004, 3, true);
            WriteAttributeValue(" ", 1006, "undefined", 1007, 10, true);
            EndWriteAttribute();
            BeginWriteAttribute("ng-href", " ng-href=\"", 1017, "\"", 1075, 3);
            WriteAttributeValue("", 1027, "{{entity.", 1027, 9, true);
#nullable restore
#line 12 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Shared\spin-sys\Generator\Controls\FileSpinDetail.cshtml"
WriteAttributeValue("", 1036, Model.Name.FirstCharacterToLower(), 1036, 37, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1073, "}}", 1073, 2, true);
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">\n            <i");
            BeginWriteAttribute("class", " class=\"", 1108, "\"", 1137, 2);
#nullable restore
#line 13 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Shared\spin-sys\Generator\Controls\FileSpinDetail.cshtml"
WriteAttributeValue("", 1116, Model.IconLoad, 1116, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1131, "fa-5x", 1132, 6, true);
            EndWriteAttribute();
            WriteLiteral("></i>\n        </a>\n    </div>\n\n    <div");
            BeginWriteAttribute("id", " id=\'", 1177, "\'", 1200, 2);
            WriteAttributeValue("", 1182, "loading", 1182, 7, true);
#nullable restore
#line 17 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Shared\spin-sys\Generator\Controls\FileSpinDetail.cshtml"
WriteAttributeValue("", 1189, Model.Id, 1189, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\'content-image-loading\'>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4ba60bc079e27f22322e4ca951c5fdcd5b76279b14887", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        <div class=\"text-image-loading\">\n            0%\n        </div>\n    </div>\n\n    <div class=\' content-button\'>\n        <button");
            BeginWriteAttribute("id", " id=\'", 1436, "\'", 1463, 2);
            WriteAttributeValue("", 1441, "uploadImage", 1441, 11, true);
#nullable restore
#line 25 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Shared\spin-sys\Generator\Controls\FileSpinDetail.cshtml"
WriteAttributeValue("", 1452, Model.Id, 1452, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("  class=\"uploadImage\" type=\'button\'>\n            <i class=\"fas fa-plus-circle\"></i>\n            Upload Image\n        </button>\n        <button");
            BeginWriteAttribute("id", " id=\'", 1606, "\'", 1633, 2);
            WriteAttributeValue("", 1611, "deleteImage", 1611, 11, true);
#nullable restore
#line 29 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Shared\spin-sys\Generator\Controls\FileSpinDetail.cshtml"
WriteAttributeValue("", 1622, Model.Id, 1622, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("ng-if", " ng-if=\'", 1634, "\'", 1738, 12);
#nullable restore
#line 29 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Shared\spin-sys\Generator\Controls\FileSpinDetail.cshtml"
WriteAttributeValue("", 1642, Model.ModelName, 1642, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1660, ".trim()", 1660, 7, true);
            WriteAttributeValue(" ", 1667, "!=", 1668, 3, true);
            WriteAttributeValue(" ", 1670, "\"\"", 1671, 3, true);
            WriteAttributeValue(" ", 1673, "&&", 1674, 3, true);
#nullable restore
#line 29 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Shared\spin-sys\Generator\Controls\FileSpinDetail.cshtml"
WriteAttributeValue(" ", 1676, Model.ModelName, 1677, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1695, "!=", 1696, 3, true);
            WriteAttributeValue(" ", 1698, "null", 1699, 5, true);
            WriteAttributeValue(" ", 1703, "&&", 1704, 3, true);
#nullable restore
#line 29 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Shared\spin-sys\Generator\Controls\FileSpinDetail.cshtml"
WriteAttributeValue(" ", 1706, Model.ModelName, 1707, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1725, "!=", 1726, 3, true);
            WriteAttributeValue(" ", 1728, "undefined", 1729, 10, true);
            EndWriteAttribute();
            BeginWriteAttribute("ng-click", " ng-click=\"", 1739, "\"", 1782, 3);
            WriteAttributeValue("", 1750, "deleteFile(\'", 1750, 12, true);
#nullable restore
#line 29 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Shared\spin-sys\Generator\Controls\FileSpinDetail.cshtml"
WriteAttributeValue("", 1762, Model.ModelName, 1762, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1780, "\')", 1780, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\n            <i class=\'far fa-trash-alt\' aria-hidden=\'true\'></i>\n            Delete Image\n        </button>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FileSpinField> Html { get; private set; }
    }
}
#pragma warning restore 1591
