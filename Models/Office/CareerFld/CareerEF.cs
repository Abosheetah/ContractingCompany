using System;
using System.Linq;
using ContractingCompany.Models.CCDBContextFld;
using Microsoft.EntityFrameworkCore;

namespace ContractingCompany.Models.Office.CareerFld{
    public class CareerEF : ICareer
    {
        private CCDBContext db;
        public CareerEF(CCDBContext context){
            db = context;
        }
        public IQueryable<Career> Careers => db.Careers.Include(i=>i.CareerType).AsQueryable();

        public void DeleteCareer(Career career)
        {
            bool isExist = db.Employees.Where(i=> i.CareerID == career.ID).Any();
            if (isExist)
            {
                throw new Exception("لا يمكن حذف الوظيفة لارتباطها ببعض الموظفين");
            }
            else
            {
                db.Careers.Remove(career);
                db.SaveChanges();
            }            
        }

        public Career GetCareer(int id)
        {
            return db.Careers.Find(id);
        }

        public void UpdateCareer(Career career)
        {
            db.Careers.Update(career);
            db.SaveChanges();

        }
    }
}