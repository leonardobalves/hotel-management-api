namespace HotelManagementAPI.Models
{
    public class HotelBooking
    {
        public int Id { get; set; }
        public int RoomNumber { get; set; }
        public string? ClientName { get; set; }
        public bool Vacant { get; set; }
    }
}
