using System.Linq;

namespace ContractingCompany.Models.PublicItems.SupplierFld{
    public interface ISupplierRepo
    {
        IQueryable<Supplier> Suppliers {get;}
        void AddSupplier(Supplier supplier);
        void UpdateSupplier(int key);
    }
}