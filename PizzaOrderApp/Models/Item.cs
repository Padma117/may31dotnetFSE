using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PizzaOrderApp.Models
{
    public class Item
    {
        [Key]
        public int PizzaId { get; set; }
        public string PizzaName { get; set; }
        public float Pizzaprice { get; set; }

        
    }
}
