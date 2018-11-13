using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContractingCompany.Models.PublicItems.EquipmentFld{
    [Description("في هذا الجدول : قد يكون هناك لبعض المعدات تعكيب وقياس معين وافتراضي يتم تحديد المعدة ويتم تحديد نوع التكعيب ومن ثم نقوم بتسجيل قيمة المقياس بالارقام مثل في حالة ان التكعيب بالمتر نكتب هنا ان تكعيب المعدة س 8 متر وهكذا")]
    public class EquipmentDefaultMeasurementType_Equipment
    {
        [Key]
        public int ID { get; set; }        
        public int EquipmentID { get; set; }
        [ForeignKey("EquipmentID")]
        public Equipment Equipment { get; set; }        
        public int EquipmentDefaultMeasurementTypeID { get; set; }
        [ForeignKey("EquipmentDefaultMeasurementTypeID")]
        public EquipmentDefaultMeasurementType EquipmentDefaultMeasurementType { get; set; }
        [Required]
        [StringLength(150)]
        public string MeasureName { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}