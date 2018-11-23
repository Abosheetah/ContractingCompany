using System.Collections.Generic;
using ContractingCompany.Models.PublicItems.EquipmentFld;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ContractingCompany.FormsTagHelper.ViewModels{
    public class EDMTEViewModel
    {
        public EquipmentDefaultMeasurementType_Equipment EDMTE ;
        public List<SelectListItem> Equipments ;
        public List<SelectListItem> EquipmentDefaultMeasurementTypes ;
    }
}
