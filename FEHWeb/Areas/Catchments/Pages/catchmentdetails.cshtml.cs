using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text.Json;
using Newtonsoft.Json;
using Google.DataTable.Net.Wrapper;

using FEHApp.Shared;
using FEHServicesLib;
using System;
using System.Configuration;
using Microsoft.Extensions.Configuration;

namespace FEHWeb.Pages
{
    public class CatchmentDetailsModel : PageModel
    {
        public FehappGaugedcatchment Catchment { get; set; }
        public double CatchmentLat { get; set; }
        public double CatchmentLon { get; set; }
        public string jsonAmax { get; set; }

        private CatchmentdataContext db;

        public string MapsKey { get; set; }
        public IConfiguration Configuration { get; }

        public CatchmentDetailsModel(CatchmentdataContext injectedContext, IConfiguration configuration)
        {
            db = injectedContext;
            Configuration = configuration;
        }

        public void OnGet(int catchmentId)
        {
            ViewData["Copyright"] = "Jeremy Fox";
            ViewData["Acknowledgement"] = "Acknowledgement: Data from the UK National River Flow Archive";
            Catchment = db.FehappGaugedcatchment
                .Where (c => c.Catchment == catchmentId)
                .Include(c => c.FehappAmaxdata)
                .SingleOrDefault();
            jsonAmax = JsonData(Catchment);
            CoordinateConvert convertor = new CoordinateConvert();
            //multiplying by 100 to add trailing zeros and make into 6 figure grid refs
            CatchmentLat = convertor.GeoUKConvert(Convert.ToDouble(Catchment.NomNgre * 100), Convert.ToDouble(Catchment.NomNgrn * 100)).latitude;
            CatchmentLon = convertor.GeoUKConvert(Convert.ToDouble(Catchment.NomNgre * 100), Convert.ToDouble(Catchment.NomNgrn * 100)).longitude;
            MapsKey = Configuration["BingMapsKey"];
        }

        private string JsonData(FehappGaugedcatchment amaxData)
        {
            var dt = new Google.DataTable.Net.Wrapper.DataTable();
            dt.AddColumn(new Column(ColumnType.String, "Mondate", "Monitoring Date"));
            dt.AddColumn(new Column(ColumnType.Number, "Flow", "Flow"));

            foreach(var item in Catchment.FehappAmaxdata)
            {
                Row r = dt.NewRow();
                r.AddCellRange(new Cell[]
                {

                    new Cell(item.Mondate),
                    new Cell(item.Flow)

                });
                dt.AddRow(r);
            }
            return dt.GetJson();
            // return jsonAmax = JsonConvert.SerializeObject(amaxData, Formatting.Indented,
            // new JsonSerializerSettings(){
            //     ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            // });;
        }
    }
}