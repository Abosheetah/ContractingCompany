using System;
using System.Linq;
using ContractingCompany.Models.CCDBContextFld;

namespace ContractingCompany.Models.PublicItems.ProductFld{
    public class ProductCategoryEF : IProductCategory
    {
        private CCDBContext _ctx ;
        public ProductCategoryEF(CCDBContext ctx){
            _ctx = ctx;
        }
        public IQueryable<ProductCategory> ProductCategories => _ctx.ProductCategories.AsQueryable();

        public void AddProductCategory(ProductCategory productCategory)
        {
            _ctx.ProductCategories.Add(productCategory);
            _ctx.SaveChanges();
        }

        public void DeleteProductCategory(int Key)
        {
            try
            {
                bool isExist = _ctx.Products.Where(i=> i.ProductCategoryID == Key).Any();
                if (isExist)
                {
                    throw new Exception("لا يمكن حذف فئة المنتج لارتباطه ببعض المنتجات");
                }
                else
                {
                    ProductCategory productCategory = _ctx.ProductCategories.Find(Key);
                    _ctx.ProductCategories.Remove(productCategory);
                    _ctx.SaveChanges();
                }
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        public ProductCategory GetProductCategory(int Key)
        {
            return _ctx.ProductCategories.Find(Key);
        }

        public void UpdateProductCategory(ProductCategory productCategory)
        {
            _ctx.ProductCategories.Update(productCategory);
            _ctx.SaveChanges();
        }
    }
}