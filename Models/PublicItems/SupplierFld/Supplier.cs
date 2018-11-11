using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContractingCompany.Models.PublicItems.SupplierFld{
    public class Supplier
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [StringLength(200)]
        public string CompanyName { get; set; }
        [StringLength(200)]
        public int SupplierCategoryID { get; set; }
        [ForeignKey("SupplierCategoryID")]
        public SupplierCategory SupplierCategory { get; set; }
        public string Address { get; set; }
        [StringLength(100)]
        public string City { get; set; }
        [StringLength(12)]        
        public string Mobile { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        [DefaultValue(0.0)]
        [Description("يجب تجديد القيمة مع كل حركة بحيث يكون الرقم هنا هو اجمالي المديونية للمورد")]
        public decimal RemainderAmount { get; set; }
        [Description("يتم تجديد التاريخ بآخر تاريخ حركة تمت من المورد وفي حالة مردودات المشتريات يتم تعديل التاريخ ورقم المديونية بتاريخ ومديونية اخر حركة تمت")]
        public DateTime DateRemainderAmount { get; set; }
        public decimal MAXDebtAmount { get; set; }
        [DefaultValue(true)]
        [Description("في حالة حذف المورد يتم فقط تحويل القيمة ل false")]
        public bool isActive { get; set; }
    }
}