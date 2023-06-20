using HotelManagementAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotelManagementAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private readonly ApiContext _context;

        public BookingsController(ApiContext context)
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

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Room room)
        {
            if (id != room.RoomId)
            {
                return BadRequest();
            }

            _context.Entry(room).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(room);
        }

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            var room = _context.Rooms.FirstOrDefault(p => p.RoomId == id);

            if (room is null)
            {
                return NotFound("Room not found...");
            }

            _context.Rooms.Remove(room);
            _context.SaveChanges();

            return Ok(room);
        }
    }
}
