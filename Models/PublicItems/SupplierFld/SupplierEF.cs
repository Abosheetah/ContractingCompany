using System;
using System.Linq;
using ContractingCompany.Models.CCDBContextFld;
using Microsoft.EntityFrameworkCore;

namespace ContractingCompany.Models.PublicItems.SupplierFld{
    public class SupplierEF : ISupplier
    {
        private CCDBContext _ctx ; 
        public SupplierEF(CCDBContext ctx){
            _ctx = ctx;
        }
        public IQueryable<Supplier> Suppliers => _ctx.Suppliers.Where(y=> y.isActive == true).Include(x=> x.SupplierCategory).AsQueryable();

        public IQueryable<SupplierCategory> SupplierCategories => _ctx.SupplierCategories.AsQueryable();

        public void AddSupplier(Supplier supplier)
        {
            try
            {
                _ctx.Suppliers.Add(supplier);
                _ctx.SaveChanges();
            }
            catch (System.Exception)
            {
                
                throw;
            }
            
        }

        public void DeleteSupplier(int Key)
        {
            try
            {
                bool isExist = _ctx.PurchaseOrders.Where(i=> i.SupplierID == Key).Any();
                if (isExist)
                {
                 throw new Exception("لا يمكن حذف المورد لارتباطه ببعض المشتريات");   
                }
                else
                {
                    Supplier supplier = _ctx.Suppliers.Find(Key);
                    supplier.isActive = false;
                    _ctx.Suppliers.Update(supplier);
                    _ctx.SaveChanges();
            
                }
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        public Supplier GetSupplier(int Key)
        {
           return _ctx.Suppliers.Find(Key);
        }

        public void UpdateSupplier(Supplier supplier)
        {
            _ctx.Suppliers.Update(supplier);
            _ctx.SaveChanges();
        }
    }
}