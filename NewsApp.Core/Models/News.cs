using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApp.Core.Models
{
    public class News
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [StringLength(500)]
        public string? Brief { get; set; }
        public string? Description { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
        public int CatalogId { get; set; }
        public virtual Catalog Catalog { get; set; }

    }
}
