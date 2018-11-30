using System.Linq;
using ContractingCompany.FormsTagHelper.ViewModels;
using ContractingCompany.Models.Office.OfficeRepositoryFld;
using ContractingCompany.Models.PublicItems.ProductFld;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ContractingCompany.Controllers{
    public class ProductController : Controller{
        private IProduct _dal ;
        private IOfficeRepository _offDal ;
        public ProductController(IProduct dal,IOfficeRepository offDal){
            _dal = dal;
            _offDal = offDal;
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

        public IActionResult UpdateQuantity(int id){
            Product product = _dal.GetProduct(id);
            OfficeRepository officeRepository = _offDal.OfficeRepositories.Where(i => i.ProductID == id).Any() ? _offDal.GetOfficeRepositoryByProductID(id) : new OfficeRepository(){ID = 0 ,ProductID = product.ID, Product = product,Quantity = 0};
            return View(officeRepository);
        }

        [HttpPost]
        public IActionResult UpdateQuantity(OfficeRepository officeRepository){
            bool isExist = _offDal.OfficeRepositories.Where(i => i.ProductID == officeRepository.ProductID).Any();
            if (isExist)
            {
                int officeRepoID = _offDal.OfficeRepositories.Where(i => i.ProductID == officeRepository.ProductID).Select( o => o.ID).Single();
                officeRepository.ID = officeRepoID;
                _offDal.UpdateOfficeRepository(officeRepository);
            }
            else
            {
            officeRepository.ID = 0;
            _offDal.AddOfficeRepository(officeRepository); 
            }                                   
            return RedirectToAction(nameof(List));
        }

    }
}