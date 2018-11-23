using ContractingCompany.FormsTagHelper.ViewModels;
using ContractingCompany.Models.PublicItems.EquipmentFld;
using Microsoft.AspNetCore.Mvc;

namespace ContractingCompany.Controllers{
    public class EquipmentDefaultMeasurementType_EquipmentController : Controller
    {
        private IEquipmentDefaultMeasurementType_Equipment _dal ;
        public EquipmentDefaultMeasurementType_EquipmentController(IEquipmentDefaultMeasurementType_Equipment dal){
            _dal = dal ;
        }

        public IActionResult List() => View(_dal.EDMTEs);

        public IActionResult AddEDMTE(){
            var evm = new EDMTEViewModel();
            evm.EDMTE = new EquipmentDefaultMeasurementType_Equipment();
            evm.Equipments = _dal.GetEquipmentsListItems();
            evm.EquipmentDefaultMeasurementTypes = _dal.GetDefaultMeasurementTypesListItems();
            return View(evm);
        }

        [HttpPost]
        public IActionResult AddEDMTE(EquipmentDefaultMeasurementType_Equipment edmte){
            _dal.AddEDMTE(edmte);
            return RedirectToAction(nameof(List));
        }

        [HttpGet]
        public IActionResult UpdateEDMTE(int id){
            var evm = new EDMTEViewModel();
            evm.EDMTE = _dal.GetEDMTE(id);
            evm.Equipments = _dal.GetEquipmentsListItems();
            evm.EquipmentDefaultMeasurementTypes = _dal.GetDefaultMeasurementTypesListItems();
            return View(evm);
        }

        [HttpPost]
        public IActionResult UpdateEDMTE(EquipmentDefaultMeasurementType_Equipment edmte){
            _dal.UpdateEDMTE(edmte);
            return RedirectToAction(nameof(List));
        }

        [HttpGet]
        public IActionResult DeleteEDMTE(int id){
            _dal.DeleteEDMTE(id);
            return RedirectToAction(nameof(List));
        }
        
    }
}

