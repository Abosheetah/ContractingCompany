using System.Linq;
using ContractingCompany.Models.PublicItems.SupplierFld;

namespace ContractingCompany.Models.PublicItems.ProductFld{
    public interface IProduct{
        IQueryable<Product> Products {get;}
        IQueryable<ProductCategory> ProductCategories {get;}
        IQueryable<Supplier> Suppliers {get;}
        
        Product GetProduct(int Key);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int Key);


    }
}
