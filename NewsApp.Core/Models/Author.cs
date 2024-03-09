using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApp.Core.Models
{
    public class Author
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string UserName { get; set; }

        [Required]
        [MaxLength(50)]
        public string Email { get; set; }

        [Required]
        [MaxLength(20)]
        public string Password { get; set; } = "12345";

        [StringLength(500)]
        public string? Address { get; set; }
        public byte[] Image { get; set; }
    }
}
