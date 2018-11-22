using System.Linq;

namespace ContractingCompany.Models.PublicItems.EquipmentFld{
    public interface IEquipment{
        IQueryable<Equipment> Equipments{get;}
        Equipment GetEquipment(int key);         
        IQueryable<EquipmentType> GetEquipmentTypes();
        IQueryable<DependencyEquipment> GetDependencyEquipments();
        void AddEquipment(Equipment equipment);
        void UpdateEquipment(Equipment equipment);
        void DeleteEquipment(int key);
    }
}
