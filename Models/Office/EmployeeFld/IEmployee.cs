using System.Linq;

namespace ContractingCompany.Models.Office.EmployeeFld{
    public interface IEmployee
    {
        IQueryable<Employee> Employees {get;}
        
    }
}