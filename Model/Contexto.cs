using Microsoft.EntityFrameworkCore;

namespace TrabalhoReact.Model
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto>options): base(options) { }
        public DbSet<Cliente> Clientes { get; set; }
    }
}
