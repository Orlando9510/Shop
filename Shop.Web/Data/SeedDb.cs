
namespace Shop.Web.Data
{

    using Entities;
    using Helpers;
    using Microsoft.AspNetCore.Identity;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    public class SeedDb
    {
        private readonly DataContext context;
        private readonly IUserHelper userhelper;
        private readonly Random random;

        // Inyectar conexión a la base de datos
        public SeedDb(DataContext context, IUserHelper userhelper)
        {
            this.context = context;
            this.userhelper = userhelper;
            this.random = new Random();
        }

        public async Task SeedAsync()
        {
            await this.context.Database.EnsureCreatedAsync();

            var user = await this.userhelper.GetUserByEmailAsync("Orlandoespinosa166321@correo.itm.edu.co");
            if (user == null)
            {
                user = new User
                {
                    FirstName = "Orlando",
                    LastName = "Espinosa",
                    Email = "Orlandoespinosa166321@correo.itm.edu.co",
                    UserName = "Orlandoespinosa166321@correo.itm.edu.co",
                    PhoneNumber = "3193329855"
                };

                // crear usuario con la contraseña "123456"
                var result = await this.userhelper.AddUserAsync(user, "123456");
                if (result != IdentityResult.Success)
                {
                    throw new InvalidOperationException("Could not create the user in seeder");
                }
            }


            // Si no hay ningun producto adicionar la siguiente lista
            if (!this.context.Products.Any())
            {
                this.AddProduct("iphone X", user);
                this.AddProduct("Magic Mouse", user);
                this.AddProduct("iwatch Series 4", user);
                await this.context.SaveChangesAsync();
            }
        }

        // crear 3 productos con precios aleatorios
        private void AddProduct(string name, User user)
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
