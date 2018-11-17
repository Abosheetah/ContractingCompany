using System.Linq;
using ContractingCompany.Models.Office.CareerFld;

namespace ContractingCompany.Models.Office.EmployeeFld{
    public interface IEmployee
    {
        IQueryable<Employee> Employees {get;}
        void AddEmployee(Employee employee);
        Employee GetEmployee(int id);
        IQueryable<Career> GetCareers();
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(Employee employee);
    }
}