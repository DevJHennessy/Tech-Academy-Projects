using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ACME.Models
{
    [MetadataType(typeof(Product.Metadata))]
    public partial class Product
    {
        //Nobody can inherit of extend this class, so it is sealed:
        sealed class Metadata
        {
            [Key]
            public System.Guid ProductId { get; set; }

            //Below is a custom message for the Name field as a data annotation:
            //[Required(ErrorMessage = "This is a custom message.")]
            [Required]
            [Display(Name="Product Name")]
            [StringLength(10)]
            public string Name { get; set; }

            [Required]
            [RegularExpression(@"^\$?\d+(\.(\d{2}))?$")]
            //[Range(0.01, 1000.0)] //This does the same as the if statement in the 
            //ProductsController.

            public decimal Price { get; set; }
        }
    }
}