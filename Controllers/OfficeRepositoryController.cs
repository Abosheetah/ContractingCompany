using System.Linq;
using ContractingCompany.Models.Office.OfficeRepositoryFld;
using Microsoft.AspNetCore.Mvc;

namespace ContractingCompany.Controllers {
   public class OfficeRepositoryController : Controller{
       private IOfficeRepository _dal ;
       public OfficeRepositoryController(IOfficeRepository dal){
           _dal = dal;
       }

       public IActionResult List() => View(_dal.OfficeRepositories);

        [HttpPost]
       public IActionResult UpdateAll(IQueryable<OfficeRepository> list){
           //_dal.UpdateAll(list);
           return RedirectToAction(nameof(List));
       }
   } 
}