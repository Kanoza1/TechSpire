using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSpire.Application.Dto;
public class InProgressBookDto
{
    [Required]
    public int BookId { get; set; }
    [Required]
    public int CurrentPage { get; set; }
}
