﻿// <auto-generated />
using System;
using ContractingCompany.Models.CCDBContextFld;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ContractingCompany.Migrations
{
    [DbContext(typeof(CCDBContext))]
    partial class CCDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-preview3-35497")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ContractingCompany.Models.Office.CareerFld.Career", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CareerTypeID");

                    b.Property<string>("Description")
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<bool?>("isSysAdmin");

                    b.Property<bool?>("isSysUser");

                    b.HasKey("ID");

                    b.HasIndex("CareerTypeID");

                    b.ToTable("Careers");

                    b.HasData(
                        new { ID = 1, CareerTypeID = 1, Description = "", Name = "رئيس مجلس الإدارة", isSysAdmin = true, isSysUser = true },
                        new { ID = 2, CareerTypeID = 1, Description = "", Name = "محاسب", isSysAdmin = true, isSysUser = true },
                        new { ID = 3, CareerTypeID = 1, Description = "", Name = "عامل بوفيه", isSysAdmin = false, isSysUser = false }
                    );
                });

            modelBuilder.Entity("ContractingCompany.Models.Office.CareerFld.CareerType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("CareerTypes");

                    b.HasData(
                        new { ID = 1, Description = "رئيس مجلس إدارة", Name = "رئيس مجلس إدارة" },
                        new { ID = 2, Description = "محاسب", Name = "محاسب" },
                        new { ID = 3, Description = "عامل بوفيه", Name = "عامل بوفيه" }
                    );
                });

            modelBuilder.Entity("ContractingCompany.Models.Office.EmployeeFld.Employee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CareerID");

                    b.Property<string>("Description")
                        .HasMaxLength(200);

                    b.Property<bool>("Gender");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("NationalNumber")
                        .HasMaxLength(14);

                    b.Property<decimal>("Salary");

                    b.Property<bool?>("isProcurementOfficials");

                    b.HasKey("ID");

                    b.HasIndex("CareerID");

                    b.ToTable("Employees");

                    b.HasData(
                        new { ID = 1, CareerID = 2, Description = "Nothing", Gender = true, Name = "أسامة محمود", NationalNumber = "12345678912345", Salary = 5000m, isProcurementOfficials = true },
                        new { ID = 2, CareerID = 3, Description = "Nothing", Gender = true, Name = "قاسم سلامة القيعي", NationalNumber = "12345678912345", Salary = 1500m, isProcurementOfficials = false }
                    );
                });

            modelBuilder.Entity("ContractingCompany.Models.Office.OfficeRepositoryFld.OfficeRepository", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddDate");

                    b.Property<int>("ProductID");

                    b.Property<int>("Quantity");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("ID");

                    b.HasIndex("ProductID");

                    b.ToTable("OfficeRepositories");
                });

            modelBuilder.Entity("ContractingCompany.Models.Office.PurchaseOrderFld.PurchaseOrder", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddedDate");

                    b.Property<string>("Description")
                        .HasMaxLength(200);

                    b.Property<int>("EmployeeID");

                    b.Property<DateTime>("OrderDate");

                    b.Property<int>("OrderStatusType");

                    b.Property<int>("SupplierID");

                    b.HasKey("ID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("SupplierID");

                    b.ToTable("PurchaseOrders");
                });

            modelBuilder.Entity("ContractingCompany.Models.Office.PurchaseOrderFld.PurchaseOrderItem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Discount");

                    b.Property<int>("ProductID");

                    b.Property<int>("PurchaseOrderID");

                    b.Property<decimal>("PurchasePrice");

                    b.Property<int>("Quantity");

                    b.HasKey("ID");

                    b.HasIndex("ProductID");

                    b.HasIndex("PurchaseOrderID");

                    b.ToTable("PurchaseOrderItems");
                });

            modelBuilder.Entity("ContractingCompany.Models.OperationFld.OperationCareerFld.OperationCareer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<bool>("isSysSubAdmin");

                    b.Property<bool>("isSysSubUser");

                    b.HasKey("ID");

                    b.ToTable("OperationCareers");

                    b.HasData(
                        new { ID = 1, Description = "يعمل على البلدوزر بشكل أساسي", Name = "سائق بلدوزر", isSysSubAdmin = false, isSysSubUser = false },
                        new { ID = 2, Description = "تباع", Name = "تباع", isSysSubAdmin = false, isSysSubUser = false },
                        new { ID = 3, Description = "مخول له ادارة حسابات العملية والتسجيل على الكمبيوتر", Name = "محاسب عملية ", isSysSubAdmin = true, isSysSubUser = true }
                    );
                });

            modelBuilder.Entity("ContractingCompany.Models.OperationFld.OperationCareerFld.OperationEmployee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<int>("OperationCareerID");

                    b.Property<decimal?>("Salary");

                    b.HasKey("ID");

                    b.HasIndex("OperationCareerID");

                    b.ToTable("OperationEmployees");

                    b.HasData(
                        new { ID = 1, Address = "مدينة نصر", Name = "محمود سلامة النويجع", OperationCareerID = 2, Salary = 5600m },
                        new { ID = 2, Address = "مدينة نصر", Name = "تامر كمال المحمودي", OperationCareerID = 3, Salary = 3500m }
                    );
                });

            modelBuilder.Entity("ContractingCompany.Models.OperationFld.OperationEquipmentFld.EquipmentCalculationMethod", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.HasKey("ID");

                    b.ToTable("EquipmentCalculationMethods");

                    b.HasData(
                        new { ID = 1, Description = "بالمتر المكعب", Name = "بالمتر" },
                        new { ID = 2, Description = "قياس بالساعة الانتاجية", Name = "بالساعة" }
                    );
                });

            modelBuilder.Entity("ContractingCompany.Models.OperationFld.OperationEquipmentFld.OperationEquipment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddedDate");

                    b.Property<DateTime>("AgreementDate");

                    b.Property<string>("Description");

                    b.Property<int>("EquipmentCalculationMethodID");

                    b.Property<int>("EquipmentID");

                    b.Property<int>("OperationGeneralDataID");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("ID");

                    b.HasIndex("EquipmentCalculationMethodID");

                    b.HasIndex("EquipmentID");

                    b.HasIndex("OperationGeneralDataID");

                    b.ToTable("OperationEquipments");

                    b.HasData(
                        new { ID = 1, AddedDate = new DateTime(2018, 11, 14, 0, 0, 0, 0, DateTimeKind.Local), AgreementDate = new DateTime(2018, 11, 14, 0, 0, 0, 0, DateTimeKind.Local), Description = "", EquipmentCalculationMethodID = 1, EquipmentID = 2, OperationGeneralDataID = 1, UpdatedDate = new DateTime(2018, 11, 14, 0, 0, 0, 0, DateTimeKind.Local) },
                        new { ID = 2, AddedDate = new DateTime(2018, 11, 14, 0, 0, 0, 0, DateTimeKind.Local), AgreementDate = new DateTime(2018, 11, 14, 0, 0, 0, 0, DateTimeKind.Local), Description = "", EquipmentCalculationMethodID = 2, EquipmentID = 1, OperationGeneralDataID = 1, UpdatedDate = new DateTime(2018, 11, 14, 0, 0, 0, 0, DateTimeKind.Local) }
                    );
                });

            modelBuilder.Entity("ContractingCompany.Models.OperationFld.OperationGeneralDataFld.OperationGeneralData", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<DateTime>("EndDate");

                    b.Property<string>("Location");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<DateTime>("StartDate");

                    b.HasKey("ID");

                    b.ToTable("OperationGeneralDatas");

                    b.HasData(
                        new { ID = 1, Description = "", EndDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Location = "رأس البر", Name = "عملية رأي البر", StartDate = new DateTime(2018, 11, 14, 0, 0, 0, 0, DateTimeKind.Local) }
                    );
                });

            modelBuilder.Entity("ContractingCompany.Models.OperationFld.WorkTimeFld.OperationWorkTime", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddedDate");

                    b.Property<string>("Description");

                    b.Property<int>("OperationCareerID");

                    b.Property<int>("OperationEmployeeID");

                    b.Property<int>("OperationGeneralDataID");

                    b.Property<DateTime>("StartDate");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("ID");

                    b.HasIndex("OperationCareerID");

                    b.HasIndex("OperationEmployeeID");

                    b.HasIndex("OperationGeneralDataID");

                    b.ToTable("OperationWorkTimes");
                });

            modelBuilder.Entity("ContractingCompany.Models.PublicItems.EquipmentFld.DependencyEquipment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.HasKey("ID");

                    b.ToTable("DependencyEquipments");

                    b.HasData(
                        new { ID = 1, Description = "", Name = "كاتر بلر" }
                    );
                });

            modelBuilder.Entity("ContractingCompany.Models.PublicItems.EquipmentFld.Equipment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Barcode")
                        .HasMaxLength(20);

                    b.Property<string>("ChassisNo")
                        .HasMaxLength(20);

                    b.Property<string>("Code")
                        .HasMaxLength(20);

                    b.Property<int>("DependencyID");

                    b.Property<int>("EquipmentTypeID");

                    b.Property<string>("Model")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.HasKey("ID");

                    b.HasIndex("DependencyID");

                    b.HasIndex("EquipmentTypeID");

                    b.ToTable("Equipments");

                    b.HasData(
                        new { ID = 1, Barcode = "123456", ChassisNo = "125543", Code = "123456", DependencyID = 1, EquipmentTypeID = 1, Model = "2010", Name = "AX25 BU" },
                        new { ID = 2, Barcode = "123456", ChassisNo = "125543", Code = "123456", DependencyID = 1, EquipmentTypeID = 2, Model = "1998", Name = "MRT98 FGH" }
                    );
                });

            modelBuilder.Entity("ContractingCompany.Models.PublicItems.EquipmentFld.EquipmentDefaultMeasurementType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.HasKey("ID");

                    b.ToTable("EquipmentDefaultMeasurementTypes");

                    b.HasData(
                        new { ID = 1, Description = "يتم الحساب على قياس المتر المكعب", Name = "متر مكعب" },
                        new { ID = 2, Description = "", Name = "بالارتفاع" }
                    );
                });

            modelBuilder.Entity("ContractingCompany.Models.PublicItems.EquipmentFld.EquipmentDefaultMeasurementType_Equipment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddedDate");

                    b.Property<int>("EquipmentDefaultMeasurementTypeID");

                    b.Property<int>("EquipmentID");

                    b.Property<string>("MeasureName")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("ID");

                    b.HasIndex("EquipmentDefaultMeasurementTypeID");

                    b.HasIndex("EquipmentID");

                    b.ToTable("EquipmentDefaultMeasurementType_Equipments");
                });

            modelBuilder.Entity("ContractingCompany.Models.PublicItems.EquipmentFld.EquipmentType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.HasKey("ID");

                    b.ToTable("EquipmentTypes");

                    b.HasData(
                        new { ID = 1, Description = "حفار بالرافع والتللير", Name = "حفار" },
                        new { ID = 2, Description = "وسف بالقائمة", Name = "بالدوزر" }
                    );
                });

            modelBuilder.Entity("ContractingCompany.Models.PublicItems.ProductFld.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Barcode")
                        .HasMaxLength(10);

                    b.Property<string>("Code")
                        .HasMaxLength(10);

                    b.Property<int>("DefaultSupplierID");

                    b.Property<string>("Description")
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("ProductCategoryID");

                    b.Property<string>("ProductionCompanyName");

                    b.Property<decimal?>("PurchasePrice");

                    b.HasKey("ID");

                    b.HasIndex("DefaultSupplierID");

                    b.HasIndex("ProductCategoryID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ContractingCompany.Models.PublicItems.ProductFld.ProductCategory", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("ProductCategories");
                });

            modelBuilder.Entity("ContractingCompany.Models.PublicItems.SupplierFld.Supplier", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("City")
                        .HasMaxLength(100);

                    b.Property<string>("CompanyName")
                        .HasMaxLength(200);

                    b.Property<DateTime>("DateRemainderAmount");

                    b.Property<string>("Fax");

                    b.Property<decimal>("MAXDebtAmount");

                    b.Property<string>("Mobile")
                        .HasMaxLength(12);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Phone");

                    b.Property<decimal>("RemainderAmount");

                    b.Property<int>("SupplierCategoryID")
                        .HasMaxLength(200);

                    b.Property<bool>("isActive");

                    b.HasKey("ID");

                    b.HasIndex("SupplierCategoryID");

                    b.ToTable("Suppliers");

                    b.HasData(
                        new { ID = 1, Address = "الحرفيين", City = "مدينة نصر", CompanyName = "شركة الغزال للتوريد", DateRemainderAmount = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), MAXDebtAmount = 0m, Mobile = "01060322354", Name = "محمد احمد ماهر", RemainderAmount = 52000m, SupplierCategoryID = 1, isActive = true },
                        new { ID = 2, Address = "الحرفيين", City = "مدينة نصر", CompanyName = "شركة السلامة للتوريد", DateRemainderAmount = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), MAXDebtAmount = 0m, Mobile = "01060322354", Name = "سلامة سالم مسلم", RemainderAmount = 16250m, SupplierCategoryID = 2, isActive = true }
                    );
                });

            modelBuilder.Entity("ContractingCompany.Models.PublicItems.SupplierFld.SupplierCategory", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("SupplierCategories");

                    b.HasData(
                        new { ID = 1, Description = "مورد يعمل لدينا بصفة دائمة", Name = "مورد دائم" },
                        new { ID = 2, Description = "من الممكن تصفية الحساب بين الشركة وبين المورد بصفة شهرية", Name = "مورد ثقة" }
                    );
                });

            modelBuilder.Entity("ContractingCompany.Models.Office.CareerFld.Career", b =>
                {
                    b.HasOne("ContractingCompany.Models.Office.CareerFld.CareerType", "CareerType")
                        .WithMany()
                        .HasForeignKey("CareerTypeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ContractingCompany.Models.Office.EmployeeFld.Employee", b =>
                {
                    b.HasOne("ContractingCompany.Models.Office.CareerFld.Career", "Career")
                        .WithMany()
                        .HasForeignKey("CareerID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ContractingCompany.Models.Office.OfficeRepositoryFld.OfficeRepository", b =>
                {
                    b.HasOne("ContractingCompany.Models.PublicItems.ProductFld.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ContractingCompany.Models.Office.PurchaseOrderFld.PurchaseOrder", b =>
                {
                    b.HasOne("ContractingCompany.Models.Office.EmployeeFld.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ContractingCompany.Models.PublicItems.SupplierFld.Supplier", "Supplier")
                        .WithMany()
                        .HasForeignKey("SupplierID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ContractingCompany.Models.Office.PurchaseOrderFld.PurchaseOrderItem", b =>
                {
                    b.HasOne("ContractingCompany.Models.PublicItems.ProductFld.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ContractingCompany.Models.Office.PurchaseOrderFld.PurchaseOrder", "PurchaseOrder")
                        .WithMany()
                        .HasForeignKey("PurchaseOrderID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ContractingCompany.Models.OperationFld.OperationCareerFld.OperationEmployee", b =>
                {
                    b.HasOne("ContractingCompany.Models.OperationFld.OperationCareerFld.OperationCareer", "OperationCareer")
                        .WithMany()
                        .HasForeignKey("OperationCareerID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ContractingCompany.Models.OperationFld.OperationEquipmentFld.OperationEquipment", b =>
                {
                    b.HasOne("ContractingCompany.Models.OperationFld.OperationEquipmentFld.EquipmentCalculationMethod", "EquipmentCalculationMethod")
                        .WithMany()
                        .HasForeignKey("EquipmentCalculationMethodID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ContractingCompany.Models.PublicItems.EquipmentFld.Equipment", "Equipment")
                        .WithMany()
                        .HasForeignKey("EquipmentID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ContractingCompany.Models.OperationFld.OperationGeneralDataFld.OperationGeneralData", "OperationGeneralData")
                        .WithMany()
                        .HasForeignKey("OperationGeneralDataID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ContractingCompany.Models.OperationFld.WorkTimeFld.OperationWorkTime", b =>
                {
                    b.HasOne("ContractingCompany.Models.OperationFld.OperationCareerFld.OperationCareer", "OperationCareer")
                        .WithMany()
                        .HasForeignKey("OperationCareerID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ContractingCompany.Models.OperationFld.OperationCareerFld.OperationEmployee", "OperationEmployee")
                        .WithMany()
                        .HasForeignKey("OperationEmployeeID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ContractingCompany.Models.OperationFld.OperationGeneralDataFld.OperationGeneralData", "OperationGeneralData")
                        .WithMany()
                        .HasForeignKey("OperationGeneralDataID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ContractingCompany.Models.PublicItems.EquipmentFld.Equipment", b =>
                {
                    b.HasOne("ContractingCompany.Models.PublicItems.EquipmentFld.DependencyEquipment", "DependencyEquipment")
                        .WithMany()
                        .HasForeignKey("DependencyID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ContractingCompany.Models.PublicItems.EquipmentFld.EquipmentType", "EquipmentType")
                        .WithMany()
                        .HasForeignKey("EquipmentTypeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ContractingCompany.Models.PublicItems.EquipmentFld.EquipmentDefaultMeasurementType_Equipment", b =>
                {
                    b.HasOne("ContractingCompany.Models.PublicItems.EquipmentFld.EquipmentDefaultMeasurementType", "EquipmentDefaultMeasurementType")
                        .WithMany()
                        .HasForeignKey("EquipmentDefaultMeasurementTypeID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ContractingCompany.Models.PublicItems.EquipmentFld.Equipment", "Equipment")
                        .WithMany()
                        .HasForeignKey("EquipmentID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ContractingCompany.Models.PublicItems.ProductFld.Product", b =>
                {
                    b.HasOne("ContractingCompany.Models.PublicItems.SupplierFld.Supplier", "Supplier")
                        .WithMany()
                        .HasForeignKey("DefaultSupplierID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ContractingCompany.Models.PublicItems.ProductFld.ProductCategory", "ProductCategory")
                        .WithMany()
                        .HasForeignKey("ProductCategoryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ContractingCompany.Models.PublicItems.SupplierFld.Supplier", b =>
                {
                    b.HasOne("ContractingCompany.Models.PublicItems.SupplierFld.SupplierCategory", "SupplierCategory")
                        .WithMany()
                        .HasForeignKey("SupplierCategoryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
