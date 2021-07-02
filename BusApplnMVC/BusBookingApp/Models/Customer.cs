using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusBookingApp.Models
{
    public class Customer
    {
        [Key]
        public int CustId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public int Age { get; set; }
        public string Gender { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string city { get; set; }

        public int Pincode { get; set; }

        public string email { get; set; }

        public string phone { get; set; }

    }
}
