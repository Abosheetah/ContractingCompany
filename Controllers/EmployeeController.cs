using ContractingCompany.Models.Office.EmployeeFld;
using Microsoft.AspNetCore.Mvc;

namespace ContractingCompany.Controllers{
    public class EmployeeController : Controller{
        private IEmployee _tem;
        public EmployeeController(IEmployee tem){
            _tem = tem;
        }

        public IActionResult List() => View(_tem.Employees);

           public IActionResult AddEmployee(){            
            ViewBag.Careers = _tem.GetCareers();
            return View();
        }

        [HttpPost]
        public IActionResult AddEmployee(Employee employee){
            _tem.AddEmployee(employee);
            return RedirectToAction(nameof(List));
        }

    }
}