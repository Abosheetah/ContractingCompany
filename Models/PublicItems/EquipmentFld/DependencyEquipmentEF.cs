using System;
using System.Linq;
using ContractingCompany.Models.CCDBContextFld;

namespace ContractingCompany.Models.PublicItems.EquipmentFld{
    public class DependencyEquipmentEF : IDependencyEquipment
    {
        private CCDBContext _ctx;
        public DependencyEquipmentEF(CCDBContext ctx){
            _ctx =  ctx;
        }
        public IQueryable<DependencyEquipment> DependencyEquipments => _ctx.DependencyEquipments.AsQueryable();

        public void AddDependencyEquipment(DependencyEquipment dependencyEquipment)
        {
            _ctx.DependencyEquipments.Add(dependencyEquipment);
            _ctx.SaveChanges();
        }

        public void DeleteDependencyEquipment(int key)
        {
            try
            {
                bool isExist = _ctx.Equipments.Where(i=> i.DependencyID == key).Any();
                if (isExist)
                {
                    throw new Exception("لا يمكن حذف تبعية المعدة لارتباطها ببعض المعدات");                    
                }
                else
                {
                    _ctx.DependencyEquipments.Remove(_ctx.DependencyEquipments.Find(key));
                    _ctx.SaveChanges();
                }
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        public DependencyEquipment GetDependencyEquipment(int key)
        {
            return _ctx.DependencyEquipments.Find(key);
        }

        public void UpdateDependencyEquipment(DependencyEquipment dependencyEquipment)
        {
            _ctx.DependencyEquipments.Update(dependencyEquipment);
            _ctx.SaveChanges();
        }
    }
}
