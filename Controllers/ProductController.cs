using System.Linq;
using ContractingCompany.FormsTagHelper.ViewModels;
using ContractingCompany.Models.PublicItems.ProductFld;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ContractingCompany.Controllers{
    public class ProductController : Controller{
        private IProduct _dal ;
        public ProductController(IProduct dal){
            _dal = dal;
        }
        public IActionResult List() => View(_dal.Products);


        public IActionResult AddProduct(){
            var pvm = new ProductViewModel();
            pvm.Product = new Product();

            pvm.ProductCategories = _dal.ProductCategories.Select(i=> new SelectListItem() {Value = i.ID.ToString() ,Text = i.Name}).ToList();

            pvm.Suppliers = _dal.Suppliers.Select(i=> new SelectListItem() {Value = i.ID.ToString() , Text = i.Name}).ToList();

            return View(pvm);

        }
        
        [HttpPost]
        public IActionResult AddProduct(Product product){
            _dal.AddProduct(product);
            return RedirectToAction(nameof(List));
        }

        public IActionResult UpdateProduct(int id){
            var pvm = new ProductViewModel();
            pvm.Product =_dal.GetProduct(id);
            pvm.ProductCategories = _dal.ProductCategories.Select(i=> new SelectListItem() {Value = i.ID.ToString() ,Text = i.Name}).ToList();
            pvm.Suppliers = _dal.Suppliers.Select(i=> new SelectListItem() {Value = i.ID.ToString() , Text = i.Name}).ToList();
            return View(pvm);
        }

        [HttpPost]
        public IActionResult UpdateProduct(Product product){
            _dal.UpdateProduct(product);
            return RedirectToAction(nameof(List));
        }

        public IActionResult DeleteProduct(int id){
            _dal.DeleteProduct(id);
            return RedirectToAction(nameof(List));
        }


    }
}