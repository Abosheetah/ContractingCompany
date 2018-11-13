using ContractingCompany.Models.Office.CareerFld;
using ContractingCompany.Models.Office.EmployeeFld;
using ContractingCompany.Models.Office.OfficeRepositoryFld;
using ContractingCompany.Models.Office.PurchaseOrderFld;
using ContractingCompany.Models.PublicItems.ProductFld;
using ContractingCompany.Models.PublicItems.SupplierFld;
using ContractingCompany.Models.PublicItems.EquipmentFld;
using Microsoft.EntityFrameworkCore;

namespace ContractingCompany.Models.CCDBContextFld{
    public class CCDBContext : DbContext
    {
        public CCDBContext(DbContextOptions<CCDBContext> options) : base(options){}
        protected override void OnModelCreating(ModelBuilder modelBuilder){
            //seed data          

            //Career Type
            modelBuilder.Entity<CareerType>().HasData(
                new CareerType {ID = 1 , Name = "رئيس مجلس إدارة" , Description = "رئيس مجلس إدارة"},
                new CareerType {ID = 2 , Name = "محاسب" , Description = "محاسب"},
                new CareerType {ID = 3 , Name = "عامل بوفيه" , Description = "عامل بوفيه"});
           
            //Career
            modelBuilder.Entity<Career>().HasData(
                new Career{ID = 1, Name = "رئيس مجلس الإدارة" , CareerTypeID = 1 , isSysAdmin = true , isSysUser = true , Description =""},
                new Career{ID = 2, Name = "محاسب" , CareerTypeID = 1 , isSysAdmin = true , isSysUser = true , Description =""},
                new Career{ID = 3, Name = "عامل بوفيه" , CareerTypeID = 1 , isSysAdmin = false , isSysUser = false , Description =""});
            
            //Employee
            modelBuilder.Entity<Employee>().HasData(
                new Employee{ID = 1 , Name = "أسامة محمود" , Gender = true , isProcurementOfficials = true , CareerID = 2 , NationalNumber = "12345678912345" ,Salary  = 5000 , Description ="Nothing"},
                new Employee{ID = 2 , Name = "قاسم سلامة القيعي" , Gender = true , isProcurementOfficials = false , CareerID = 3 , NationalNumber = "12345678912345" ,Salary  = 1500 , Description ="Nothing"});
             
             //Supplier Category
             modelBuilder.Entity<SupplierCategory>().HasData(
                new SupplierCategory{ID = 1 , Name = "مورد دائم",Description = "مورد يعمل لدينا بصفة دائمة"},
                new SupplierCategory{ID = 2 , Name = "مورد ثقة",Description = "من الممكن تصفية الحساب بين الشركة وبين المورد بصفة شهرية"});
            
            //Supplier
            modelBuilder.Entity<Supplier>().HasData(
                new Supplier{ID = 1 , SupplierCategoryID = 1 , Name ="محمد احمد ماهر", City = "مدينة نصر", CompanyName ="شركة الغزال للتوريد" , Address = "الحرفيين" ,isActive = true , Mobile = "01060322354" , RemainderAmount = 52000  },
                new Supplier{ID = 2 , SupplierCategoryID = 2 , Name ="سلامة سالم مسلم", City = "مدينة نصر", CompanyName ="شركة السلامة للتوريد" , Address = "الحرفيين" ,isActive = true , Mobile = "01060322354" , RemainderAmount = 16250  });

            //Equipment Types
            modelBuilder.Entity<EquipmentType>().HasData(
                new EquipmentType{ID = 1 , Name = "حفار" , Description = "حفار بالرافع والتللير"},
                new EquipmentType{ID = 2 , Name = "بالدوزر",Description = "وسف بالقائمة"}
            );

            // Dependency Equipment
            modelBuilder.Entity<DependencyEquipment>().HasData(
                new DependencyEquipment{ID = 1 , Name = "كاتر بلر", Description = ""}
            );

            //Equipment
            modelBuilder.Entity<Equipment>().HasData(
                new Equipment{ID = 1 , Name = "AX25 BU" , Code = "123456" , Barcode = "123456" , DependencyID = 1 ,EquipmentTypeID = 1 , Model = "2010" , ChassisNo ="125543"},
                new Equipment{ID = 2 , Name = "MRT98 FGH" , Code = "123456" , Barcode = "123456" , DependencyID = 1 ,EquipmentTypeID = 2 , Model = "1998" , ChassisNo ="125543"}
            );

            modelBuilder.Entity<EquipmentDefaultMeasurementType>().HasData(
                new EquipmentDefaultMeasurementType{ID = 1 , Name ="متر مكعب",Description = "يتم الحساب على قياس المتر المكعب"},
                new EquipmentDefaultMeasurementType{ID = 2 ,Name = "بالارتفاع" ,Description = ""}
            );
        }                


        #region Career
           public DbSet<CareerType> CareerTypes {get;set;}
        public DbSet<Career> Careers {get;set;} 
        #endregion        
        #region Employee
            public DbSet<Employee> Employees {get;set;}
        #endregion
        #region OfficeRepositories
           public DbSet<OfficeRepository> OfficeRepositories{get;set;} 
        #endregion
        #region PurchaseOrders
            public DbSet<PurchaseOrder> PurchaseOrders {get;set;}
            public DbSet<PurchaseOrderItem> PurchaseOrderItems {get;set;}
        #endregion
        #region Product
           public DbSet<ProductCategory> ProductCategories{get;set;}
            public DbSet<Product> Products{get;set;} 
        #endregion
        #region Supplier
           public DbSet<SupplierCategory> SupplierCategories{get;set;}
            public DbSet<Supplier> Suppliers {get;set;} 
        #endregion        
        #region Equipment
            DbSet<EquipmentType> EquipmentTypes {get;set;} 
            DbSet<EquipmentDefaultMeasurementType> EquipmentDefaultMeasurementTypes {get;set;}
            DbSet<DependencyEquipment> DependencyEquipments {get;set;}
            DbSet<EquipmentDefaultMeasurementType_Equipment> EquipmentDefaultMeasurementType_Equipments {get;set;}
            DbSet<Equipment> Equipments {get;set;}
        #endregion
        


    }
}