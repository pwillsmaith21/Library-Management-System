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
    public class DeleteModel : PageModel
    {
        private readonly WebApplication4.Models.LMS_ProjectContext _context;

        public DeleteModel(WebApplication4.Models.LMS_ProjectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public UserT UserT { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            UserT = await _context.UserTs.FirstOrDefaultAsync(m => m.UserId == id);

            if (UserT == null)
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

            UserT = await _context.UserTs.FindAsync(id);

            if (UserT != null)
            {
                _context.UserTs.Remove(UserT);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
