﻿namespace Learning.Web.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Product
    {
        public int ID { get; set; }
        
        [MaxLength (50,ErrorMessage ="The field {0} can be only {1} characters length")]
        [Required]
        public string Name { get; set; }

        [DisplayFormat(DataFormatString ="{0:C2}",ApplyFormatInEditMode = false)]
        public decimal Price { get; set; }

        [Display(Name = "Image")]
        public string ImageUrl { get; set; }
        
        [Display(Name = "Last Purchase")]
        public DateTime?  LastPurchase { get; set; }

        [Display(Name = "Last Sale")]
        public DateTime? LastSale { get; set; }

        [Display(Name ="IsAvailable?")]
        public bool IsAvailable { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}",ApplyFormatInEditMode =false)]
        public double Stock { get; set; }
    }
}
