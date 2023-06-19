using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagementAPI.Models;

[Table("Rooms")]
public class Room
{
    public Room()
    {
        Clients = new Collection<Client>();
    }

    [Key]
    public int RoomId { get; set; }

    [Required]
    public int RoomNumber { get; set; }

    [Required]
    public bool Vacant { get; set; }

    public ICollection<Client>? Clients { get; set; }
}
