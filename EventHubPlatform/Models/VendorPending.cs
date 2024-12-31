using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace EventPlanner.Models 
{
    public class VendorPending
    {

        public int VendorId { get; set; }
        public string BusinessName { get; set; }
        public string BusinessDescription { get; set; }
        public string website { get; set; }
        public bool hasPermtion { get; set; } = false;


        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
