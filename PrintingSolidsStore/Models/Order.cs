using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PrintingSolidsStore.Models
{
    public class Order
    {
        public int OrderID { get; set; }

        [Required(ErrorMessage = "Customer not added to order")]
        public Customer Customer { get; set; }

        [Required(ErrorMessage = "Product not added to order")]
        public Product Product { get; set; }
    }
}
