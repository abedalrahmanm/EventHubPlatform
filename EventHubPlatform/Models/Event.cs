using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventPlanner.Models 
{
    public class Event
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EventId { get; set; }

        [Required]
        [MaxLength(50)]
        public string EventName { get; set; }

        public string EventDescription { get; set; }

        [Required]
        [MaxLength(15)]
        public string EventType { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,3)")]
        public decimal Budget { get; set; }

        [Required]
        public int GuestsCount { get; set; }

        [Required]
        public DateTime EventDate { get; set; } 
        
        [Required]
        public DateTime EeventTime { get; set; }

        public string attachments { get; set; }

        public DateTime LastChangeAt { get; set; } = DateTime.Now;

        public enum EventStatus
        {
            draft,
            active,
            canceled,
            completed
        };
        public EventStatus Status { get; set; }


        public List<Booking> Bookings { get; set; }

        [ForeignKey("Location")]
        public int LocationId { get; set; }
        public Location Location { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }

    }
}
