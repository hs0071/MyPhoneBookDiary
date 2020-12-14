using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyPhoneBookDiary.Data;
using MyPhoneBookDiary.Model;

namespace MyPhoneBookDiary.Pages.Phones
{
    public class DetailsModel : PageModel
    {
        private readonly MyPhoneBookDiary.Data.MyPhoneBookDiaryContext _context;

        public DetailsModel(MyPhoneBookDiary.Data.MyPhoneBookDiaryContext context)
        {
            _context = context;
        }

        public Phone Phone { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Phone = await _context.Phone
                .Include(p => p.Users).FirstOrDefaultAsync(m => m.PhoneId == id);

            if (Phone == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
