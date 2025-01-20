using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abarrotes.DataAccess
{
    public class Product
    {
        public int IdProduct { get; set; }

        [Required(ErrorMessage = "El Nombre es obligatorio.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "La categoría es obligatoria.")]
        public int IdCategory { get; set; }

        [Required(ErrorMessage = "El precio es obligatorio.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "El precio debe ser mayor que cero.")]
        public decimal Price { get; set; }

        public int Stock { get; set; }

        public string? MeasureUnit { get; set; }

        public string? UrlImage { get; set; }

        public string? Status { get; set; }

        public string? CreateUser { get; set; }

        public DateTime CreateDate { get; set; }

        public string? LastUpdateUser { get; set; }

        public DateTime? LastUpdateDate { get; set; }
    }
}
