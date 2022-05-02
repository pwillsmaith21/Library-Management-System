using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication4.Models;

namespace WebApplication4.Pages.Catalog
{
    public class CreateModel : PageModel
    {
        private readonly WebApplication4.Models.LMS_ProjectContext _context;

        public CreateModel(WebApplication4.Models.LMS_ProjectContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["ItemNumber"] = new SelectList(_context.ItemTs, "ItemId", "ItemId");
            return Page();
        }

        [BindProperty]
        public ItemstockT ItemstockT { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ItemstockTs.Add(ItemstockT);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
