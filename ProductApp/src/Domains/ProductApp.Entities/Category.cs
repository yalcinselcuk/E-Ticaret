using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Entities
{
    public class Category : IEntity
    {
        public int Id { get; set; }

        [Required]
        public string CategoryName { get; set; }
        public string? Description { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
