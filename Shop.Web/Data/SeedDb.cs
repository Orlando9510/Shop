
namespace Shop.Web.Data
{

    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Entities;

    public class SeedDb
    {
        private readonly DataContext context;
        private Random random;

        // Inyectar conexión a la base de datos
        public SeedDb(DataContext context)
        {
            this.context = context;
            this.random = new Random();
        }

        public async Task SeedAsync()
        {
            await this.context.Database.EnsureCreatedAsync();

            // Si no hay ningun producto adicionar la siguiente lista
            if (!this.context.Products.Any())
            {
                this.AddProduct("iphone X");
                this.AddProduct("Magic Mouse");
                this.AddProduct("iwatch Series 4");
                await this.context.SaveChangesAsync();
            }
        }

        // crear 3 productos con precios aleatorios
        private void AddProduct(string name)
        {
            this.context.Products.Add(new Product
            {
                Name = name,
                Price = this.random.Next(100),
                IsAvailabe = true,
                Stock = this.random.Next(100)
            });
        }
    }


}
