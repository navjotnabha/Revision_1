using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Revision_1.Models
{
    public class Brand
    {
        public Brand() { 
            new HashSet<Brand>();
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}