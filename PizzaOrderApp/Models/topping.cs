using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PizzaOrderApp.Models
{
    public class topping
    {
        [Key]
        public int ToppingId { get; set; }
        public string ToppingName { get; set; }
        public float Toppingprice { get; set; }

        public override string ToString()
        {
            return "Topping Id:" + ToppingName +
                "ToppingPrice:" + Toppingprice + "\n";
        }
    }
}
