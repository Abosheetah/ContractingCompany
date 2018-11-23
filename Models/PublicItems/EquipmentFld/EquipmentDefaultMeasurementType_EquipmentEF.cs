using System.Collections.Generic;
using System.Linq;
using ContractingCompany.Models.CCDBContextFld;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace ContractingCompany.Models.PublicItems.EquipmentFld{
    public class EquipmentDefaultMeasurementType_EquipmentEF : IEquipmentDefaultMeasurementType_Equipment
    {
        private CCDBContext _ctx;
        public EquipmentDefaultMeasurementType_EquipmentEF(CCDBContext ctx){
            _ctx = ctx;
        }
        public IQueryable<EquipmentDefaultMeasurementType_Equipment> EDMTEs => _ctx.EquipmentDefaultMeasurementType_Equipments.Include(i => i.Equipment).Include(ii=> ii.EquipmentDefaultMeasurementType).AsQueryable();

        public void AddEDMTE(EquipmentDefaultMeasurementType_Equipment EDMTE)
        {
            _ctx.EquipmentDefaultMeasurementType_Equipments.Add(EDMTE);
            _ctx.SaveChanges();
        }

        public void DeleteEDMTE(int key)
        {
            _ctx.EquipmentDefaultMeasurementType_Equipments.Remove(GetEDMTE(key));
            _ctx.SaveChanges();
        }

        public IQueryable<EquipmentDefaultMeasurementType> GetDefaultMeasurementTypes()
        {
            return _ctx.EquipmentDefaultMeasurementTypes;
        }

        public List<SelectListItem> GetDefaultMeasurementTypesListItems(){
            return _ctx.EquipmentDefaultMeasurementTypes.Select(i=> new SelectListItem() { Value = i.ID.ToString() , Text = i.Name}).ToList();
        }

        public EquipmentDefaultMeasurementType_Equipment GetEDMTE(int key)
        {
            return _ctx.EquipmentDefaultMeasurementType_Equipments.Find(key);
        }

        public IQueryable<Equipment> GetEquipments()
        {
            return _ctx.Equipments.Where(i=> i.isActive == true);
        }

        public List<SelectListItem> GetEquipmentsListItems(){
             return _ctx.Equipments.Select(i=> new SelectListItem(){Value = i.ID.ToString() , Text = i.Name}).ToList();
        }

        public void UpdateEDMTE(EquipmentDefaultMeasurementType_Equipment EDMTE)
        {
            _ctx.EquipmentDefaultMeasurementType_Equipments.Update(EDMTE);
            _ctx.SaveChanges();
        }
    }
}

