using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContractingCompany.Models.Office{
    public class Career{
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public int CareerTypeID { get; set; }
        [ForeignKey("CareerTypeID")]
        public CareerType CareerType { get; set; }
        public bool? isSysUser { get; set; }
        public bool? isSysAdmin { get; set; }
        [StringLength(200)]
        public string Description { get; set; }
        
    }
}