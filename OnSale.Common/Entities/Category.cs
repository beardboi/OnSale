using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnSale.Common.Entities
{
    public class Category
    {
        // The id of the image
        public int Id { get; set; }

        // The name of the image
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

        // To display the image id
        [Display(Name = "Image")]
        public Guid ImageId { get; set; }

        // TODO: Pending to put the correct paths
        [Display(Name = "Image")]
        public string ImageFullPath => ImageId == Guid.Empty
            ? $"https://localhost:44325/images/noimage.png"
            : $"https://onsale2701.blob.core.windows.net/categories/{ImageId}";
    }
}
