﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyPhoneBookDiary.Data;
using MyPhoneBookDiary.Model;

namespace MyPhoneBookDiary.Pages.Emails
{
    public class EditModel : PageModel
    {
        private readonly MyPhoneBookDiary.Data.MyPhoneBookDiaryContext _context;

        public EditModel(MyPhoneBookDiary.Data.MyPhoneBookDiaryContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Email Email { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Email = await _context.Email
                .Include(e => e.Users).FirstOrDefaultAsync(m => m.EmailID == id);

            if (Email == null)
            {
                return NotFound();
            }
           ViewData["UserId"] = new SelectList(_context.User, "UserId", "UserId");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Email).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmailExists(Email.EmailID))
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

        private bool EmailExists(int id)
        {
            return _context.Email.Any(e => e.EmailID == id);
        }
    }
}
