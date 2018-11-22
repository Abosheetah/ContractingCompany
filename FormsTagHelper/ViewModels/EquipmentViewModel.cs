using System.Collections.Generic;
using ContractingCompany.Models.PublicItems.EquipmentFld;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ContractingCompany.FormsTagHelper.ViewModels{
    public class EquipmentViewModel{
        public Equipment Equipment;
        public List<SelectListItem> EquipmentTypes;
        public List<SelectListItem> DependencyEquipments;

    }
}
