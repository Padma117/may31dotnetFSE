using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieTicketBookingApp.Models
{
    public class BookingDetail
    {
        [Key]
        public int booking_id { get; set; }

        public int customer_id { get; set; }

        public DateTime Order_Date_And_Time { get; set; }
        public string booking_status { get; set; }
        public int booking_totalamount { get; set; }
        public int seat_number { get; set; }

        public int Ticket_Id { get; set; }

        public int show_id { get; set; }
        public int ticket_qty { get; set; }
        
        [ForeignKey("Ticket_Id")]
        public Ticket ticket { get; set; }

    }
}
