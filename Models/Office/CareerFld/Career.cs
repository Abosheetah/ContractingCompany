using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContractingCompany.Models.Office.CareerFld{
    public class Career{
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage="Career Name is Required")]
        public string Name { get; set; }
        [Required(ErrorMessage="Career Type is Required")]
        public int CareerTypeID { get; set; }
        [ForeignKey("CareerTypeID")]
        public CareerType CareerType { get; set; }        
        public bool isSysUser { get; set; } = false;
        public bool isSysAdmin { get; set; } = false;
        [StringLength(200)]
        public string Description { get; set; }
        
    }
}