using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnSale.Common.Entities
{
    public class ProductImage
    {
        // The id of the product image
        public int Id { get; set; }

        // The imageId to show in the view
        [Display(Name = "Image")]
        public Guid ImageId { get; set; }

        // The image path
        //TODO: Pending to put the correct paths
        [Display(Name = "Image")]
        public string ImageFullPath => ImageId == Guid.Empty
            ? $"https://localhost:44325/images/noimage.png"
            : $"https://onsale2701.blob.core.windows.net/products/{ImageId}";
    }

}
