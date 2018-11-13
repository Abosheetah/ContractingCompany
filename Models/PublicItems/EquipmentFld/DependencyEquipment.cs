using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ContractingCompany.Models.PublicItems.EquipmentFld{
    [Description("تبعية المعدة : اي لأي شركة تابعة أو لأي علامة تجاري تابعة المعدة")]
    public class DependencyEquipment
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(150)]
        public string Name { get; set; }
        public string Description { get; set; }
        
    }
}