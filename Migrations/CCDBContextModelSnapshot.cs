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

                    b.ToTable("Product");
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

                    b.ToTable("ProductCategory");
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

                    b.ToTable("Supplier");
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

                    b.ToTable("SupplierCategory");
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
