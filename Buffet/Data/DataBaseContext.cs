using Buffet.Models.Buffet.Cliente;
using Buffet.Models.Buffet.Evento;
using Microsoft.EntityFrameworkCore;

namespace Buffet.Data
{
    public class DataBaseContext : DbContext
    {
        public DbSet<ClienteEntity> Clientes { get; set; }
        
        public DbSet<EventoEntity> Eventos { get; set; }
        
        public DataBaseContext(DbContextOptions<DataBaseContext> options):base(options)
        {
            
        }
    }
}