namespace HotelBookingRESTAPI.Models
{
    public class HotelBooking
    {
        public int Id { get; set; }
        public int RoomNumber { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Nationality { get; set; }
    }
}
