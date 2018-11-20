using System.Linq;
using ContractingCompany.FormsTagHelper.ViewModels;
using ContractingCompany.Models.PublicItems.SupplierFld;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ContractingCompany.Controllers{
    public class SupplierController : Controller
    {
        private ISupplier _dal ;
        public SupplierController(ISupplier dal){
            _dal = dal;
        }
        public IActionResult List() => View(_dal.Suppliers.AsQueryable());
        public IActionResult AddSupplier(){
            var svm = new  SupplierViewModel();
            svm.Supplier = new Supplier();
            svm.SupllierCategories = _dal.SupplierCategories.Select(i=> new SelectListItem() {Value = i.ID.ToString() ,  Text = i.Name}).ToList();
            return View(svm);
        }

        [HttpPost]
        public IActionResult AddSupplier(Supplier supplier ){            
            _dal.AddSupplier(supplier);
            return RedirectToAction(nameof(List));
        }

        [HttpGet]
        public IActionResult UpdateSupplier(int id){
            var svm = new  SupplierViewModel();
            svm.Supplier = _dal.GetSupplier(id);
            svm.SupllierCategories = _dal.SupplierCategories.Select(i=> new SelectListItem() {Value = i.ID.ToString() ,  Text = i.Name}).ToList();
            return View(svm);
        }

        [HttpPost]
        public IActionResult UpdateSupplier(Supplier supplier ){
            _dal.UpdateSupplier(supplier);
            return RedirectToAction(nameof(List));
        }

        public IActionResult DeleteSupplier(int id){
            _dal.DeleteSupplier(id);
            return RedirectToAction(nameof(List));
        }
    }
}