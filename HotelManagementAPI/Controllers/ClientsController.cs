using HotelManagementAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagementAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly ApiContext _context;

        public ClientsController(ApiContext context)
        {
            _context = context;
        }

        //GET
        [HttpGet]
        public ActionResult<IEnumerable<Client>> Get()
        {
            var clients = _context.Clients.ToList();
            if (clients is null)
            {
                return NotFound("Clients not found...");
            }

            return clients;
        }

        //GET ID
        [HttpGet("{id:int}")]
        public ActionResult<Client> Get(int id)
        {
            var clients = _context.Clients.FirstOrDefault(p => p.ClientId == id);
            if (clients is null)
            {
                return NotFound("Client not found...");
            }

            return clients;
        }

        //POST
        //PUT
        //DELETE
    }
}
