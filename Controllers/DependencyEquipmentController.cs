using ContractingCompany.Models.PublicItems.EquipmentFld;
using Microsoft.AspNetCore.Mvc;

namespace ContractingCompany.Controllers{
    public class DependencyEquipmentController : Controller{
        private IDependencyEquipment _dal;
        public DependencyEquipmentController(IDependencyEquipment dal){
            _dal= dal;
        }

        public IActionResult List() => View(_dal.DependencyEquipments);

        [HttpGet]
        public IActionResult AddDependencyEquipment(){
            return View();
        }

        [HttpPost]
        public IActionResult AddDependencyEquipment(DependencyEquipment dependencyEquipment){
            _dal.AddDependencyEquipment(dependencyEquipment);
            return  RedirectToAction(nameof(List));
        }

        [HttpGet]
        public IActionResult UpdateDependencyEquipment(int id){
            DependencyEquipment dependencyEquipment = _dal.GetDependencyEquipment(id);
            return View(dependencyEquipment);
        }

        [HttpPost]
        public IActionResult UpdateDependencyEquipment(DependencyEquipment dependencyEquipment){
            _dal.UpdateDependencyEquipment(dependencyEquipment);
            return RedirectToAction(nameof(List));
        }

        [HttpGet]
        public IActionResult DeleteDependencyEquipment(int id){
            _dal.DeleteDependencyEquipment(id);
            return RedirectToAction(nameof(List));
        }



    }
}