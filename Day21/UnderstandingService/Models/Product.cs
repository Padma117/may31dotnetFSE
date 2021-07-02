using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UnderstandingService.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage="Product Name cannot be Empty")]
        public string Name { get; set; }

        public double Price { get; set; }
    }
}
