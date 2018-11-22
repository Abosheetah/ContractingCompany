using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContractingCompany.Models.PublicItems.EquipmentFld{
    public class Equipment
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(150)]
        public string Name { get; set; }
        public int EquipmentTypeID { get; set; }
        [ForeignKey("EquipmentTypeID")]
        public EquipmentType EquipmentType { get; set; }
        public int DependencyID { get; set; }
        [ForeignKey("DependencyID")]
        public DependencyEquipment DependencyEquipment { get; set; }
        [StringLength(20)]
        public string Code { get; set; }
        [StringLength(20)]
        public string Barcode { get; set; }
        [StringLength(50)]
        public string Model { get; set; }
        [StringLength(20)]
        public string ChassisNo { get; set; }
        public bool isActive{get;set;} = true;
    }
}