using Microsoft.EntityFrameworkCore;
using primeiraApi.Models;

namespace primeiraApi.Data 
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Define a tabela no banco
            modelBuilder.Entity<Usuarios>().ToTable("Usuarios");

            
            modelBuilder.Entity<Usuarios>().HasKey(u => u.Email);
        }
    }
}
