﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyPhoneBookDiary.Data;
using MyPhoneBookDiary.Model;

namespace MyPhoneBookDiary.Pages.Addressess
{
    public class DetailsModel : PageModel
    {
        private readonly MyPhoneBookDiary.Data.MyPhoneBookDiaryContext _context;

        public DetailsModel(MyPhoneBookDiary.Data.MyPhoneBookDiaryContext context)
        {
            _context = context;
        }

        public Address Address { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Address = await _context.Address
                .Include(a => a.Users).FirstOrDefaultAsync(m => m.AddrId == id);

            if (Address == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
