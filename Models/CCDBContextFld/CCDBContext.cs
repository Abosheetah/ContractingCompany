using ContractingCompany.Models.Office.CareerFld;
using ContractingCompany.Models.Office.EmployeeFld;
using ContractingCompany.Models.Office.OfficeRepositoryFld;
using ContractingCompany.Models.Office.PurchaseOrderFld;
using ContractingCompany.Models.PublicItems.ProductFld;
using ContractingCompany.Models.PublicItems.SupplierFld;
using ContractingCompany.Models.PublicItems.EquipmentFld;
using Microsoft.EntityFrameworkCore;
using ContractingCompany.Models.OperationFld.OperationCareerFld;
using ContractingCompany.Models.OperationFld.OperationEquipmentFld;
using ContractingCompany.Models.OperationFld.OperationGeneralDataFld;
using ContractingCompany.Models.OperationFld.WorkTimeFld;
using System;

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

            //Equipment Default Measurement Type
            modelBuilder.Entity<EquipmentDefaultMeasurementType>().HasData(
                new EquipmentDefaultMeasurementType{ID = 1 , Name ="متر مكعب",Description = "يتم الحساب على قياس المتر المكعب"},
                new EquipmentDefaultMeasurementType{ID = 2 ,Name = "بالارتفاع" ,Description = ""}
            );
            //Operation Career
            modelBuilder.Entity<OperationCareer>().HasData(
                new OperationCareer{ID = 1 , Name = "سائق بلدوزر",isSysSubAdmin = false , isSysSubUser = false , Description ="يعمل على البلدوزر بشكل أساسي"},
                new OperationCareer {ID =  2 ,Name = "تباع",isSysSubAdmin = false  , isSysSubUser =false  , Description = "تباع" },
                new OperationCareer {ID = 3 , Name = "محاسب عملية ",isSysSubAdmin = true , isSysSubUser = true , Description="مخول له ادارة حسابات العملية والتسجيل على الكمبيوتر"});
            
            //Operation Employees
            modelBuilder.Entity<OperationEmployee>().HasData(
                new OperationEmployee{ID = 1 , OperationCareerID = 2 , Name = "محمود سلامة النويجع" , Address = "مدينة نصر" , Salary = 5600 },
                new OperationEmployee{ID = 2 , OperationCareerID = 3 , Name = "تامر كمال المحمودي" , Address = "مدينة نصر" , Salary = 3500 }
            );

            //Equipment Calculation Methods
            modelBuilder.Entity<EquipmentCalculationMethod>().HasData(
                new EquipmentCalculationMethod{ID = 1 , Name = "بالمتر" , Description = "بالمتر المكعب"},
                new EquipmentCalculationMethod {ID = 2 , Name = "بالساعة"  ,  Description ="قياس بالساعة الانتاجية"}
            );

            //Operation Equipment
            modelBuilder.Entity<OperationEquipment>().HasData(
                new OperationEquipment{ID = 1,EquipmentCalculationMethodID = 1 , EquipmentID = 2 , OperationGeneralDataID  = 1 ,AgreementDate = DateTime.Now.Date, AddedDate =DateTime.Now.Date , UpdatedDate = DateTime.Now.Date , Description = ""},
                new OperationEquipment{ID = 2,EquipmentCalculationMethodID = 2 , EquipmentID = 1 , OperationGeneralDataID  = 1 ,AgreementDate = DateTime.Now.Date, AddedDate =DateTime.Now.Date , UpdatedDate = DateTime.Now.Date , Description = ""}
            );

            //Operation General Data
            modelBuilder.Entity<OperationGeneralData>().HasData(
                new OperationGeneralData{ID = 1 , Name ="عملية رأس البر", StartDate = DateTime.Now.Date ,Location = "رأس البر" ,Description = "" }
            );

            //Product Category
            modelBuilder.Entity<ProductCategory>().HasData(
                new ProductCategory{ID = 1 , Name = "زيوت" , Description = "مثال زيت معدة البلدوزر"},
                new ProductCategory{ID = 2 , Name = "قطع غيار" , Description = "قطع غيار معدات"},
                new ProductCategory{ID = 3 , Name = "هياكل"}
            );

            //product
            modelBuilder.Entity<Product>().HasData(
                new Product{ID = 1 , Name = "سكاترة لودر 506" ,  Code = "123" , Barcode = "123" , DefaultSupplierID = 1 , ProductCategoryID = 1 , ProductionCompanyName = "SSTDF" ,PurchasePrice = 5630 , Description = "Nothing" },

                 new Product{ID = 2 , Name = "سكاترة لودر 59" ,  Code = "456" , Barcode = "456" , DefaultSupplierID = 1 , ProductCategoryID = 1 , ProductionCompanyName = "SSTDF" ,PurchasePrice = 15230 , Description = "Nothing" }
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
            public DbSet<EquipmentType> EquipmentTypes {get;set;} 
            public DbSet<EquipmentDefaultMeasurementType> EquipmentDefaultMeasurementTypes {get;set;}
            public DbSet<DependencyEquipment> DependencyEquipments {get;set;}
            public DbSet<EquipmentDefaultMeasurementType_Equipment> EquipmentDefaultMeasurementType_Equipments {get;set;}
            public DbSet<Equipment> Equipments {get;set;}
        #endregion
        #region Operation
            public DbSet<OperationCareer> OperationCareers {get;set;}
            public DbSet<OperationEmployee> OperationEmployees {get;set;}
            public DbSet<EquipmentCalculationMethod> EquipmentCalculationMethods {get;set;}
            public DbSet<OperationEquipment> OperationEquipments {get;set;}
            public DbSet<OperationGeneralData> OperationGeneralDatas {get;set;}
            public DbSet<OperationWorkTime> OperationWorkTimes {get;set;}

        #endregion
        


    }
}