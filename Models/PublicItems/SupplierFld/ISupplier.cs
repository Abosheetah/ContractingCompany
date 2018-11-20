using System.Linq;

namespace ContractingCompany.Models.PublicItems.SupplierFld{
    public interface ISupplier
    {
        IQueryable<Supplier> Suppliers {get;}
        IQueryable<SupplierCategory> SupplierCategories {get;}
        Supplier GetSupplier(int Key);        
        void AddSupplier(Supplier supplier);
        void UpdateSupplier(Supplier supplier);
        void DeleteSupplier(int Key);

    }
}