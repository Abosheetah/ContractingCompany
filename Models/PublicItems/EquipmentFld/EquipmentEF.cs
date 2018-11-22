using System;
using System.Linq;
using ContractingCompany.Models.CCDBContextFld;

namespace ContractingCompany.Models.PublicItems.EquipmentFld{
    public class EquipmentEF : IEquipment
    {
        private CCDBContext _ctx ;
        public EquipmentEF(CCDBContext ctx){
            _ctx = ctx;
        }
        public IQueryable<Equipment> Equipments => _ctx.Equipments.AsQueryable();

        public void AddEquipment(Equipment equipment)
        {
            _ctx.Equipments.Add(equipment);
        }

        public void DeleteEquipment(int key)
        {
            try
            {
                bool isExist = _ctx.EquipmentDefaultMeasurementType_Equipments.Where(i=> i.EquipmentID == key).Any();
                if (isExist)
                {
                    throw new Exception("لا يمكن حذف المعدة لارتباطها ببعض العمليات");
                }
                else
                {
                    _ctx.Equipments.Remove(_ctx.Equipments.Find(key));
                    _ctx.SaveChanges();
                }
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }
        
        public Equipment GetEquipment(int key)
        {
            return _ctx.Equipments.Find(key);
        }

        public void UpdateEquipment(Equipment equipment)
        {
            _ctx.Equipments.Update(equipment);
            _ctx.SaveChanges();
        }
    }
}
