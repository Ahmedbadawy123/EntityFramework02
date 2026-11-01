using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework02.Assignment
{
    public class Badge
    {
        public int Id { get; set; }
        public string UniqueNumber { get; set; }
        public DateTime IssuedDate { get; set; }
        public string Tier { get; set; } 

        public int AttendeeId { get; set; }
        public Attendee Attendee { get; set; }
    }
}
