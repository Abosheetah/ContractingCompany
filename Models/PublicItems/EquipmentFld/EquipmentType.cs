using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ContractingCompany.Models.PublicItems.EquipmentFld{
    [Description("نوع المعدة اي هل حفار او بالدوزر او خلافه")]
    public class EquipmentType
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(150)]
        public string Name { get; set; }
        public string Description { get; set; }

    }
}