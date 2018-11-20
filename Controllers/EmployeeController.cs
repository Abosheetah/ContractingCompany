using System.Linq;
using ContractingCompany.FormsTagHelper.ViewModels;
using ContractingCompany.Models.Office.EmployeeFld;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ContractingCompany.Controllers{
    public class EmployeeController : Controller{
        private IEmployee _tem;
        public EmployeeController(IEmployee tem){
            _tem = tem;
        }

        public IActionResult List() => View(_tem.Employees);      
        
        public IActionResult AddEmployee(){
            var evm = new EmployeeViewModel();
            evm.Employee = new Employee();
            evm.Careers = _tem.GetCareers().Select(i=> new SelectListItem() {Value = i.ID.ToString() , Text = i.Name}).ToList();
            return View(evm); 
        }
        [HttpPost]
        public IActionResult AddEmployee(Employee employee){
            _tem.AddEmployee(employee);
            return RedirectToAction(nameof(List));
        }


        [HttpGet]
        public IActionResult UpdateEmployee(int id){
            var evm = new EmployeeViewModel();
            evm.Employee = _tem.GetEmployee(id);
            evm.Careers = _tem.GetCareers().Select(i=> new SelectListItem() {Value = i.ID.ToString() , Text = i.Name}).ToList();
            return View(evm);
        }

        [HttpPost]
        public IActionResult UpdateEmployee(Employee employee){
            _tem.UpdateEmployee(employee);
            return RedirectToAction(nameof(List));
        }

        [HttpGet]
        public IActionResult DeleteEmployee(int id){
            _tem.DeleteEmployee(_tem.GetEmployee(id));
            return RedirectToAction(nameof(List));
        }

    }
}