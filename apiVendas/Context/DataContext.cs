using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using apiVendas.Models;

namespace apiVendas.Context
{
    public class DataContext : IdentityDbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<apiVendas.Models.Vendedor> Vendedor { get; set; }
        public DbSet<apiVendas.Models.Venda> Venda { get; set; }
    }
}
