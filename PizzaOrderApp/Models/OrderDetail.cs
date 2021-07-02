using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaOrderApp.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderId { get; set; }
        public int PizzaId { get; set; }
        public int CrustId { get; set; }
        public int SizeId { get; set; }
        public int ToppingId { get; set; }
        public int ToppingId1 { get; set; }
        public int Quantity { get; set;}
        public float price { get; set;}

        [ForeignKey("OrderId")]
        public Order Order { get; set; }

        [ForeignKey("PizzaId")]
        public Item Item { get; set; }

        [ForeignKey("CrustId")]
        public PizzaCrust PizzaCrust { get; set; }

        [ForeignKey("SizeId")]
        public PizzaSize PizzaSize { get; set; }

        [ForeignKey("ToppingId")]
        public topping topping { get; set; }







    }
}
