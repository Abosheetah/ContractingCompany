using System;
using System.Linq;
using ContractingCompany.Models.CCDBContextFld;

namespace ContractingCompany.Models.PublicItems.EquipmentFld{
    public class EquipmentDefaultMeasurementTypeEF : IEquipmentDefaultMeasurementType
    {
        private CCDBContext _ctx;
        public EquipmentDefaultMeasurementTypeEF(CCDBContext ctx){
            _ctx = ctx;
        }
        public IQueryable<EquipmentDefaultMeasurementType> EquipmentDefaultMeasurementTypes => _ctx.EquipmentDefaultMeasurementTypes.AsQueryable();

        public void AddEquipmentDefaultMeasurementType(EquipmentDefaultMeasurementType equipmentDefaultMeasurementType)
        {
            _ctx.EquipmentDefaultMeasurementTypes.Add(equipmentDefaultMeasurementType);
            _ctx.SaveChanges();
        }

        public void DeleteEquipmentDefaultMeasurementType(int key)
        {
            try
            {
                bool isExist = _ctx.EquipmentDefaultMeasurementType_Equipments.Where(i=> i.EquipmentDefaultMeasurementTypeID == key).Any();
                if (isExist)
                {
                    throw new Exception("لا يمكن حذف نوع القياس الافتراضي للمعدة لارتباطه ببعض المعدات");
                }
                else
                {
                    _ctx.EquipmentDefaultMeasurementTypes.Remove(_ctx.EquipmentDefaultMeasurementTypes.Find(key));
                    _ctx.SaveChanges();
                }
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        public EquipmentDefaultMeasurementType GetEquipmentDefaultMeasurementType(int key)
        {
            return _ctx.EquipmentDefaultMeasurementTypes.Find(key);
        }

        public void UpdateEquipmentDefaultMeasurementType(EquipmentDefaultMeasurementType equipmentDefaultMeasurementType)
        {
            _ctx.EquipmentDefaultMeasurementTypes.Update(equipmentDefaultMeasurementType);
            _ctx.SaveChanges();
        }
    }
}
