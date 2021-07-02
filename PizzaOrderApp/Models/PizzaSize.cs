using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PizzaOrderApp.Models
{
    public class PizzaSize
    {
        [Key]
        public int SizeId { get; set; }
        public string Size { get; set; }
        public float Sizeprice { get; set; }
    }
}
