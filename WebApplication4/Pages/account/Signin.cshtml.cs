using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication4.Models;

namespace WebApplication4.Pages.account
{
    public class EditModel : PageModel
    {
        private readonly WebApplication4.Models.LMS_ProjectContext _context;

        public EditModel(WebApplication4.Models.LMS_ProjectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public UserT UserT { get; set; }

        /*public void OnPost()
        {
            Console.WriteLine("Working");
        }*/
        public async Task<IActionResult> OnPostAsync()
        {
            Console.WriteLine(UserT.UserEmail);
            if (UserT.UserEmail == null)
            {
                return NotFound();
            }
            UserT user = await _context.UserTs.FirstOrDefaultAsync(m => m.UserEmail == UserT.UserEmail);
            if (user == null)
            {
                return NotFound();
                Console.WriteLine("null user");

            }
            user.UserPassword = UserT.UserPassword.Trim();
            if (UserT.UserPassword == user.UserPassword)
            {
                Console.WriteLine("Successful login");
                return RedirectToPage("/catalog/index");
            }
            return Page();

        }
        public void OnGet()
        {

        }
    }
}
