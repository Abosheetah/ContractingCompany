using System.Collections.Generic;
using System.Linq;
using ContractingCompany.Models.Office.OfficeRepositoryFld;
using ContractingCompany.Models.PublicItems.ProductFld;
using Microsoft.AspNetCore.Mvc;

namespace ContractingCompany.Controllers {
   public class OfficeRepositoryController : Controller{
       private IProduct _prodDal;
       private IOfficeRepository _repoDal ;

       public OfficeRepositoryController(IOfficeRepository RepoDal,IProduct prodDal){
           _repoDal = RepoDal;
           _prodDal = prodDal;
       }

       public IActionResult List(){                                          
            ViewBag.Products  = _repoDal.Products.AsQueryable(); 
            return View(_repoDal.OfficeRepositories);
       }

     

        [HttpPost]
       public IActionResult UpdateAll(IQueryable<OfficeRepository> list){
           //_dal.UpdateAll(list);
           return RedirectToAction(nameof(List));
       }
   } 
}