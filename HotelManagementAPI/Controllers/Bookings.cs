using HotelManagementAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagementAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class Bookings : ControllerBase
    {
        private readonly ApiContext _context;

        public Bookings(ApiContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Room>> Get()
        {
            var rooms = _context.Rooms.ToList();
            if (rooms is null)
            {
                return NotFound("Rooms not found...");
            }
            return rooms;
        }

        [HttpGet("{id:int}", Name= "GetRoom")]
        public ActionResult<Room> Get(int id)
        {
            var rooms = _context.Rooms.FirstOrDefault(opt => opt.RoomId == id);
            if (rooms is null)
            {
                return NotFound("Room not found...");
            }
            return rooms;
        }

        [HttpPost]
        public ActionResult Post(Room room)
        {
            if (room is null)
                return BadRequest();

            _context.Rooms.Add(room);
            _context.SaveChanges();

            return new CreatedAtRouteResult("GetRoom", new { id = room.RoomId }, room);
        }

    }
}
