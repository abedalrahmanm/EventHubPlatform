
using System.ComponentModel.DataAnnotations.Schema;

namespace EventPlanner.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        [ForeignKey("Event")]
        public int EventId { get; set; }
        [ForeignKey("Service")]
        public int ServiceId { get; set; }

        public Decimal TotalCost { get; set; }
        public DateTime BookingDate { get; set; } 
        public DateTime LastChangeAt { get; set; } = DateTime.Now;

        public enum BookingStatus
        {
            Pending,
            Confirmed,
            Cancelled
        }
        public BookingStatus Status { get; set; }

        public List<Payment> Payments { get; set; }
        public List<Review> Reviews { get; set; }

        public Event Event { get; set; }
        public Service Service { get; set; }

    }
}
