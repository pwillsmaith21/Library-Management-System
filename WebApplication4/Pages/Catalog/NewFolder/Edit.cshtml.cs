using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication4.Models;

namespace WebApplication4.Pages.Catalog.NewFolder
{
    public class EditModel : PageModel
    {
        private readonly WebApplication4.Models.LMS_ProjectContext _context;

        public EditModel(WebApplication4.Models.LMS_ProjectContext context)
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
           ViewData["Author"] = new SelectList(_context.AuthorTs, "AuthorId", "AuthorId");
           ViewData["Publisher"] = new SelectList(_context.PublisherTs, "PublisherId", "PublisherId");
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

            _context.Attach(ItemT).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ItemTExists(ItemT.ItemId))
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

        private bool ItemTExists(int id)
        {
            return _context.ItemTs.Any(e => e.ItemId == id);
        }
    }
}
