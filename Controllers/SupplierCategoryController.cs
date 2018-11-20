using ContractingCompany.Models.PublicItems.SupplierFld;
using Microsoft.AspNetCore.Mvc;

namespace ContractingCompany.Controllers{
    public class SupplierCategoryController : Controller
    {
        private ISupplierCategory _dal;
        public SupplierCategoryController (ISupplierCategory dal){
            _dal = dal;
        }

        public IActionResult List() => View(_dal.SupplierCategories);

        public IActionResult AddSupplierCategory(){
            return View();
        }

        [HttpPost]
         public IActionResult AddSupplierCategory(SupplierCategory supplierCategory){
             _dal.AddSupplierCategory(supplierCategory);
            return RedirectToAction(nameof(List));
        }
        
    }
}