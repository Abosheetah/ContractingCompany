using System.ComponentModel.DataAnnotations;

namespace ContractingCompany.Models.Office{
    public class CareerType{
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "Office Career Type")]
        public string Name { get; set; }
        [StringLength(200)]
        public string Description { get; set; }
    }
}