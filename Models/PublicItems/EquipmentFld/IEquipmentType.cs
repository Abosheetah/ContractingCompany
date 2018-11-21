using System.Linq;

namespace ContractingCompany.Models.PublicItems.EquipmentFld{
    public interface IEquipmentType
    {
        IQueryable<EquipmentType> EquipmentTypes {get;}
        EquipmentType GetEquipmentType(int Key);
        void AddEquipmentType(EquipmentType equipmentType);
        void UpdateEquipmentType(EquipmentType equipmentType);
        void DeleteEquipmentType(int Key);
    }
}
