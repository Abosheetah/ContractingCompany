using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ContractingCompany.Models.OperationFld.OperationCareerFld;
using ContractingCompany.Models.OperationFld.OperationGeneralDataFld;

namespace ContractingCompany.Models.OperationFld.WorkTimeFld{
    [Description("المفروض يتم حساب عمل كل الموظفين في العملية بالساعات او ايا كان المهم حساب العمل يوم بيوم علشان الراتب وخلافه")]
    public class OperationWorkTime
    {
        [Key]
        public int ID { get; set; }
        public int OperationGeneralDataID { get; set; }
        [ForeignKey("OperationGeneralDataID")]
        public OperationGeneralData OperationGeneralData { get; set; }
        public int OperationCareerID { get; set; }
        [ForeignKey("OperationCareerID")]
        public OperationCareer OperationCareer { get; set; }
        public int OperationEmployeeID { get; set; }
        [ForeignKey("OperationEmployeeID")]
        public OperationEmployee OperationEmployee { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string Description { get; set; }

    }
}