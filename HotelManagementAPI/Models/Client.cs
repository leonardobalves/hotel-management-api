using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagementAPI.Models;

[Table("Clients")]
public class Client
{
    [Key]
    public int ClientId { get; set; }

    [Required]
    [StringLength(30)]
    public string? Name { get; set; }

    [Required]
    [StringLength(15)]
    public string? PhoneNumber { get; set; }

    public int? RoomId { get; set; }
    public Room? Room { get; set; }
}
