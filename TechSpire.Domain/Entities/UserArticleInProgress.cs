using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSpire.Domain.Entities;
public class UserArticleInProgress
{
        public int Id { get; set; }
    public string AppUserId { get; set; }
        public int ArticleId { get; set; }
        public Article Book { get; set; }
        public ApplicataionUser AppUser { get; set; }
        public int CurrentPage { get; set; }
        public double CompletedPercentage { get; set; }
}
