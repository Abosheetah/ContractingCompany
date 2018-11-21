using System;
using System.Linq;
using ContractingCompany.Models.CCDBContextFld;
using ContractingCompany.Models.PublicItems.SupplierFld;
using Microsoft.EntityFrameworkCore;

namespace ContractingCompany.Models.PublicItems.ProductFld{
    public class ProductEF : IProduct
    {
        private CCDBContext _ctx ;
        public ProductEF(CCDBContext ctx){            
            _ctx = ctx;
        }
        public IQueryable<Product> Products => _ctx.Products.Where(i=> i.isActive == true).Include(i=> i.ProductCategory).Include(ii=>ii.Supplier).AsQueryable();
        public IQueryable<ProductCategory> ProductCategories => _ctx.ProductCategories.AsQueryable();
        public IQueryable<Supplier> Suppliers => _ctx.Suppliers.Where(i=> i.isActive == true).Include(i=>i.SupplierCategory).AsQueryable();        

        public void AddProduct(Product product)
        {
           try
           {
               _ctx.Products.Add(product);
               _ctx.SaveChanges();
           }
           catch (System.Exception)
           {
               
               throw;
           }
        }

        public void DeleteProduct(int Key)
        {
            try
            {
                bool isExist = _ctx.PurchaseOrderItems.Where(i=>i.ProductID == Key).Any();
                if (isExist)
                {
                    throw new Exception("لا يمكن حذف المنتج لارتباطه ببعض فواتير الشراء");                    
                }
                else
                {
                    Product product = _ctx.Products.Find(Key);
                    product.isActive = false;
                    _ctx.Products.Update(product);
                    _ctx.SaveChanges();
                    
                }
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        public Product GetProduct(int Key)
        {
            return _ctx.Products.Find(Key);
        }

        public void UpdateProduct(Product product)
        {
            _ctx.Products.Update(product);
            _ctx.SaveChanges();
        }
    }

}