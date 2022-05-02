using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication4.Models;

namespace WebApplication4.Pages.Catalog.NewFolder
{
    public class IndexModel : PageModel
    {
        private readonly WebApplication4.Models.LMS_ProjectContext _context;

        public IndexModel(WebApplication4.Models.LMS_ProjectContext context)
        {
            _context = context;
        }

        public IList<ItemT> ItemT { get;set; }

        public async Task OnGetAsync()
        {
            ItemT = await _context.ItemTs
                .Include(i => i.AuthorNavigation)
                .Include(i => i.PublisherNavigation).ToListAsync();
        }
    }
}
