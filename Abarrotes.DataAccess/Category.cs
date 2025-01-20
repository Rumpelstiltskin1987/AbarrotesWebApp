using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abarrotes.DataAccess
{
    public class Category
    {
        public int IdCategory { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public string? Name { get; set; }

        public string? Status { get; set; }

        public string? CreateUser { get; set; }

        public DateTime CreateDate { get; set; }

        public string? LastUpdateUser { get; set; }

        public DateTime? LastUpdateDate { get; set; }     
    }
}
