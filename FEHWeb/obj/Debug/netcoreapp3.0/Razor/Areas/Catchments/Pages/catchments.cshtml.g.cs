#pragma checksum "C:\Users\Jem\source\repos\FEHApp\FEHWeb\Areas\Catchments\Pages\catchments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ae5f41f8a88f36ce59208ff4a3f324cf6330427"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Catchments_Pages_catchments), @"mvc.1.0.razor-page", @"/Areas/Catchments/Pages/catchments.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ae5f41f8a88f36ce59208ff4a3f324cf6330427", @"/Areas/Catchments/Pages/catchments.cshtml")]
    public class Areas_Catchments_Pages_catchments : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row"">
    <h1 class=""display-2"">Catchments</h1>
    <table class=""table table-bordered"">
        <thead class=""thead-inverse"">
            <tr>
                <th scope=""col"">Catchment Name</th>
                <th scope=""col"">Catchment Number</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 13 "C:\Users\Jem\source\repos\FEHApp\FEHWeb\Areas\Catchments\Pages\catchments.cshtml"
             foreach(var item in Model.Catchments)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 16 "C:\Users\Jem\source\repos\FEHApp\FEHWeb\Areas\Catchments\Pages\catchments.cshtml"
                   Write(item.StName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 17 "C:\Users\Jem\source\repos\FEHApp\FEHWeb\Areas\Catchments\Pages\catchments.cshtml"
                   Write(item.Catchment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <a class=\"btn btn-info\" role=\"button\"");
            BeginWriteAttribute("href", " href=\"", 646, "\"", 719, 1);
#nullable restore
#line 19 "C:\Users\Jem\source\repos\FEHApp\FEHWeb\Areas\Catchments\Pages\catchments.cshtml"
WriteAttributeValue("", 653, Url.Page("catchmentdetails", new {catchmentId = @item.Catchment}), 653, 66, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Amax data</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 22 "C:\Users\Jem\source\repos\FEHApp\FEHWeb\Areas\Catchments\Pages\catchments.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FEHWeb.Areas.Pooling.Pages.CatchmentsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FEHWeb.Areas.Pooling.Pages.CatchmentsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FEHWeb.Areas.Pooling.Pages.CatchmentsModel>)PageContext?.ViewData;
        public FEHWeb.Areas.Pooling.Pages.CatchmentsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
