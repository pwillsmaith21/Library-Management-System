﻿using System;
using System.Collections.Generic;
using System.Linq;
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
       /* public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(UserT).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserTExists(UserT.UserId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
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

            }
            if (UserT.UserPassword == user.UserPassword)
            {
                Console.WriteLine("Successful login");
                return RedirectToPage("./Index");
            }
            return Page();

        }
        public void OnGet()
        {

        }
    }
}
