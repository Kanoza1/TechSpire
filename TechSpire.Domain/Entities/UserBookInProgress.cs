using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSpire.Domain.Entities;
public class UserBookInProgress
{
        public string AppUserId { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public ApplicataionUser AppUser { get; set; }
        public int CurrentPage { get; set; }
        public double CompletedPercentage { get; set; }
}
