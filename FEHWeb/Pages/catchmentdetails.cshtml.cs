using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Web.Helpers;

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
                .FirstOrDefault();
            //jsonAmax = JsonSerializer.Serialize(AmaxData);
        }
    }
}