using ContractingCompany.Models.PublicItems.ProductFld;
using Microsoft.AspNetCore.Mvc;

namespace ContractingCompany.Controllers{
    public class ProductController : Controller{
        private IProduct _dal ;
        public ProductController(IProduct dal){
            _dal = dal;
        }
        public IActionResult List() => View(_dal.Products);
    }
}