using System.Linq;
using ContractingCompany.Models.CCDBContextFld;
using Microsoft.EntityFrameworkCore;

namespace ContractingCompany.Models.Office.OfficeRepositoryFld{
    public class OfficeRepositoryEF : IOfficeRepository
    {
        private CCDBContext _ctx;
        public OfficeRepositoryEF(CCDBContext ctx){
            _ctx = ctx;
        }
        public IQueryable<OfficeRepository> OfficeRepositories => _ctx.OfficeRepositories.Include(i=> i.Product).ThenInclude(ii=> ii.ProductCategory).AsQueryable();

        public void AddOfficeRepository(OfficeRepository officeRepository)
        {
            _ctx.OfficeRepositories.Add(officeRepository);
            _ctx.SaveChanges();
        }

        public void DeleteOfficeRepository(int key)
        {
            _ctx.OfficeRepositories.Remove(GetOfficeRepository(key));
            _ctx.SaveChanges();
        }

        public OfficeRepository GetOfficeRepository(int key)
        {
            return _ctx.OfficeRepositories.Find(key);
        }

        public void UpdateAll(IQueryable<OfficeRepository> list)
        {
            foreach (var item in list)
            {
                //UpdateOfficeRepository(item);
            }
        }

        public void UpdateOfficeRepository(OfficeRepository officeRepository)
        {
            _ctx.OfficeRepositories.Update(officeRepository);
            _ctx.SaveChanges();
        }
    }
}