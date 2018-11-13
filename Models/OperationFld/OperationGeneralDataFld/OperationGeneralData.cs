using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ContractingCompany.Models.OperationFld.OperationGeneralDataFld{
    [Description("جدول البيانات العامة لكل عملية")]
    public class OperationGeneralData
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(150)]
        public string Name { get; set; }
        public string Location { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
    }
}