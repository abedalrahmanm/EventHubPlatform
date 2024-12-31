using EventPlanner.Models.VendorModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventPlanner.Models 
{
    public class Service
    {
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public string ServiceDescription { get; set; }
        public decimal BasePrice { get; set; }
        public string Availability { get; set; }

        public DateTime LastChangeAt { get; set; } = DateTime.Now;

        [ForeignKey("Location")]
        public int LocationId { get; set; }
        public Location Location { get; set; }

        public ICollection<ServiceSubcategory>? serviceSubcategories { get; set; }

        public ICollection<ServiceImage> serviceImages { get; set; }



        [ForeignKey("Vendor")]
        public int VendorId { get; set; }
        public Vendor Vendor { get; set; }

    }
}
