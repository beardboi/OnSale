using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace OnSale.Web.Models
{
    public class AddProductImageViewModel
    {
        // The product Id
        public int ProductId { get; set; }

        // The image file of the product
        [Display(Name = "Image")]
        [Required]
        public IFormFile ImageFile { get; set; }
    }
}
