using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ContractingCompany.Models.PublicItems.EquipmentFld{
    [Description("نوع التكعيب الافتراضي للمعدة ان وجد ")]
    public class EquipmentDefaultMeasurementType
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(150)]
        public string Name { get; set; }
        public string Description { get; set; }
        
    }
}