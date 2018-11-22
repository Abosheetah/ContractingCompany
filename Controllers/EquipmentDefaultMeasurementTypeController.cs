using ContractingCompany.Models.PublicItems.EquipmentFld;
using Microsoft.AspNetCore.Mvc;

namespace ContractingCompany.Controllers{
   public class EquipmentDefaultMeasurementTypeController : Controller
   {
        private IEquipmentDefaultMeasurementType _dal;
        public EquipmentDefaultMeasurementTypeController(IEquipmentDefaultMeasurementType dal){
            _dal = dal;
        }

        public IActionResult List() => View(_dal.EquipmentDefaultMeasurementTypes);
        public IActionResult AddEquipmentDefaultMeasurementType() => View();

        [HttpPost]
        public IActionResult AddEquipmentDefaultMeasurementType(EquipmentDefaultMeasurementType equipmentDefaultMeasurementType){
            _dal.AddEquipmentDefaultMeasurementType(equipmentDefaultMeasurementType);
            return RedirectToAction(nameof(List));
        }

        public IActionResult UpdateEquipmentDefaultMeasurementType(int id) => View(_dal.GetEquipmentDefaultMeasurementType(id));

        [HttpPost]
        public IActionResult UpdateEquipmentDefaultMeasurementType(EquipmentDefaultMeasurementType equipmentDefaultMeasurementType){
            _dal.UpdateEquipmentDefaultMeasurementType(equipmentDefaultMeasurementType);
            return RedirectToAction(nameof(List));
        }

        public IActionResult DeleteEquipmentDefaultMeasurementType(int id){
            _dal.DeleteEquipmentDefaultMeasurementType(id);
            return RedirectToAction(nameof(List));
        }
   } 
}
