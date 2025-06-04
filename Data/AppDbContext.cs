using Microsoft.EntityFrameworkCore;
using portal_cliente.csproj.Models;

namespace portal_cliente.csproj.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Loja> Lojas { get; set; }
    }
}
