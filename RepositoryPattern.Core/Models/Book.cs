using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Core.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required,MaxLength(350)]
        public string Name { get; set; }=string.Empty;
        
        public decimal Price { get; set; }
        [MaxLength(650)]
        public string Description { get; set; } = string.Empty;

        public virtual Author? Author { get; set; }
        [ForeignKey(nameof(Author))]
        public int AuthorId { get; set; }

    }
}
