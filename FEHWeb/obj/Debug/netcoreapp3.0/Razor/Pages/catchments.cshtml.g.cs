#pragma checksum "/Users/jem/web_development/FEHApp/FEHWeb/Pages/catchments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44f3c6be0016d058d61293c8a962ef436b82138c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_catchments), @"mvc.1.0.razor-page", @"/Pages/catchments.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44f3c6be0016d058d61293c8a962ef436b82138c", @"/Pages/catchments.cshtml")]
    public class Pages_catchments : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 13 "/Users/jem/web_development/FEHApp/FEHWeb/Pages/catchments.cshtml"
             foreach(var item in Model.Catchments)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td>");
#nullable restore
#line 16 "/Users/jem/web_development/FEHApp/FEHWeb/Pages/catchments.cshtml"
                   Write(item.StName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 17 "/Users/jem/web_development/FEHApp/FEHWeb/Pages/catchments.cshtml"
                   Write(item.Catchment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>\n                        <a");
            BeginWriteAttribute("href", " href=\"", 579, "\"", 652, 1);
#nullable restore
#line 19 "/Users/jem/web_development/FEHApp/FEHWeb/Pages/catchments.cshtml"
WriteAttributeValue("", 586, Url.Page("catchmentdetails", new {catchmentId = @item.Catchment}), 586, 66, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Link</a>\n                    </td>\n                </tr>\n");
#nullable restore
#line 22 "/Users/jem/web_development/FEHApp/FEHWeb/Pages/catchments.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n    </table>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FEHWeb.Pages.CatchmentsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FEHWeb.Pages.CatchmentsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FEHWeb.Pages.CatchmentsModel>)PageContext?.ViewData;
        public FEHWeb.Pages.CatchmentsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
