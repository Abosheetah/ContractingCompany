using System.Collections.Generic;
using ContractingCompany.Models.PublicItems.ProductFld;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ContractingCompany.FormsTagHelper.ViewModels{
    public class ProductViewModel
    {
        public Product Product;
        public List<SelectListItem> ProductCategories;
        public List<SelectListItem> Suppliers;
    }
}
