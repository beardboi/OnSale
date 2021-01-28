using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace OnSale.Web.Helpers
{
    public interface IComboHelper
    {
        IEnumerable<SelectListItem> GetComboCategories();
    }
}
