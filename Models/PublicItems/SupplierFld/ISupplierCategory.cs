using System.Linq;

namespace ContractingCompany.Models.PublicItems.SupplierFld{
    public interface ISupplierCategory
    {
        IQueryable<SupplierCategory> SupplierCategories{get;} 
        SupplierCategory GetSupplierCategory(int Key);
        void AddSupplierCategory(SupplierCategory supplierCategory);
        void UpdateSupplierCategory(int Key);
        void DeleteSupplierCategory(int Key);

    }
}