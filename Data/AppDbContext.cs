using Microsoft.EntityFrameworkCore;
using MauiApp1.Api.Models;

namespace MauiApp1.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Albaran> Albaranes { get; set; }
        public DbSet<LineaAlbaran> LineasAlbaranes { get; set; }
        //public DbSet<Cliente> Clientes { get; set; }
        //public DbSet<Mercancia> Mercancias { get; set; }
        //public DbSet<Repartidor> Repartidores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Si hay relaciones o configuraciones especiales de tablas, agrégar aqui

            modelBuilder.Entity<Albaran>().ToTable("CABEALBV");
        }
    }
}
