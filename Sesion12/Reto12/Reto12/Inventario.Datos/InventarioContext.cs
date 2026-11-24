using Inventario.Modelos;
using Microsoft.EntityFrameworkCore;
using Reto12.Inventario.Modelos;


namespace Inventario.Datos
{
    public class InventarioContext : DbContext
    {
        public DbSet<Producto> Productos => Set<Producto>();
        public DbSet<Categoria> Categorias => Set<Categoria>();

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=inventario.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>().HasKey(p => p.Codigo);
        }
    }
}
