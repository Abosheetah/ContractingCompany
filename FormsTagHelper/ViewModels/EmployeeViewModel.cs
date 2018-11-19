using System.Collections.Generic;
using ContractingCompany.Models.Office.CareerFld;
using ContractingCompany.Models.Office.EmployeeFld;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ContractingCompany.FormsTagHelper.ViewModels{
    public class EmployeeViewModel
    {
        public Employee Employee;
        public int CareerID;
        public List<SelectListItem> Careers;
    }
}