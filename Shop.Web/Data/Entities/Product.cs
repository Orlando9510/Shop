
namespace Shop.Web.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Product
    {
        // Clave primaria
        public int Id { get; set; }

        public string Name { get; set; }

        // Darle formato a la columna Price. Que muestre la moneda que esta configurada el sistema
        // currency de 2 - (0:2) separador demiles con 2 decimales
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Price { get; set; }

        // Display Sirve para colocarle nombre para el usuario
        [Display(Name = "Image")]
        public string ImageUrl { get; set; }

        [Display(Name = "Last Purchase")]
        public DateTime LastPurchase { get; set; }

        [Display(Name = "Last Sale")]
        public DateTime LastSale { get; set; }

        [Display(Name = "Is Availabe?")]
        public bool IsAvailabe { get; set; }

        //Numerico de dos decimales
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public double Stock { get; set; }
    }

}
