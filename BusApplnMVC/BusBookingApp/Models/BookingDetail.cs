using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BusBookingApp.Models
{
    public class BookingDetail
    { 
     [Key]
    public int BookingId { get; set; }

    public int CustId { get; set; }

    public int BusId { get; set; }

    public double fare { get; set; }
    public DateTime TravelDate { get; set; }

    public string FromCity { get; set; }

    public string ToCity { get; set; }

    public int AdultPassengers { get; set; }

    public int childPassengers { get; set; }

    public double Totalfare { get; set; }

    public bool departureAllowed { get; set; }

    [ForeignKey("CustId")]
    public Customer customer { get; set; }

    [ForeignKey("BusId")]
    public BusDetail busdetails { get; set; }

   }

}
