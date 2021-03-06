using System.Linq;

namespace ContractingCompany.Models.PublicItems.SupplierFld{
    public interface ISupplierCategory
    {
        IQueryable<SupplierCategory> SupplierCategories{get;} 
        SupplierCategory GetSupplierCategory(int Key);
        void AddSupplierCategory(SupplierCategory supplierCategory);
        void UpdateSupplierCategory(SupplierCategory supplierCategory);
        void DeleteSupplierCategory(int Key);

    }
}