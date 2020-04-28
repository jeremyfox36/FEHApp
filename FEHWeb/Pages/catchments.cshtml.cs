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
            ViewData["Copyright"] = "Jeremy Fox";
            ViewData["Acknowledgement"] = "Acknowledgement: Data from the UK National River Flow Archive";
            Catchments = db.FehappGaugedcatchment.ToList();
        }
    }
}
