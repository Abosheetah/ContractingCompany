using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContractingCompany.Models.Office{
    public class Employee
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [StringLength(14)]
        [Range(14,14)]        
        public string NationalNumber { get; set; }
        public int CareerID { get; set; }
        [ForeignKey("CareerID")]
        public Career Career { get; set; }
        public bool Gender { get; set; }
        public decimal Salary { get; set; }
        [StringLength(200)]
        public string Description { get; set; }

    }
}