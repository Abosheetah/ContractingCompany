using ContractingCompany.Models.PublicItems.ProductFld;
using Microsoft.AspNetCore.Mvc;

namespace ContractingCompany.Controllers{
    public class ProductCategoryController : Controller{
        private IProductCategory _dal;
        public ProductCategoryController(IProductCategory dal){
            _dal = dal;
        }

        public IActionResult List()=> View(_dal.ProductCategories);
        
        public IActionResult AddProductCategory(){

            return View(new ProductCategory());
        }

        [HttpPost]
         public IActionResult AddProductCategory(ProductCategory productCategory){
            _dal.AddProductCategory(productCategory);
            return RedirectToAction(nameof(List));
           
        }

        public IActionResult UpdateProductCategory(int id){
            return View(_dal.GetProductCategory(id));
        }
        
        [HttpPost]
        public IActionResult UpdateProductCategory(ProductCategory productCategory){
            _dal.UpdateProductCategory(productCategory);
            return RedirectToAction(nameof(List));
        }

        public IActionResult DeleteProductCategory(int id){
            _dal.DeleteProductCategory(id);
            return RedirectToAction(nameof(List));
        }

    }
}