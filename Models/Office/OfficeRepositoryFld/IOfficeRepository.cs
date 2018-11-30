using System.Linq;
using ContractingCompany.Models.PublicItems.ProductFld;

namespace ContractingCompany.Models.Office.OfficeRepositoryFld{
    public interface IOfficeRepository
    {
        IQueryable<OfficeRepository> OfficeRepositories{get;}
        OfficeRepository GetOfficeRepository(int key);
        OfficeRepository GetOfficeRepositoryByProductID(int key);
        void AddOfficeRepository(OfficeRepository officeRepository);
        void UpdateOfficeRepository(OfficeRepository officeRepository);
        void DeleteOfficeRepository(int key);

        void UpdateAll(IQueryable<OfficeRepository> list);
    }
}