
using System.Collections.Generic;
using ContractingCompany.Models.PublicItems.SupplierFld;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ContractingCompany.FormsTagHelper.ViewModels{
    public class SupplierViewModel
    {
        public Supplier Supplier;
        public List<SelectListItem> SupllierCategories ;
        
    }
}