using System;
using System.Linq;
using ContractingCompany.Models.CCDBContextFld;

namespace ContractingCompany.Models.PublicItems.SupplierFld{
    public class SupplierCategoryEF : ISupplierCategory
    {
        private CCDBContext _ctx ;
        public SupplierCategoryEF(CCDBContext ctx){
            _ctx = ctx;
        }
        public IQueryable<SupplierCategory> SupplierCategories => _ctx.SupplierCategories.AsQueryable();

        public void AddSupplierCategory(SupplierCategory supplierCategory)
        {
            try
            {
                _ctx.SupplierCategories.Add(supplierCategory);
                _ctx.SaveChanges();
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        public void DeleteSupplierCategory(int Key)
        {
            try
            {
                bool isExist = _ctx.Suppliers.Select(i=> i.SupplierCategoryID).Any();
                if (isExist)
                {
                    throw new Exception("لايمكن حذف نوع المورد لارتباطه ببعض الموردين");
                }
                else
                {
                    _ctx.SupplierCategories.Remove(_ctx.SupplierCategories.Find(Key));
                    _ctx.SaveChanges();
                }
                
            }
            catch (System.Exception)
            {                
                throw;
            }
        }

        public SupplierCategory GetSupplierCategory(int Key)
        {
            return _ctx.SupplierCategories.Find(Key);
        }

        public void UpdateSupplierCategory(int Key)
        {
            try
            {
                _ctx.SupplierCategories.Update(_ctx.SupplierCategories.Find(Key));
                _ctx.SaveChanges();
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }
    }
}