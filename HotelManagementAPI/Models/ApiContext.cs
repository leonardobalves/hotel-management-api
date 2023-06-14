using Microsoft.EntityFrameworkCore;

namespace HotelManagementAPI.Models
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options) 
        {        
        }

        public DbSet<ApiContext> Bookings { get; set; }
    }
}
