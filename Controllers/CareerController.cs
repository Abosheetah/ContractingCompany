using System;
using System.Linq;
using ContractingCompany.Models.Office.CareerFld;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace  ContractingCompany.Controllers{
    public class CareerController : Controller
    {
        private ICareer db;
        public CareerController(ICareer ctx){
            db = ctx;
        }
        public IActionResult List() => View(db.Careers);

        public IActionResult AddCareer(){            
            ViewBag.CareerTypes = db.GetCareerTypes();
            return View();
        }

        [HttpPost]
        public IActionResult AddCareer(Career career){
            db.AddCareer(career);
            return RedirectToAction(nameof(List));
        }

        [HttpGet]
        public IActionResult UpdateCareer(int id){
            ViewBag.CareerTypes = db.GetCareerTypes();
            return View(db.GetCareer(id));
        }

        [HttpPost]
        public IActionResult UpdateCareer(Career career){
            db.UpdateCareer(career);
            return RedirectToAction(nameof(List));
        }

        [HttpGet]
        public IActionResult DeleteCareer(int id){
            db.DeleteCareer(db.GetCareer(id));
            return RedirectToAction(nameof(List));
        }
      
    }
}