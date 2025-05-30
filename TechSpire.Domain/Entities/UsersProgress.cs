using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSpire.Domain.Entities;
public class UsersProgress
{
    public int Id { get; set; }
    public string UserId { get; set; }
        public DateTime StudiedAt { get; set; }

        public ApplicataionUser User { get; set; }
        public int DailyBooks { get; set; }
        public int DailyPosts { get; set; }
        public int DailyArticles { get; set; }
}
