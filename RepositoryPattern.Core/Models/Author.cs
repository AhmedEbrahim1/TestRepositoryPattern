using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Core.Models
{
    public class Author
    {
        public int Id { get; set; }
        [Required,MaxLength(300)]
        public string Name { get; set; } = string.Empty;
        [MaxLength(500)]
        public string Address { get; set; }=string.Empty;
        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$",ErrorMessage ="Invalid PhoneNumber Format")]
        public string PhoneNumber { get; set; } = string.Empty;

        public virtual ICollection<Book> Books { get; set; }
        = new HashSet<Book>();
    }
}
