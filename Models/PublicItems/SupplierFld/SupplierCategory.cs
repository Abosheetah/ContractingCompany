using System.ComponentModel.DataAnnotations;

namespace ContractingCompany.Models.PublicItems.SupplierFld{
    public class SupplierCategory
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [StringLength(200)]
        public string Description { get; set; }
    }
}