using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ContractingCompany.Models.PublicItems.EquipmentFld{
    [Description("EquipmentDefaultMeasurementType_Equipment")]
    public interface IEquipmentDefaultMeasurementType_Equipment
    {
        IQueryable<EquipmentDefaultMeasurementType_Equipment> EDMTEs {get;}
        EquipmentDefaultMeasurementType_Equipment GetEDMTE(int key);
        IQueryable<Equipment> GetEquipments();
        List<SelectListItem> GetEquipmentsListItems();
        IQueryable<EquipmentDefaultMeasurementType> GetDefaultMeasurementTypes();
        List<SelectListItem> GetDefaultMeasurementTypesListItems();
        void AddEDMTE(EquipmentDefaultMeasurementType_Equipment EDMTE);
        void UpdateEDMTE(EquipmentDefaultMeasurementType_Equipment EDMTE);
        void DeleteEDMTE(int key);
    }
}
