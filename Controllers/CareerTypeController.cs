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
        
        [HttpGet]
        public IActionResult AddCareerType(){
            return View();
        }

        [HttpPost]
        public IActionResult AddCareerType(CareerType careerType){
            _db.AddCareerType(careerType);
            return View(RedirectToAction(nameof(List)));
        }
    }    
}