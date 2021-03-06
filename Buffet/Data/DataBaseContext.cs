using System;
using Buffet.Models.Acesso;
using Buffet.Models.Buffet.Cliente;
using Buffet.Models.Buffet.Evento;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Buffet.Data
{
    public class DataBaseContext : IdentityDbContext<Usuario,Papel,Guid>
    {
        public DbSet<ClienteEntity> Clientes { get; set; }
        
        public DbSet<EventoEntity> Eventos { get; set; }
        
        public DataBaseContext(DbContextOptions<DataBaseContext> options):base(options)
        {
            
        }
    }
}