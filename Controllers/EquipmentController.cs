
using ContractingCompany.FormsTagHelper.ViewModels;
using ContractingCompany.Models.PublicItems.EquipmentFld;
using Microsoft.AspNetCore.Mvc;

namespace ContractingCompany.Controllers{
    public class EquipmentController : Controller{
        private IEquipment _dal;
        public EquipmentController(IEquipment dal){
            _dal = dal;
        }
        public IActionResult List() => View(_dal.Equipments);

        public IActionResult AddEquipment(){
            var evm = new EquipmentViewModel();
           // evm.Equipment = new Equipment();
           return View();
        }

    }
}
