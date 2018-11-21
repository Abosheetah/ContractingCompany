using System.Linq;

namespace ContractingCompany.Models.PublicItems.EquipmentFld{
    public interface IDependencyEquipment{
        IQueryable<DependencyEquipment> DependencyEquipments {get;} 
        DependencyEquipment GetDependencyEquipment(int Key);
        void AddDependencyEquipment(DependencyEquipment dependencyEquipment);
        void UpdateDependencyEquipment(DependencyEquipment dependencyEquipment);
        void DeleteDependencyEquipment(int Key);
    }
}
