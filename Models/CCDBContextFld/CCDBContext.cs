using ContractingCompany.Models.Office.CareerFld;
using ContractingCompany.Models.Office.EmployeeFld;
using ContractingCompany.Models.Office.OfficeRepositoryFld;
using ContractingCompany.Models.Office.PurchaseOrderFld;
using Microsoft.EntityFrameworkCore;

namespace ContractingCompany.Models.CCDBContextFld{
    public class CCDBContext : DbContext
    {
        public CCDBContext(DbContextOptions<CCDBContext> options) : base(options){}
        protected override void OnModelCreating(ModelBuilder modelBuilder){
            //seed data          

            modelBuilder.Entity<CareerType>().HasData(
                new CareerType {ID = 1 , Name = "رئيس مجلس إدارة" , Description = "رئيس مجلس إدارة"},
                new CareerType {ID = 2 , Name = "محاسب" , Description = "محاسب"},
                new CareerType {ID = 3 , Name = "عامل بوفيه" , Description = "عامل بوفيه"});

            modelBuilder.Entity<Career>().HasData(
                new Career{ID = 1, Name = "رئيس مجلس الإدارة" , CareerTypeID = 1 , isSysAdmin = true , isSysUser = true , Description =""},
                new Career{ID = 2, Name = "محاسب" , CareerTypeID = 1 , isSysAdmin = true , isSysUser = true , Description =""},
                new Career{ID = 3, Name = "عامل بوفيه" , CareerTypeID = 1 , isSysAdmin = false , isSysUser = false , Description =""});
            modelBuilder.Entity<Employee>().HasData(
                new Employee{ID = 1 , Name = "أسامة محمود" , Gender = true , isProcurementOfficials = true , CareerID = 2 , NationalNumber = "12345678912345" ,Salary  = 5000 , Description ="Nothing"},
                
                new Employee{ID = 2 , Name = "قاسم سلامة القيعي" , Gender = true , isProcurementOfficials = false , CareerID = 3 , NationalNumber = "12345678912345" ,Salary  = 1500 , Description ="Nothing"}

            );

        }


        public DbSet<CareerType> CareerTypes {get;set;}
        public DbSet<Career> Careers {get;set;}
        public DbSet<Employee> Employees {get;set;}
        public DbSet<OfficeRepository> OfficeRepositories{get;set;}
        public DbSet<PurchaseOrder> PurchaseOrders {get;set;}
        public DbSet<PurchaseOrderItem> PurchaseOrderItems {get;set;}


    }
}