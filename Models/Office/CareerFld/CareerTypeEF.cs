using System;
using System.Linq;
using ContractingCompany.Models.CCDBContextFld;

namespace ContractingCompany.Models.Office.CareerFld{
    public class CareerTypeEF : ICareerType
    {
        private CCDBContext _db;
        public CareerTypeEF(CCDBContext db){
            _db = db;
        }
        public IQueryable<CareerType> CareerTypes => _db .CareerTypes;

        public void AddCareerType(CareerType careerType)
        {
            _db.CareerTypes.Add(careerType);
            _db.SaveChanges();
        }

        public void DeleteCareerType(CareerType careerType)
        {
            bool isExist = _db.Careers.Where(i=>i.CareerTypeID == careerType.ID).Any();
            if (isExist)
            {
                throw new Exception("لا يمكن حذف نوع الوظيفة لارتباطها بوظائف موجودة فعلا");
            }
            else
            {
                _db.CareerTypes.Remove(careerType);
                _db.SaveChanges();
            }
        }

        public void UpdateCareerType(CareerType careerType)
        {
            _db.CareerTypes.Update(careerType);
            _db.SaveChanges();
        }
    }
}