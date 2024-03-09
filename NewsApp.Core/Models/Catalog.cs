using System.ComponentModel.DataAnnotations;

namespace NewsApp.Core.Models
{
    public class Catalog
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public string? Description { get; set; }
        public virtual ICollection<News> News { get; set; } = new List<News>();
    }
}
