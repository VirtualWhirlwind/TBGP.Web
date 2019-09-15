using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.DB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TBGP.Web.Pages
{
    public class IndexModel : PageModel
    {
        protected IDbMgr DB { get; set; }

        public IndexModel(IDbMgr db)
        {
            DB = db;
        }

        public void OnGet()
        {

        }
    }
}
