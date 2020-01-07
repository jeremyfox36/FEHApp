using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;
using FEHApp.Shared;

namespace FEHWeb.Pages
{
    public class CatchmentsModel : PageModel
    {
        public IEnumerable<FehappGaugedcatchment> Catchments { get; set; }
        private CatchmentdataContext db;

        public CatchmentsModel(CatchmentdataContext injectedContext)
        {
            db = injectedContext;
        }

        public void OnGet()
        {
            ViewData["Title"] = "Feh web app - Catchments";

            Catchments = db.FehappGaugedcatchment.ToList();
        }
    }
}
