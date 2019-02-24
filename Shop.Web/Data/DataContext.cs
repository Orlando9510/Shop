


namespace Shop.Web.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    // diseño total nuevo del entity framework
    using Microsoft.EntityFrameworkCore;
    using Shop.Web.Data.Entities;

    public class DataContext : IdentityDbContext<User>
    {
        // Adicionar tabla products a la base de datos por medio de una propiedad
        public DbSet<Product> Products { get; set; }

        // Adicionar tabla de paises a la base de datos por medio de una propiedad
        public DbSet<Country> Countries { get; set; }
        
        // para conectarse a la base de datos
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
               
        }


    }
}
