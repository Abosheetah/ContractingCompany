using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ContractingCompany.Models.PublicItems.ProductFld;

namespace ContractingCompany.Models.Office.OfficeRepositoryFld{
    public class OfficeRepository
    {
        [Key]
        public int ID { get; set; }
        public int ProductID { get; set; }
        [ForeignKey("ProductID")]
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdatedDate { get; set; }


    }
}