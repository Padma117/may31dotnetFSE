using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;



namespace PizzaOrderApp.Models
{
    public class PizzaCrust
    {
        [Key]
        public int CrustId { get; set; }
        public string CrustName { get; set; }
        public float Crustprice { get; set; }
    }
}
