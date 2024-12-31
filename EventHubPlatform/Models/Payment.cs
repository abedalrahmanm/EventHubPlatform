namespace EventPlanner.Models 
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public int BookingId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }

        public enum Payment_Method
        {
            CreditCard,
            DebitCard,
            PayPal,
            Venmo,
            Cash
        }
        public Payment_Method PaymentMethod { get; set; }
        public enum Payment_Status
        {
            Pending,
            Paid,
            Refunded
        }
        public Payment_Status PaymentStatus { get; set; }

        public Booking Booking { get; set; }
    }
}
