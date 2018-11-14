using System.ComponentModel.DataAnnotations;

namespace ContractingCompany.Models.OperationFld.OperationEquipmentFld{
    public class EquipmentCalculationMethod
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(150)]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}