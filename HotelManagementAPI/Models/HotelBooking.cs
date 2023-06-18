using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagementAPI.Models
{
    [Table("Bookings")]
    public class HotelBooking
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int RoomNumber { get; set; }
        [Required]
        [MaxLength(30)]
        public string? ClientName { get; set; }
        [Required]
        public bool Vacant { get; set; }
    }
}
