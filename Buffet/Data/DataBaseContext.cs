using Buffet.Models.Buffet.Cliente;
using Microsoft.EntityFrameworkCore;

namespace Buffet.Data
{
    public class DataBaseContext : DbContext
    {
        public DbSet<ClienteEntity> Clientes { get; set; }
        
        public DataBaseContext(DbContextOptions<DataBaseContext> options):base(options)
        {
            
        }
    }
}