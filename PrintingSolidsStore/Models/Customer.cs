using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PrintingSolidsStore.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a username.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter a password.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please enter a valid email")]
        public string Email { get; set; }

    }
}
