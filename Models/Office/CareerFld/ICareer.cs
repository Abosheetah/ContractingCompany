using System.Linq;

namespace ContractingCompany.Models.Office.CareerFld{
    public interface ICareer
    {
        IQueryable<Career> Careers {get;}
        Career GetCareer(int id);
        IQueryable<CareerType> GetCareerTypes();
        void AddCareer(Career career);
        void UpdateCareer(Career career);
        void DeleteCareer(Career career);
    }
}