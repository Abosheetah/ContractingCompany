using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ContractingCompany.Models.PublicItems.SupplierFld;
namespace ContractingCompany.Models.PublicItems.ProductFld{
    public class Product
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [StringLength(10)]
        public string Code { get; set; }
        [StringLength(10)]
        public string Barcode { get; set; }
        public string ProductionCompanyName { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int ProductCategoryID { get; set; }
        [ForeignKey("ProductCategoryID")]
        public ProductCategory ProductCategory { get; set; }
        public int DefaultSupplierID { get; set; }
        [ForeignKey("DefaultSupplierID")]
        public Supplier Supplier { get; set; }
        [StringLength(200)]
        public string Description { get; set; }
    }
}