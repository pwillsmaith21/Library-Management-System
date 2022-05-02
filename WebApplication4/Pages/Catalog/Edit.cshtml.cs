using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication4.Models;

namespace WebApplication4.Pages.Catalog
{
    public class EditModel : PageModel
    {
        private readonly WebApplication4.Models.LMS_ProjectContext _context;

        public EditModel(WebApplication4.Models.LMS_ProjectContext context)
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
           ViewData["ItemNumber"] = new SelectList(_context.ItemTs, "ItemId", "ItemId");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ItemstockT).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ItemstockTExists(ItemstockT.ItemNumber))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ItemstockTExists(int id)
        {
            return _context.ItemstockTs.Any(e => e.ItemNumber == id);
        }
    }
}
