


namespace Shop.Web.Data
{
    // diseño total nuevo del entity framework
    using Microsoft.EntityFrameworkCore;
    using Shop.Web.Data.Entities;

    public class DataContext : DbContext
    {
        // Adicionar tabla products a la base de datos por medio de una propiedad
        public DbSet<Product> Products { get; set; }
        
        // para conectarse a la base de datos
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
               
        }


    }
}
