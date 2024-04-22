using Microsoft.EntityFrameworkCore;
using PrimeiraAPI.Model;

namespace PrimeiraAPI.Data
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public ConnectionContext(DbContextOptions<ConnectionContext> options) : base(options)
        {
        }

        public ConnectionContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configurações do modelo, se necessário
        }
    }
}
