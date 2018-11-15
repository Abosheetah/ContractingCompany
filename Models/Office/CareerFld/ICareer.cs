using System.Linq;

namespace ContractingCompany.Models.Office.CareerFld{
    public interface ICareer
    {
        IQueryable<Career> Careers {get;}
        Career GetCareer(int id);
        void UpdateCareer(Career career);
        void DeleteCareer(Career career);
    }
}