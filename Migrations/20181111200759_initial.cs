
using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ContractingCompany.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CareerTypes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CareerTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategory",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategory", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SupplierCategory",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierCategory", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Careers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    CareerTypeID = table.Column<int>(nullable: false),
                    isSysUser = table.Column<bool>(nullable: false),
                    isSysAdmin = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Careers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Careers_CareerTypes_CareerTypeID",
                        column: x => x.CareerTypeID,
                        principalTable: "CareerTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    CompanyName = table.Column<string>(maxLength: 200, nullable: true),
                    SupplierCategoryID = table.Column<int>(maxLength: 200, nullable: false),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(maxLength: 100, nullable: true),
                    Mobile = table.Column<string>(maxLength: 12, nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Fax = table.Column<string>(nullable: true),
                    RemainderAmount = table.Column<decimal>(nullable: false),
                    DateRemainderAmount = table.Column<DateTime>(nullable: false),
                    MAXDebtAmount = table.Column<decimal>(nullable: false),
                    isActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Supplier_SupplierCategory_SupplierCategoryID",
                        column: x => x.SupplierCategoryID,
                        principalTable: "SupplierCategory",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    NationalNumber = table.Column<string>(maxLength: 14, nullable: true),
                    CareerID = table.Column<int>(nullable: false),
                    Gender = table.Column<bool>(nullable: false),
                    Salary = table.Column<decimal>(nullable: false),
                    isProcurementOfficials = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Employees_Careers_CareerID",
                        column: x => x.CareerID,
                        principalTable: "Careers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Code = table.Column<string>(maxLength: 10, nullable: true),
                    Barcode = table.Column<string>(maxLength: 10, nullable: true),
                    ProductionCompanyName = table.Column<string>(nullable: true),
                    PurchasePrice = table.Column<decimal>(nullable: true),
                    ProductCategoryID = table.Column<int>(nullable: false),
                    DefaultSupplierID = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Product_Supplier_DefaultSupplierID",
                        column: x => x.DefaultSupplierID,
                        principalTable: "Supplier",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_ProductCategory_ProductCategoryID",
                        column: x => x.ProductCategoryID,
                        principalTable: "ProductCategory",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOrders",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SupplierID = table.Column<int>(nullable: false),
                    OrderStatusType = table.Column<int>(nullable: false),
                    EmployeeID = table.Column<int>(nullable: false),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrders", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PurchaseOrders_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PurchaseOrders_Supplier_SupplierID",
                        column: x => x.SupplierID,
                        principalTable: "Supplier",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OfficeRepositories",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProductID = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    AddDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfficeRepositories", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OfficeRepositories_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOrderItems",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PurchaseOrderID = table.Column<int>(nullable: false),
                    ProductID = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    PurchasePrice = table.Column<decimal>(nullable: false),
                    Discount = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrderItems", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PurchaseOrderItems_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PurchaseOrderItems_PurchaseOrders_PurchaseOrderID",
                        column: x => x.PurchaseOrderID,
                        principalTable: "PurchaseOrders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "CareerTypes",
                columns: new[] { "ID", "Description", "Name" },
                values: new object[] { 1, "رئيس مجلس إدارة", "رئيس مجلس إدارة" });

            migrationBuilder.InsertData(
                table: "CareerTypes",
                columns: new[] { "ID", "Description", "Name" },
                values: new object[] { 2, "محاسب", "محاسب" });

            migrationBuilder.InsertData(
                table: "CareerTypes",
                columns: new[] { "ID", "Description", "Name" },
                values: new object[] { 3, "عامل بوفيه", "عامل بوفيه" });

            migrationBuilder.InsertData(
                table: "Careers",
                columns: new[] { "ID", "CareerTypeID", "Description", "Name", "isSysAdmin", "isSysUser" },
                values: new object[] { 1, 1, "", "رئيس مجلس الإدارة", true, true });

            migrationBuilder.InsertData(
                table: "Careers",
                columns: new[] { "ID", "CareerTypeID", "Description", "Name", "isSysAdmin", "isSysUser" },
                values: new object[] { 2, 1, "", "محاسب", true, true });

            migrationBuilder.InsertData(
                table: "Careers",
                columns: new[] { "ID", "CareerTypeID", "Description", "Name", "isSysAdmin", "isSysUser" },
                values: new object[] { 3, 1, "", "عامل بوفيه", false, false });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "CareerID", "Description", "Gender", "Name", "NationalNumber", "Salary", "isProcurementOfficials" },
                values: new object[] { 1, 2, "Nothing", true, "أسامة محمود", "12345678912345", 5000m, true });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "CareerID", "Description", "Gender", "Name", "NationalNumber", "Salary", "isProcurementOfficials" },
                values: new object[] { 2, 3, "Nothing", true, "قاسم سلامة القيعي", "12345678912345", 1500m, false });

            migrationBuilder.CreateIndex(
                name: "IX_Careers_CareerTypeID",
                table: "Careers",
                column: "CareerTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_CareerID",
                table: "Employees",
                column: "CareerID");

            migrationBuilder.CreateIndex(
                name: "IX_OfficeRepositories_ProductID",
                table: "OfficeRepositories",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_DefaultSupplierID",
                table: "Product",
                column: "DefaultSupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductCategoryID",
                table: "Product",
                column: "ProductCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrderItems_ProductID",
                table: "PurchaseOrderItems",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrderItems_PurchaseOrderID",
                table: "PurchaseOrderItems",
                column: "PurchaseOrderID");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrders_EmployeeID",
                table: "PurchaseOrders",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrders_SupplierID",
                table: "PurchaseOrders",
                column: "SupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_Supplier_SupplierCategoryID",
                table: "Supplier",
                column: "SupplierCategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OfficeRepositories");

            migrationBuilder.DropTable(
                name: "PurchaseOrderItems");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "PurchaseOrders");

            migrationBuilder.DropTable(
                name: "ProductCategory");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Supplier");

            migrationBuilder.DropTable(
                name: "Careers");

            migrationBuilder.DropTable(
                name: "SupplierCategory");

            migrationBuilder.DropTable(
                name: "CareerTypes");
        }
    }
}
