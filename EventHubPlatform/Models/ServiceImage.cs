namespace EventPlanner.Models 
{
    public class ServiceImage
    {
        public int ImageId { get; set; }
        public string ImageUrl { get; set; }
        public string AltText{ get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public int ServiceId { get; set; }
        public Service Service { get; set; }
    }
}
