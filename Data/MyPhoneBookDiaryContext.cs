using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyPhoneBookDiary.Model;

namespace MyPhoneBookDiary.Data
{
    public class MyPhoneBookDiaryContext : DbContext
    {
        public MyPhoneBookDiaryContext (DbContextOptions<MyPhoneBookDiaryContext> options)
            : base(options)
        {
        }

        public DbSet<MyPhoneBookDiary.Model.User> User { get; set; }

        public DbSet<MyPhoneBookDiary.Model.Address> Address { get; set; }

        public DbSet<MyPhoneBookDiary.Model.Email> Email { get; set; }

        public DbSet<MyPhoneBookDiary.Model.Phone> Phone { get; set; }
    }
}
