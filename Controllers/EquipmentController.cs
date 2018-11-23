
using System.Linq;
using ContractingCompany.FormsTagHelper.ViewModels;
using ContractingCompany.Models.PublicItems.EquipmentFld;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ContractingCompany.Controllers{
    public class EquipmentController : Controller{
        private IEquipment _dal;
        public EquipmentController(IEquipment dal){
            _dal = dal;
        }
        public IActionResult List() => View(_dal.Equipments);

        public IActionResult AddEquipment(){
            var evm = new EquipmentViewModel();
            evm.Equipment = new Equipment();
            evm.DependencyEquipments = _dal.GetDependencyEquipments().Select(i=> new SelectListItem(){Value = i.ID.ToString(),Text=i.Name}).ToList();
            evm.EquipmentTypes = _dal.GetEquipmentTypes().Select(i=> new SelectListItem() {Value = i.ID.ToString() , Text = i.Name}).ToList();
           return View(evm);
           
        }

        [HttpPost]
        public IActionResult AddEquipment(Equipment equipment){
            _dal.AddEquipment(equipment);
            return RedirectToAction(nameof(List));
        }

         public IActionResult  UpdateEquipment(int id){
            var evm = new EquipmentViewModel();
            evm.Equipment = _dal.GetEquipment(id);
            evm.DependencyEquipments = _dal.GetDependencyEquipments().Select(i=> new SelectListItem(){Value = i.ID.ToString(),Text=i.Name}).ToList();
            evm.EquipmentTypes = _dal.GetEquipmentTypes().Select(i=> new SelectListItem() {Value = i.ID.ToString() , Text = i.Name}).ToList();
           return View(evm);
        }

        [HttpPost]
        public IActionResult UpdateEquipment(Equipment equipment){
            _dal.UpdateEquipment(equipment);
            return RedirectToAction(nameof(List));
        }

        public IActionResult DeleteEquipment(int id){
            _dal.DeleteEquipment(id);
            return RedirectToAction(nameof(List));
        }

    }
}
