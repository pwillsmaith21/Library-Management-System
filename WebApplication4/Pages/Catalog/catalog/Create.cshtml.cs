using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication4.Models;

namespace WebApplication4.Pages.Catalog.NewFolder
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
        ViewData["Author"] = new SelectList(_context.AuthorTs, "AuthorId", "AuthorId");
        ViewData["Publisher"] = new SelectList(_context.PublisherTs, "PublisherId", "PublisherId");
            return Page();
        }

        [BindProperty]
        public ItemT ItemT { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ItemTs.Add(ItemT);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
