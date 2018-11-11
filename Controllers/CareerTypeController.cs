using ContractingCompany.Models.Office.CareerFld;
using Microsoft.AspNetCore.Mvc;

namespace ContractingCompany.Controllers{
    public class CareerTypeController : Controller{
        private ICareerType _db;
        public CareerTypeController(ICareerType db){
            _db = db;
        }

        public IActionResult List(){
            return View(_db.CareerTypes);
        }
    }    
}