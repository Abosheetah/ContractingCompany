using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ContractingCompany.Models.OperationFld.OperationGeneralDataFld;
using ContractingCompany.Models.PublicItems.EquipmentFld;

namespace ContractingCompany.Models.OperationFld.OperationEquipmentFld{
    public class OperationEquipment
    {
        [Key]
        public int ID { get; set; }
        public int OperationGeneralDataID { get; set; }
        [ForeignKey("OperationGeneralDataID")]
        public OperationGeneralData OperationGeneralData { get; set; }
        public int EquipmentID { get; set; }
        [ForeignKey("EquipmentID")]
        public Equipment Equipment { get; set; }
        public int EquipmentCalculationMethodID { get; set; }
        [ForeignKey("EquipmentCalculationMethodID")]
        public EquipmentCalculationMethod EquipmentCalculationMethod { get; set; }
        public DateTime AgreementDate { get; set; }
        public DateTime AddedDate{get;set;}
        public DateTime UpdatedDate { get; set; }
        public string Description { get; set; }
    }
}