using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PrintingSolidsStore.Models
{
    public class Product
    {
        public int ProductID { get; set; }

        [Required(ErrorMessage = "Please enter a product name.")]
        public String Name { get; set; }

        [Required(ErrorMessage = "Please enter a product price.")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        //public int ProductImage { get; set; }

    }
}
