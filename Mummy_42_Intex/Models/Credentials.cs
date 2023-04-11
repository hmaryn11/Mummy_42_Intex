using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mummy_42_Intex.Models
{
    public class Credentials
    {
        [Key]
        [Required]
        public int UserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
    }
}
