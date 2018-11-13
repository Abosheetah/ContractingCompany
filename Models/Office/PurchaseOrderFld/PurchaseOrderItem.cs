using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ContractingCompany.Models.PublicItems.ProductFld;

namespace ContractingCompany.Models.Office.PurchaseOrderFld{
    public class PurchaseOrderItem
    {
        [Key]
        public int ID { get; set; }
        public int PurchaseOrderID { get; set; }
        [ForeignKey("PurchaseOrderID")]
        public PurchaseOrder PurchaseOrder { get; set; }
        public int ProductID { get; set; }
        [ForeignKey("ProductID")]       
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal Discount { get; set; }
    }
}