using System;
using System.Linq;
using ContractingCompany.Models.CCDBContextFld;

namespace ContractingCompany.Models.PublicItems.EquipmentFld{
    public class EquipmentTypeEF : IEquipmentType
    {
        private CCDBContext _ctx ;
        public EquipmentTypeEF (CCDBContext ctx){
            _ctx = ctx;
        }
        public IQueryable<EquipmentType> EquipmentTypes => _ctx.EquipmentTypes.AsQueryable();
        public void AddEquipmentType(EquipmentType equipmentType)
        {
            _ctx.EquipmentTypes.Add(equipmentType);
            _ctx.SaveChanges();
        }

        public void DeleteEquipmentType(int Key)
        {
            try
            {
                bool isExist = _ctx.Equipments.Where(i=> i.EquipmentTypeID == Key).Any();
                if (isExist)
                {
                    throw new Exception("لا يمكن حذف نوع المعدة لارتباطه ببعض المعدات");                    
                }
                else
                {
                    _ctx.EquipmentTypes.Remove(_ctx.EquipmentTypes.Find(Key));
                    _ctx.SaveChanges();
                }
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        public EquipmentType GetEquipmentType(int Key)
        {
            EquipmentType equipmentType = _ctx.EquipmentTypes.Find(Key);
            return equipmentType ;
        }

        public void UpdateEquipmentType(EquipmentType equipmentType)
        {
            _ctx.EquipmentTypes.Update(equipmentType);
            _ctx.SaveChanges();
        }
    }
}
