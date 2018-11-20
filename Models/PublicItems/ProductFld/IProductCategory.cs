using System.Linq;

namespace ContractingCompany.Models.PublicItems.ProductFld{
    public interface IProductCategory
    {
        IQueryable<ProductCategory>  ProductCategories {get;}
        ProductCategory GetProductCategory(int Key);
        void AddProductCategory(ProductCategory productCategory);
        void UpdateProductCategory(ProductCategory productCategory);
        void DeleteProductCategory(int Key);
    }
}