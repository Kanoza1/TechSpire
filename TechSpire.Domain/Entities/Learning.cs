using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSpire.Domain.Entities;
public class Learning
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Content { get; set; } // This can be a URL or a text content
    public int StageId { get; set; } // Foreign key to Stage entity
    public Stage Stage { get; set; } // Navigation property to Stage entity
}
