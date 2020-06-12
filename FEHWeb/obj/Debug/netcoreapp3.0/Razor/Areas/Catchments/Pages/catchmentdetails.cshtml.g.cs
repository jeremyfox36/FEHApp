#pragma checksum "C:\Users\Jem\source\repos\FEHApp\FEHWeb\Areas\Catchments\Pages\catchmentdetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a861fec6cbd0234435f6715120e034dcfe0081a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Catchments_Pages_catchmentdetails), @"mvc.1.0.razor-page", @"/Areas/Catchments/Pages/catchmentdetails.cshtml")]
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
#line 3 "C:\Users\Jem\source\repos\FEHApp\FEHWeb\Areas\Catchments\Pages\catchmentdetails.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{catchmentId=17002}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a861fec6cbd0234435f6715120e034dcfe0081a3", @"/Areas/Catchments/Pages/catchmentdetails.cshtml")]
    public class Areas_Catchments_Pages_catchmentdetails : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"row\">\r\n    <h1 class=\"display-2\">Details for catchment ");
#nullable restore
#line 6 "C:\Users\Jem\source\repos\FEHApp\FEHWeb\Areas\Catchments\Pages\catchmentdetails.cshtml"
                                           Write(Model.Catchment.Catchment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n            <h5 class=\"card-title\">");
#nullable restore
#line 11 "C:\Users\Jem\source\repos\FEHApp\FEHWeb\Areas\Catchments\Pages\catchmentdetails.cshtml"
                              Write(Model.Catchment.StName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <p class=\"card-text\">");
#nullable restore
#line 12 "C:\Users\Jem\source\repos\FEHApp\FEHWeb\Areas\Catchments\Pages\catchmentdetails.cshtml"
                            Write(Model.Catchment.CatchmentComments);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <h6>Station Comments</h6>\r\n            <p class=\"card-text\">");
#nullable restore
#line 14 "C:\Users\Jem\source\repos\FEHApp\FEHWeb\Areas\Catchments\Pages\catchmentdetails.cshtml"
                            Write(Model.Catchment.StationComments);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <h6>QMED Comments</h6>\r\n            <p class=\"card-text\">");
#nullable restore
#line 16 "C:\Users\Jem\source\repos\FEHApp\FEHWeb\Areas\Catchments\Pages\catchmentdetails.cshtml"
                            Write(Model.Catchment.QmedComments);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <h6>Pooling Comments</h6>\r\n            <p class=\"card-text\">");
#nullable restore
#line 18 "C:\Users\Jem\source\repos\FEHApp\FEHWeb\Areas\Catchments\Pages\catchmentdetails.cshtml"
                            Write(Model.Catchment.PoolingComments);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <h6>Catchment centroid Easting</h6>\r\n            <p class=\"card-text\">");
#nullable restore
#line 20 "C:\Users\Jem\source\repos\FEHApp\FEHWeb\Areas\Catchments\Pages\catchmentdetails.cshtml"
                            Write(Model.Catchment.CentroidNgre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <h6>Catchment centroid Northing</h6>\r\n            <p class=\"card-text\">");
#nullable restore
#line 22 "C:\Users\Jem\source\repos\FEHApp\FEHWeb\Areas\Catchments\Pages\catchmentdetails.cshtml"
                            Write(Model.Catchment.CentroidNgrn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <h6>Nominal easting</h6>\r\n            <p class=\"card-text\">");
#nullable restore
#line 24 "C:\Users\Jem\source\repos\FEHApp\FEHWeb\Areas\Catchments\Pages\catchmentdetails.cshtml"
                            Write(Model.Catchment.NomNgre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <h6>Nominal northing</h6>\r\n            <p class=\"card-text\">");
#nullable restore
#line 26 "C:\Users\Jem\source\repos\FEHApp\FEHWeb\Areas\Catchments\Pages\catchmentdetails.cshtml"
                            Write(Model.Catchment.NomNgrn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            \r\n        </div>\r\n    </div>\r\n</div>\r\n<div id=\"map\" style=\'position:relative;height:400px;\'>\r\n</div>\r\n<div id=\"chart\"></div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"" src=""https://www.gstatic.com/charts/loader.js""></script>
    <script>
        google.charts.load('current', { 'packages': ['corechart'] });
        google.charts.setOnLoadCallback(drawChart);

        function drawChart() {

            var json = ");
#nullable restore
#line 43 "C:\Users\Jem\source\repos\FEHApp\FEHWeb\Areas\Catchments\Pages\catchmentdetails.cshtml"
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
    <script type='text/javascript' src='https://www.bing.com/api/maps/mapcontrol?callback=GetMap' async defer></script>
    <script type=""text/javascript"">
        function GetMap() {
                var map = new Microsoft.Maps.Map('#map', {
                credentials: '");
#nullable restore
#line 64 "C:\Users\Jem\source\repos\FEHApp\FEHWeb\Areas\Catchments\Pages\catchmentdetails.cshtml"
                         Write(Configuration["BingMapsKey"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                center: new Microsoft.Maps.Location(");
#nullable restore
#line 65 "C:\Users\Jem\source\repos\FEHApp\FEHWeb\Areas\Catchments\Pages\catchmentdetails.cshtml"
                                               Write(Model.CatchmentLat);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 65 "C:\Users\Jem\source\repos\FEHApp\FEHWeb\Areas\Catchments\Pages\catchmentdetails.cshtml"
                                                                    Write(Model.CatchmentLon);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"),
                mapTypeId: Microsoft.Maps.MapTypeId.aerial,
                zoom: 15
                });

        var center = map.getCenter();

        //Create custom Pushpin
        var pin = new Microsoft.Maps.Pushpin(center, {
        });

        //Add the pushpin to the map
        map.entities.push(pin);
        }
    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IConfiguration Configuration { get; private set; }
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