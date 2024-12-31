namespace EventPlanner.Models 
{
    public class Location
    {

        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public float latitude { get; set; }
        public float longitude { get; set; }



    }
}
