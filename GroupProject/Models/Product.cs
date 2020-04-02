﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroupProject.Models
{
    public class Product
    {
        
        public int ProductId { get; set; }
        [Required (ErrorMessage="Name is required")]
        public string Name { get; set; }
        [Required (ErrorMessage ="Price is required")]
        public decimal Price { get; set; }
        [Required (ErrorMessage ="Description is required")]
        public string Description { get; set; }

        [Required (ErrorMessage ="Category is required")]
        public string CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
