using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusBookingApp.Models
{
    public class BusDetail
    {
        [Key]
        public int BusId { get; set; }
        public string TravelsName { get; set; }
        public string BusType { get; set; }
        public int Age { get; set; }
        public String DepartureTime { get; set; }

        public String ArrivalTime { get; set; }

        public string FromCity { get; set; }

        public string ToCity { get; set; }

        public int Seats { get; set; }

        public double AdultFare { get; set; }

        public double ChildFare { get; set; }

    }
}
