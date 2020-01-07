using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using FEHApp.Shared;

namespace FEHWeb.Pages
{
    public class UngaugedCatchmentsModel : PageModel
    {
        public IEnumerable<FehappUngaugedcatchment> UngaugedCatchments { get; set; }
        private CatchmentdataContext db;

        public UngaugedCatchmentsModel(CatchmentdataContext injectedContext)
        {
            db = injectedContext;
        }

        public void OnGet()
        {
            ViewData["Title"] = "Feh web app - add an ungauged catchment";

            UngaugedCatchments = db.FehappUngaugedcatchment.ToList();
        }
        
        [BindProperty]
        public FehappUngaugedcatchment Ungaugedcatchment { get; set; }
        public IActionResult OnPost()
        {
            if(ModelState.IsValid)
            {
                Ungaugedcatchment.Version = "2";
                Ungaugedcatchment.UserId = 3;
                db.FehappUngaugedcatchment.Add(Ungaugedcatchment);
                db.SaveChanges();
                return RedirectToPage("/ungaugedcatchments");
            }
            return Page();
        }
    }
}