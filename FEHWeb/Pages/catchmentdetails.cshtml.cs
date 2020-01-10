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
        public IEnumerable<FehappAmaxdata> AmaxData { get; set; }
        public FehappGaugedcatchment Catchment { get; set; }
        public string jsonAmax { get; set; }
        private CatchmentdataContext db;
        public int Id { get; set; }

        public CatchmentDetailsModel(CatchmentdataContext injectedContext)
        {
            db = injectedContext;
        }

        public void OnGet(int catchmentId)
        {
             Id = catchmentId;
             AmaxData = db.FehappAmaxdata
                .Where(c => c.CatchmentId == catchmentId);
            Catchment = (from c in db.FehappGaugedcatchment
                where c.Catchment == Id
                select c).FirstOrDefault();
            //jsonAmax = JsonSerializer.Serialize(AmaxData);
        }
    }
}