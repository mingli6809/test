using MvcApplication1.Models;
using System.Data.Entity;


namespace WebApplication1
{
    public class AppContext : DbContext
    {
        public AppContext()
            : base("DefaultConnection")
        {
        }
        public DbSet<Client> Clients { get; set; }
    }
}
