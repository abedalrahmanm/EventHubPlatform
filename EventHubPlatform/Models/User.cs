using System.ComponentModel.DataAnnotations.Schema;

namespace EventPlanner.Models 
{
    public class User
    {
        public int id { get; set; }
        public string FullName { get; set; }
        public string IsDeleted { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;



        public List<Event> Events { get; set; }

        [ForeignKey("Venodr")]
        public int VendorId { get; set; }
        public Vendor Vendor { get; set; }


        
    }
}
