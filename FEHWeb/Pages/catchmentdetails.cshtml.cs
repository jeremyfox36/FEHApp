using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

using FEHApp.Shared;

namespace FEHWeb.Pages
{
    public class CatchmentDetailsModel : PageModel
    {
        public IEnumerable<FehappAmaxdata> AmaxData { get; set; }
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
            
        }
    }
}