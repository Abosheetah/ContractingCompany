using System.Linq;

namespace ContractingCompany.Models.PublicItems.EquipmentFld{
    public interface IEquipmentDefaultMeasurementType
    {
        IQueryable<EquipmentDefaultMeasurementType> EquipmentDefaultMeasurementTypes {get;}
        EquipmentDefaultMeasurementType GetEquipmentDefaultMeasurementType(int key);
        void AddEquipmentDefaultMeasurementType(EquipmentDefaultMeasurementType equipmentDefaultMeasurementType);
        void UpdateEquipmentDefaultMeasurementType(EquipmentDefaultMeasurementType equipmentDefaultMeasurementType);
        void DeleteEquipmentDefaultMeasurementType(int key);
        
    }
}
