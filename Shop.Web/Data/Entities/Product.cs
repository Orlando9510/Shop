
namespace Shop.Web.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Product : IEntity
    {
        // Clave primaria
        public int Id { get; set; }

        // tamaño maximo de 50
        // Volver campo obligatorio
        [MaxLength(50, ErrorMessage = "The field (0) Only can (1) Characters Length.")]
        [Required]
        public string Name { get; set; }

        // Darle formato a la columna Price. Que muestre la moneda que esta configurada el sistema
        // currency de 2 - (0:2) separador demiles con 2 decimales
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Price { get; set; }

        // Display Sirve para colocarle nombre para el usuario
        [Display(Name = "Image")]
        public string ImageUrl { get; set; }

        // DateTime? el atributo puede ser nulo
        [Display(Name = "Last Purchase")]
        public DateTime? LastPurchase { get; set; }

        // DateTime? el atributo puede ser nulo
        [Display(Name = "Last Sale")]
        public DateTime? LastSale { get; set; }

        [Display(Name = "Is Availabe?")]
        public bool IsAvailabe { get; set; }

        //Numerico de dos decimales
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public double Stock { get; set; }

        // Hace una relación de uno a varios con la tabla de usuarios
        // 1 usuario tiene muchos productos
        public User User {get; set;}
    }

}
