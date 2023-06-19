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
    }
}
