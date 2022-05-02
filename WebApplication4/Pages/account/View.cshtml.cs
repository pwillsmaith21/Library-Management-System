using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication4.Models;

namespace WebApplication4.Pages.account
{
    public class IndexModel : PageModel
    {
        private readonly WebApplication4.Models.LMS_ProjectContext _context;

        public IndexModel(WebApplication4.Models.LMS_ProjectContext context)
        {
            _context = context;
        }

        public IList<UserT> UserT { get;set; }

        public async Task OnGetAsync()
        {
            UserT = await _context.UserTs.ToListAsync();
        }
    }
}
