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
    public class DeleteModel : PageModel
    {
        private readonly WebApplication4.Models.LMS_ProjectContext _context;

        public DeleteModel(WebApplication4.Models.LMS_ProjectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ItemT ItemT { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ItemT = await _context.ItemTs
                .Include(i => i.AuthorNavigation)
                .Include(i => i.PublisherNavigation).FirstOrDefaultAsync(m => m.ItemId == id);

            if (ItemT == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ItemT = await _context.ItemTs.FindAsync(id);

            if (ItemT != null)
            {
                _context.ItemTs.Remove(ItemT);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
