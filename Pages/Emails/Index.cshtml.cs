﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyPhoneBookDiary.Data;
using MyPhoneBookDiary.Model;

namespace MyPhoneBookDiary.Pages.Emails
{
    public class IndexModel : PageModel
    {
        private readonly MyPhoneBookDiary.Data.MyPhoneBookDiaryContext _context;

        public IndexModel(MyPhoneBookDiary.Data.MyPhoneBookDiaryContext context)
        {
            _context = context;
        }

        public IList<Email> Email { get;set; }

        public async Task OnGetAsync()
        {
            Email = await _context.Email
                .Include(e => e.Users).ToListAsync();
        }
    }
}
