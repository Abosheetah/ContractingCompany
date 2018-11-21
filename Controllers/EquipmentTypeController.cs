using ContractingCompany.Models.PublicItems.EquipmentFld;
using Microsoft.AspNetCore.Mvc;

namespace ContractingCompany.Controllers{
    public class EquipmentTypeController : Controller 
    {
        private IEquipmentType _dal;
        public EquipmentTypeController(IEquipmentType dal){
            _dal = dal;
        }
        public IActionResult List() => View(_dal.EquipmentTypes);

        public IActionResult AddEquipmentType(){
            return View();
        }

        [HttpPost]
        public IActionResult AddEquipmentType(EquipmentType equipmentType){
            _dal.AddEquipmentType(equipmentType);
            return RedirectToAction(nameof(List));
        }

        [HttpGet]
        public IActionResult UpdateEquipmentType(int id){
            EquipmentType equipmentType = _dal.GetEquipmentType(id);
            return View(equipmentType);
        }

        [HttpPost]
        public IActionResult UpdateEquipmentType(EquipmentType equipmentType){
            _dal.UpdateEquipmentType(equipmentType);
            return RedirectToAction(nameof(List));
        }


        public IActionResult DeleteEquipmentType(int id){
            _dal.DeleteEquipmentType(id);
            return RedirectToAction(nameof(List));

        }


    }
}