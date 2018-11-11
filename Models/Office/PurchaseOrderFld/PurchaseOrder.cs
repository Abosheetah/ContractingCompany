using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ContractingCompany.Models.Office.EmployeeFld;
using ContractingCompany.Models.PublicItems.SupplierFld;

namespace ContractingCompany.Models.Office.PurchaseOrderFld{
    public class PurchaseOrder
    {
        [Key]
        public int ID { get; set; }
        public int SupplierID { get; set; }
        [ForeignKey("SupplierID")]
        public Supplier Supplier { get; set; }
        public OrderStatus OrderStatusType { get; set; }
        public int EmployeeID { get; set; }
        [ForeignKey("EmployeeID")]
        public Employee Employee { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime AddedDate {get{return DateTime.Now.Date;} set{}}
        [StringLength(200)]
        public string Description { get; set; }
    

    }

    public enum OrderStatus
    {
        Cash = 0,
        Delay = 1
    }
}