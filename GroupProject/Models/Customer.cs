﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroupProject.Models
{
    public class Customer
    {

        public int CustomerId { get; set; }
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
        [Required(ErrorMessage = "Zip is required")]
        public string Zip { get; set; }
        [Required(ErrorMessage = "Card number is required")]
        public int CardNumber { get; set; }
        [Required(ErrorMessage = "Month is required")]
        public int Month { get; set; }
        [Required(ErrorMessage = "Day is required")]
        public int Year { get; set; }
        [Required(ErrorMessage = "CVC is required")]
        public int CVC { get; set; }
    }
}
