using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ContractingCompany.Models.OperationFld.OperationCareerFld{
    [Description("جدول لحصر الوظائف والأعمال داخل العمليات والتي تخص العمليات فقط")]
    public class OperationCareer
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(150)]
        public string Name { get; set; }
        public bool isSysSubUser { get; set; }
        public bool isSysSubAdmin { get; set; }
        public string Description { get; set; }
    }

}