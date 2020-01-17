using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text.Json;
using Newtonsoft.Json;

using FEHApp.Shared;

namespace FEHWeb.Pages
{
    public class CatchmentDetailsModel : PageModel
    {
        public FehappGaugedcatchment Catchment { get; set; }
        
        public string jsonAmax { get; set; }
        private CatchmentdataContext db;

        public CatchmentDetailsModel(CatchmentdataContext injectedContext)
        {
            db = injectedContext;
        }

        public void OnGet(int catchmentId)
        {
            Catchment = db.FehappGaugedcatchment
                .Where (c => c.Catchment == catchmentId)
                .Include(c => c.FehappAmaxdata)
                .SingleOrDefault();
            jsonAmax = JsonData(Catchment);
            
        }

        private string JsonData(FehappGaugedcatchment amaxData)
        {
            return jsonAmax = JsonConvert.SerializeObject(amaxData, Formatting.Indented,
            new JsonSerializerSettings(){
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            });;
        }
    }
}