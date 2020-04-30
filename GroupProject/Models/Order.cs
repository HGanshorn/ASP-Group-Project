using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroupProject.Models
{
    public class Order
    {

        public int OrderId { get; set; }

        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }

        [Required(ErrorMessage = "City is required")]
        public string City { get; set; }

        [Required(ErrorMessage = "State is required")]
        public string State { get; set; }

        [Required(ErrorMessage = "Zip code is required")]
        [Range(00000, 99999, ErrorMessage = "Zip code must be in this format: 55555")]
        public int Zip { get; set; }

        [Required(ErrorMessage = "Card Number is required")]
        [Range(0000000000000000, 9999999999999999, ErrorMessage = "Card Number must be in this format: 5555555555555555")]
        public decimal CardNumber { get; set; }

        [Required(ErrorMessage = "Month is required")]
        [Range(01, 12, ErrorMessage = "Month must be in this format: 01")]
        public int Month { get; set; }

        [Required(ErrorMessage = "Year is required")]
        [Range(0000, 9999, ErrorMessage = "Year must be in this format: 2020")]
        public int Year { get; set; }

        [Required(ErrorMessage = "CVC is required")]
        [Range(000, 999, ErrorMessage = "CVC must be in this format: 555")]
        public int CVC { get; set; }


        //public string ProductId { get; set; }
        //public Product Product { get; set; }
    }
}
