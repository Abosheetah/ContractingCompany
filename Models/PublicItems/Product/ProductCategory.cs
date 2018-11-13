using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ContractingCompany.Models.PublicItems.Product{
    public class ProductCategory
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Description("Product Category Name")]
        public string Name { get; set; }
        [StringLength(200)]
        public string  Description { get; set; }
    }
}