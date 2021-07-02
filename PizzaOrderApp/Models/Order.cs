using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaOrderApp.Models
{
    public class Order
    {
      
        [Key]
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public DateTime OrderDate { get; set; }
        

        [ForeignKey("UserId")]
        public User User { get; set; }


        public virtual OrderDetail OrdDetails { get; set; }


    }
}
