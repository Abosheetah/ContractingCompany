using System.Collections;
using ContractingCompany.Models.Office.CareerFld;
using Microsoft.AspNetCore.Mvc;

namespace ContractingCompany.Controllers{
    public class CareerTypeController : Controller{
        private ICareerType _db;
        public CareerTypeController(ICareerType db){
            _db = db;
        }

        public IActionResult List(){
            return View(_db.CareerTypes );
        }
        
        [HttpGet]
        public IActionResult AddCareerType(){
            return View();
        }

        [HttpPost]
        public IActionResult AddCareerType(CareerType careerType){
            _db.AddCareerType(careerType);
            return RedirectToAction(nameof(List));
        }

        [HttpGet]
        public IActionResult UpdateCareerType(int id){
            return View(_db.GetCareerType(id));
        }

        [HttpPost]
        public IActionResult UpdateCareerType(CareerType careerType){
            _db.UpdateCareerType(careerType);
            return RedirectToAction(nameof(List));
        }

        [HttpGet]
        public IActionResult DeleteCareerType(int id){
            _db.DeleteCareerType(_db.GetCareerType(id));
            return RedirectToAction(nameof(List));
        }
    }    
}