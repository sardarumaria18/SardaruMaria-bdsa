#pragma checksum "C:\Users\Maria\Desktop\Seminar 3\ProiectMaster\ProiectMaster.Web\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c3786d37d99a9864b45e01c1ef65f9e84cfc76c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "C:\Users\Maria\Desktop\Seminar 3\ProiectMaster\ProiectMaster.Web\Views\_ViewImports.cshtml"
using ProiectMaster.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Maria\Desktop\Seminar 3\ProiectMaster\ProiectMaster.Web\Views\_ViewImports.cshtml"
using ProiectMaster.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Maria\Desktop\Seminar 3\ProiectMaster\ProiectMaster.Web\Views\_ViewImports.cshtml"
using ProiectMaster.Models.DTOs.VM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Maria\Desktop\Seminar 3\ProiectMaster\ProiectMaster.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c3786d37d99a9864b45e01c1ef65f9e84cfc76c", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca0be194870830f42a069c9ea434231893299df8", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProductVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 200px; height: 150px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("No image added yet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Maria\Desktop\Seminar 3\ProiectMaster\ProiectMaster.Web\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Product";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row mb-2 mt-2 operationsButtons"">
    <div class=""col-md-12"">
        <a href=""/Product/New"" class=""btn btn-new btn-outline-new font-weight-bold mr-2"" data-toggle=""tooltip"" title=""New"" data-placement=""top"">
            <span class=""fa fa-plus-circle""></span>
        </a>

        <button class=""btn btn-outline-dark font-weight-bold mr-2"" data-toggle=""tooltip"" title=""Edit"" data-placement=""top"" onclick=""Product.onEditBtnPress()"">
            <span class=""fa fa-edit""></span>
        </button>

        <button type=""button"" class=""btn btn-delete btn-outline-delete font-weight-bold mr-2"" id=""btnDelete"" data-toggle=""tooltip"" data-placement=""top"" title=""Delete"" onclick=""Product.onDelete()"">
            <span class=""fa fa-trash""></span>
        </button>
    </div>
</div>

<br/><br/>

     <table id=""table"" class=""table table-dark"">
         <thead>
             <tr>
                 <th hidden>Product Id</th>
                 <th>Image</th>
                 <th>Product name</th>
                 <th>Pri");
            WriteLiteral("ce</th>\n                 <th>Is in stoc</th>\n             </tr>\n         </thead>\n\n         <tbody>\n\n");
#nullable restore
#line 38 "C:\Users\Maria\Desktop\Seminar 3\ProiectMaster\ProiectMaster.Web\Views\Product\Index.cshtml"
              foreach (var item in Model)
              {

#line default
#line hidden
#nullable disable
            WriteLiteral("                 <tr");
            BeginWriteAttribute("id", " id=\"", 1274, "\"", 1287, 1);
#nullable restore
#line 40 "C:\Users\Maria\Desktop\Seminar 3\ProiectMaster\ProiectMaster.Web\Views\Product\Index.cshtml"
WriteAttributeValue("", 1279, item.Id, 1279, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"trow\">\n                     <td hidden>");
#nullable restore
#line 41 "C:\Users\Maria\Desktop\Seminar 3\ProiectMaster\ProiectMaster.Web\Views\Product\Index.cshtml"
                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                     <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3c3786d37d99a9864b45e01c1ef65f9e84cfc76c6730", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1421, "~/", 1421, 2, true);
#nullable restore
#line 42 "C:\Users\Maria\Desktop\Seminar 3\ProiectMaster\ProiectMaster.Web\Views\Product\Index.cshtml"
AddHtmlAttributeValue("", 1423, item.ImagePath, 1423, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\n                     <td><strong>");
#nullable restore
#line 43 "C:\Users\Maria\Desktop\Seminar 3\ProiectMaster\ProiectMaster.Web\Views\Product\Index.cshtml"
                            Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></td>\n                     <td><strong>");
#nullable restore
#line 44 "C:\Users\Maria\Desktop\Seminar 3\ProiectMaster\ProiectMaster.Web\Views\Product\Index.cshtml"
                            Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" RON</strong></td>\n                     <td><input type=\"checkbox\"");
            BeginWriteAttribute("checked", " checked=\"", 1641, "\"", 1668, 1);
#nullable restore
#line 45 "C:\Users\Maria\Desktop\Seminar 3\ProiectMaster\ProiectMaster.Web\Views\Product\Index.cshtml"
WriteAttributeValue("", 1651, item.IsAvailable, 1651, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></td>\n                 </tr>\n");
#nullable restore
#line 47 "C:\Users\Maria\Desktop\Seminar 3\ProiectMaster\ProiectMaster.Web\Views\Product\Index.cshtml"
              }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n         </tbody>\n\n     </table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProductVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
