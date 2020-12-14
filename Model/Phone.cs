using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyPhoneBookDiary.Model
{
    // creating separte entity for phone
    public class Phone
    {
        [Key] // PK creating
        public int PhoneId { get; set; }
        // land line  number
        public string LandLineNumber { get; set; }
        // mobile no
        public string MobileNumber { get; set; }
        // whatsapp on mobile active or not
        public bool isUsingWhatsApp { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public User Users { get; set; }
    }
}
