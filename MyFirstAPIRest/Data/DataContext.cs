using Microsoft.EntityFrameworkCore;

namespace MyFirstAPIRest.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<MyFirstAPIRest.Entidades.Categoria> Categoria { get; set; }
        public DbSet<MyFirstAPIRest.Entidades.Producto> Producto { get; set; }
    }
}
