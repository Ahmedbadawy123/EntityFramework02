using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework02.Assignment
{
    public class OrganizerProfile
    {
        public int Id { get; set; }
        public string ShortBiography { get; set; }
        public string WebsiteUrl { get; set; }
        public string LogoUrl { get; set; }

        public int OrganizerId { get; set; }
        public Organizer Organizer { get; set; }
    }
}
