using ContractingCompany.Models.Office.CareerFld;
using Microsoft.AspNetCore.Mvc;

namespace  ContractingCompany.Controllers{
    public class CareerController : Controller
    {
        private ICareer db;
        public CareerController(ICareer ctx){
            db = ctx;
        }
        public IActionResult List() => View(db.Careers);
        public IActionResult AddCareer() => View();
    }
}