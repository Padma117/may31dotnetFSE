using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusBookingApp.Models
{
    public class BusStopDetail
    {
        [Key]
        public int BusStopId { get; set; }

        public int BusId { get; set; }

        public string StopName { get; set; }

        public double fare { get; set; }
        public bool boardingAllowed { get; set; }

        public bool departureAllowed { get; set; }

        [ForeignKey("BusId")]
        public BusDetail busDetails { get; set; }

    }
}
