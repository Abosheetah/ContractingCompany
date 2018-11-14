using System.Linq;

namespace ContractingCompany.Models.Office.CareerFld{
    public interface ICareerType
    {
        IQueryable<CareerType> CareerTypes {get;}
        void AddCareerType(CareerType careerType);
        CareerType GetCareerType(int id);
        void UpdateCareerType(CareerType careerType);
        void DeleteCareerType(CareerType careerType);
    }
}