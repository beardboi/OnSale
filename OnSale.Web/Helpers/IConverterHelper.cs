using OnSale.Common.Entities;
using OnSale.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnSale.Web.Helpers
{
    public interface IConverterHelper
    {
        // To convert from Category to CategoryViewModel
        Category ToCategory(CategoryViewModel model, Guid imageId, bool isNew);

        // To convert from CategoryViewModel to Category
        CategoryViewModel ToCategoryViewModel(Category category);

        // To convert from ProductViewModel to Product
        Task<Product> ToProductAsync(ProductViewModel model, bool isNew);

        // To convert from Product to ProductViewModel
        ProductViewModel ToProductViewModel(Product product);
    }
}
