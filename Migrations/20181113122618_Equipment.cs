using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ContractingCompany.Migrations
{
    public partial class Equipment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OfficeRepositories_Product_ProductID",
                table: "OfficeRepositories");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Supplier_DefaultSupplierID",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_ProductCategory_ProductCategoryID",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseOrderItems_Product_ProductID",
                table: "PurchaseOrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseOrders_Supplier_SupplierID",
                table: "PurchaseOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_Supplier_SupplierCategory_SupplierCategoryID",
                table: "Supplier");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SupplierCategory",
                table: "SupplierCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Supplier",
                table: "Supplier");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductCategory",
                table: "ProductCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.RenameTable(
                name: "SupplierCategory",
                newName: "SupplierCategories");

            migrationBuilder.RenameTable(
                name: "Supplier",
                newName: "Suppliers");

            migrationBuilder.RenameTable(
                name: "ProductCategory",
                newName: "ProductCategories");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "Products");

            migrationBuilder.RenameIndex(
                name: "IX_Supplier_SupplierCategoryID",
                table: "Suppliers",
                newName: "IX_Suppliers_SupplierCategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_Product_ProductCategoryID",
                table: "Products",
                newName: "IX_Products_ProductCategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_Product_DefaultSupplierID",
                table: "Products",
                newName: "IX_Products_DefaultSupplierID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SupplierCategories",
                table: "SupplierCategories",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Suppliers",
                table: "Suppliers",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductCategories",
                table: "ProductCategories",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "DependencyEquipments",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DependencyEquipments", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentDefaultMeasurementTypes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentDefaultMeasurementTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentTypes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Equipments",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    EquipmentTypeID = table.Column<int>(nullable: false),
                    DependencyID = table.Column<int>(nullable: false),
                    Code = table.Column<string>(maxLength: 20, nullable: true),
                    Barcode = table.Column<string>(maxLength: 20, nullable: true),
                    Model = table.Column<string>(maxLength: 50, nullable: true),
                    ChassisNo = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Equipments_DependencyEquipments_DependencyID",
                        column: x => x.DependencyID,
                        principalTable: "DependencyEquipments",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Equipments_EquipmentTypes_EquipmentTypeID",
                        column: x => x.EquipmentTypeID,
                        principalTable: "EquipmentTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentDefaultMeasurementType_Equipments",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EquipmentID = table.Column<int>(nullable: false),
                    EquipmentDefaultMeasurementTypeID = table.Column<int>(nullable: false),
                    MeasureName = table.Column<string>(maxLength: 150, nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentDefaultMeasurementType_Equipments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_EquipmentDefaultMeasurementType_Equipments_EquipmentDefaultMeasurementTypes_EquipmentDefaultMeasurementTypeID",
                        column: x => x.EquipmentDefaultMeasurementTypeID,
                        principalTable: "EquipmentDefaultMeasurementTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EquipmentDefaultMeasurementType_Equipments_Equipments_EquipmentID",
                        column: x => x.EquipmentID,
                        principalTable: "Equipments",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "DependencyEquipments",
                columns: new[] { "ID", "Description", "Name" },
                values: new object[] { 1, "", "كاتر بلر" });

            migrationBuilder.InsertData(
                table: "EquipmentDefaultMeasurementTypes",
                columns: new[] { "ID", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "يتم الحساب على قياس المتر المكعب", "متر مكعب" },
                    { 2, "", "بالارتفاع" }
                });

            migrationBuilder.InsertData(
                table: "EquipmentTypes",
                columns: new[] { "ID", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "حفار بالرافع والتللير", "حفار" },
                    { 2, "وسف بالقائمة", "بالدوزر" }
                });

            migrationBuilder.InsertData(
                table: "SupplierCategories",
                columns: new[] { "ID", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "مورد يعمل لدينا بصفة دائمة", "مورد دائم" },
                    { 2, "من الممكن تصفية الحساب بين الشركة وبين المورد بصفة شهرية", "مورد ثقة" }
                });

            migrationBuilder.InsertData(
                table: "Equipments",
                columns: new[] { "ID", "Barcode", "ChassisNo", "Code", "DependencyID", "EquipmentTypeID", "Model", "Name" },
                values: new object[,]
                {
                    { 1, "123456", "125543", "123456", 1, 1, "2010", "AX25 BU" },
                    { 2, "123456", "125543", "123456", 1, 2, "1998", "MRT98 FGH" }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "ID", "Address", "City", "CompanyName", "DateRemainderAmount", "Fax", "MAXDebtAmount", "Mobile", "Name", "Phone", "RemainderAmount", "SupplierCategoryID", "isActive" },
                values: new object[,]
                {
                    { 1, "الحرفيين", "مدينة نصر", "شركة الغزال للتوريد", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0m, "01060322354", "محمد احمد ماهر", null, 52000m, 1, true },
                    { 2, "الحرفيين", "مدينة نصر", "شركة السلامة للتوريد", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0m, "01060322354", "سلامة سالم مسلم", null, 16250m, 2, true }
                });

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentDefaultMeasurementType_Equipments_EquipmentDefaultMeasurementTypeID",
                table: "EquipmentDefaultMeasurementType_Equipments",
                column: "EquipmentDefaultMeasurementTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentDefaultMeasurementType_Equipments_EquipmentID",
                table: "EquipmentDefaultMeasurementType_Equipments",
                column: "EquipmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_DependencyID",
                table: "Equipments",
                column: "DependencyID");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_EquipmentTypeID",
                table: "Equipments",
                column: "EquipmentTypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_OfficeRepositories_Products_ProductID",
                table: "OfficeRepositories",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Suppliers_DefaultSupplierID",
                table: "Products",
                column: "DefaultSupplierID",
                principalTable: "Suppliers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductCategories_ProductCategoryID",
                table: "Products",
                column: "ProductCategoryID",
                principalTable: "ProductCategories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseOrderItems_Products_ProductID",
                table: "PurchaseOrderItems",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseOrders_Suppliers_SupplierID",
                table: "PurchaseOrders",
                column: "SupplierID",
                principalTable: "Suppliers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Suppliers_SupplierCategories_SupplierCategoryID",
                table: "Suppliers",
                column: "SupplierCategoryID",
                principalTable: "SupplierCategories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OfficeRepositories_Products_ProductID",
                table: "OfficeRepositories");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Suppliers_DefaultSupplierID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductCategories_ProductCategoryID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseOrderItems_Products_ProductID",
                table: "PurchaseOrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseOrders_Suppliers_SupplierID",
                table: "PurchaseOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_Suppliers_SupplierCategories_SupplierCategoryID",
                table: "Suppliers");

            migrationBuilder.DropTable(
                name: "EquipmentDefaultMeasurementType_Equipments");

            migrationBuilder.DropTable(
                name: "EquipmentDefaultMeasurementTypes");

            migrationBuilder.DropTable(
                name: "Equipments");

            migrationBuilder.DropTable(
                name: "DependencyEquipments");

            migrationBuilder.DropTable(
                name: "EquipmentTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Suppliers",
                table: "Suppliers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SupplierCategories",
                table: "SupplierCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductCategories",
                table: "ProductCategories");

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SupplierCategories",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SupplierCategories",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.RenameTable(
                name: "Suppliers",
                newName: "Supplier");

            migrationBuilder.RenameTable(
                name: "SupplierCategories",
                newName: "SupplierCategory");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Product");

            migrationBuilder.RenameTable(
                name: "ProductCategories",
                newName: "ProductCategory");

            migrationBuilder.RenameIndex(
                name: "IX_Suppliers_SupplierCategoryID",
                table: "Supplier",
                newName: "IX_Supplier_SupplierCategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_Products_ProductCategoryID",
                table: "Product",
                newName: "IX_Product_ProductCategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_Products_DefaultSupplierID",
                table: "Product",
                newName: "IX_Product_DefaultSupplierID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Supplier",
                table: "Supplier",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SupplierCategory",
                table: "SupplierCategory",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductCategory",
                table: "ProductCategory",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_OfficeRepositories_Product_ProductID",
                table: "OfficeRepositories",
                column: "ProductID",
                principalTable: "Product",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Supplier_DefaultSupplierID",
                table: "Product",
                column: "DefaultSupplierID",
                principalTable: "Supplier",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_ProductCategory_ProductCategoryID",
                table: "Product",
                column: "ProductCategoryID",
                principalTable: "ProductCategory",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseOrderItems_Product_ProductID",
                table: "PurchaseOrderItems",
                column: "ProductID",
                principalTable: "Product",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseOrders_Supplier_SupplierID",
                table: "PurchaseOrders",
                column: "SupplierID",
                principalTable: "Supplier",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Supplier_SupplierCategory_SupplierCategoryID",
                table: "Supplier",
                column: "SupplierCategoryID",
                principalTable: "SupplierCategory",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
