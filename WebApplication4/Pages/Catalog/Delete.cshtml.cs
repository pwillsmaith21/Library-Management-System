using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication4.Models;

namespace WebApplication4.Pages.Catalog
{
    public class DeleteModel : PageModel
    {
        private readonly WebApplication4.Models.LMS_ProjectContext _context;

        public DeleteModel(WebApplication4.Models.LMS_ProjectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ItemstockT ItemstockT { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ItemstockT = await _context.ItemstockTs
                .Include(i => i.ItemNumberNavigation).FirstOrDefaultAsync(m => m.ItemNumber == id);

            if (ItemstockT == null)
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

            ItemstockT = await _context.ItemstockTs.FindAsync(id);

            if (ItemstockT != null)
            {
                _context.ItemstockTs.Remove(ItemstockT);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
