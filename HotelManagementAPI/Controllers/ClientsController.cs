using HotelManagementAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            var clients = _context.Clients.AsNoTracking().ToList();
            if (clients is null)
            {
                return NotFound("Clients not found...");
            }

            return clients;
        }

        //GET ID
        [HttpGet("{id:int}", Name = "GetClient")]
        public ActionResult<Client> Get(int id)
        {
            var clients = _context.Clients.AsNoTracking().FirstOrDefault(p => p.ClientId == id);
            if (clients is null)
            {
                return NotFound("Client not found...");
            }

            return clients;
        }

        //POST
        [HttpPost]
        public ActionResult<Client> Post(Client client)
        {
            if (client == null)
                return BadRequest();

            _context.Clients.Add(client);
            _context.SaveChanges();

            return new CreatedAtRouteResult("GetClient", new { id = client.ClientId }, client);
        }


        //PUT
        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Client client)
        {
            if (id != client.ClientId)
            {
                return BadRequest();
            }

            _context.Entry(client).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(client);
        }

        //DELETE
        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            var client = _context.Clients.FirstOrDefault(p => p.ClientId == id);
            if (client is null)
            {
                return NotFound();
            }
            _context.Clients.Remove(client);
            _context.SaveChanges();

            return Ok(client);
        }
    }
}
