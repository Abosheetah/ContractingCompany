using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContractingCompany.Models.OperationFld.OperationCareerFld{
    [Description("جدول بيانات موظفين العمليات")]
    public class OperationEmployee
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(150)]
        public string Name { get; set; }
        public string Address { get; set; }
        public decimal? Salary { get; set; }
        public int OperationCareerID { get; set; }
        [ForeignKey("OperationCareerID")]
        public OperationCareer OperationCareer { get; set; }


    }
}