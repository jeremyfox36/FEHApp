#pragma checksum "/Users/jem/web_development/FEHApp/FEHWeb/Pages/catchmentdetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd480f265deef467a903a17f792bb6a87a2cfde6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_catchmentdetails), @"mvc.1.0.razor-page", @"/Pages/catchmentdetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{catchmentId=17002}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd480f265deef467a903a17f792bb6a87a2cfde6", @"/Pages/catchmentdetails.cshtml")]
    public class Pages_catchmentdetails : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"row\">\n    <h1 class=\"display-2\">Details for catchment ");
#nullable restore
#line 4 "/Users/jem/web_development/FEHApp/FEHWeb/Pages/catchmentdetails.cshtml"
                                           Write(Model.Catchment.Catchment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n</div>\n<div class=\"row\">\n    <div class=\"card\">\n        <div class=\"card-body\">\n    <h5 class=\"card-title\">");
#nullable restore
#line 9 "/Users/jem/web_development/FEHApp/FEHWeb/Pages/catchmentdetails.cshtml"
                      Write(Model.Catchment.StName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n    <p class=\"card-text\">");
#nullable restore
#line 10 "/Users/jem/web_development/FEHApp/FEHWeb/Pages/catchmentdetails.cshtml"
                    Write(Model.Catchment.CatchmentComments);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <h6>Station Comments</h6>\n    <p class=\"card-text\">");
#nullable restore
#line 12 "/Users/jem/web_development/FEHApp/FEHWeb/Pages/catchmentdetails.cshtml"
                    Write(Model.Catchment.StationComments);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <h6>QMED Comments</h6>\n    <p class=\"card-text\">");
#nullable restore
#line 14 "/Users/jem/web_development/FEHApp/FEHWeb/Pages/catchmentdetails.cshtml"
                    Write(Model.Catchment.QmedComments);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <h6>Pooling Comments</h6>\n    <p class=\"card-text\">");
#nullable restore
#line 16 "/Users/jem/web_development/FEHApp/FEHWeb/Pages/catchmentdetails.cshtml"
                    Write(Model.Catchment.PoolingComments);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n  </div>\n</div>\n</div>\n    <div id=\"chart\"></div>\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
        <script type=""text/javascript"" src=""https://www.gstatic.com/charts/loader.js""></script>
        <script>
        google.charts.load('current', { 'packages': ['corechart'] });
        google.charts.setOnLoadCallback(drawChart);

        function drawChart() {
            
            var json = ");
#nullable restore
#line 30 "/Users/jem/web_development/FEHApp/FEHWeb/Pages/catchmentdetails.cshtml"
                  Write(Html.Raw(Model.jsonAmax));

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
            var data = new google.visualization.DataTable(json);
            console.log(json);
            var options = {
                title: ""Annual maxima (amax) flow rates (cumecs)""
                ,legend: { position: ""none"" }
                ,width: '100%'
                ,height: 600
                ,hAxis: {
                    slantedTextAngle: 90
                }
            };
            var chart = new google.visualization.ColumnChart(document.getElementById('chart'));
            chart.draw(data, options);

        }
    </script>
    ");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FEHWeb.Pages.CatchmentDetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FEHWeb.Pages.CatchmentDetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FEHWeb.Pages.CatchmentDetailsModel>)PageContext?.ViewData;
        public FEHWeb.Pages.CatchmentDetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591