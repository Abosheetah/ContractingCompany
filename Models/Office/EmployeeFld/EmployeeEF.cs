using System;
using System.Linq;
using ContractingCompany.Models.CCDBContextFld;
using ContractingCompany.Models.Office.CareerFld;
using Microsoft.EntityFrameworkCore;

namespace  ContractingCompany.Models.Office.EmployeeFld{
    public class EmployeeEF : IEmployee
    {
        private CCDBContext db;
        public EmployeeEF(CCDBContext ctx){
            db = ctx;
        }
        public IQueryable<Employee> Employees => db.Employees.Include(x=>x.Career).AsQueryable();

        public void AddEmployee(Employee employee)
        {
            db.Employees.Add(employee);
            db.SaveChanges();
        }

        public void DeleteEmployee(Employee employee)
        {
            bool isExist = db.PurchaseOrders.Where(i=>i.EmployeeID == employee.ID).Any();
            if (isExist)
            {
                throw new Exception("لا يمكن حذف الموظف لارتباطه ببعض فواتير الشراء");
            }
            else
            {
                db.Employees.Remove(employee);
                db.SaveChanges();
            }
        }

        public IQueryable<Career> GetCareers()
        {
            return db.Careers.AsQueryable();
        }

        public Employee GetEmployee(int id)
        {
            return db.Employees.Find(id);
        }

        public void UpdateEmployee(Employee employee)
        {
           db.Employees.Update(employee);
           db.SaveChanges();
        }
    }
}