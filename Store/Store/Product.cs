using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

    }
}
