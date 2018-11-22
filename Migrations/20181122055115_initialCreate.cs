using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ContractingCompany.Migrations
{
    public partial class initialCreate : Migration
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
                name: "EquipmentCalculationMethods",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentCalculationMethods", x => x.ID);
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
                name: "OperationCareers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    isSysSubUser = table.Column<bool>(nullable: false),
                    isSysSubAdmin = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationCareers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "OperationGeneralDatas",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    Location = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationGeneralDatas", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SupplierCategories",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierCategories", x => x.ID);
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
                    ChassisNo = table.Column<string>(maxLength: 20, nullable: true),
                    isActive = table.Column<bool>(nullable: false)
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
                name: "OperationEmployees",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    Address = table.Column<string>(nullable: true),
                    Salary = table.Column<decimal>(nullable: true),
                    OperationCareerID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationEmployees", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OperationEmployees_OperationCareers_OperationCareerID",
                        column: x => x.OperationCareerID,
                        principalTable: "OperationCareers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    CompanyName = table.Column<string>(maxLength: 200, nullable: true),
                    SupplierCategoryID = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_Suppliers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Suppliers_SupplierCategories_SupplierCategoryID",
                        column: x => x.SupplierCategoryID,
                        principalTable: "SupplierCategories",
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

            migrationBuilder.CreateTable(
                name: "OperationEquipments",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OperationGeneralDataID = table.Column<int>(nullable: false),
                    EquipmentID = table.Column<int>(nullable: false),
                    EquipmentCalculationMethodID = table.Column<int>(nullable: false),
                    AgreementDate = table.Column<DateTime>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationEquipments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OperationEquipments_EquipmentCalculationMethods_EquipmentCalculationMethodID",
                        column: x => x.EquipmentCalculationMethodID,
                        principalTable: "EquipmentCalculationMethods",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OperationEquipments_Equipments_EquipmentID",
                        column: x => x.EquipmentID,
                        principalTable: "Equipments",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OperationEquipments_OperationGeneralDatas_OperationGeneralDataID",
                        column: x => x.OperationGeneralDataID,
                        principalTable: "OperationGeneralDatas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OperationWorkTimes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OperationGeneralDataID = table.Column<int>(nullable: false),
                    OperationCareerID = table.Column<int>(nullable: false),
                    OperationEmployeeID = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationWorkTimes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OperationWorkTimes_OperationCareers_OperationCareerID",
                        column: x => x.OperationCareerID,
                        principalTable: "OperationCareers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OperationWorkTimes_OperationEmployees_OperationEmployeeID",
                        column: x => x.OperationEmployeeID,
                        principalTable: "OperationEmployees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_OperationWorkTimes_OperationGeneralDatas_OperationGeneralDataID",
                        column: x => x.OperationGeneralDataID,
                        principalTable: "OperationGeneralDatas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
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
                    Description = table.Column<string>(maxLength: 200, nullable: true),
                    isActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Products_Suppliers_DefaultSupplierID",
                        column: x => x.DefaultSupplierID,
                        principalTable: "Suppliers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_ProductCategories_ProductCategoryID",
                        column: x => x.ProductCategoryID,
                        principalTable: "ProductCategories",
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
                        name: "FK_PurchaseOrders_Suppliers_SupplierID",
                        column: x => x.SupplierID,
                        principalTable: "Suppliers",
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
                        name: "FK_OfficeRepositories_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
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
                        name: "FK_PurchaseOrderItems_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
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
                values: new object[,]
                {
                    { 1, "رئيس مجلس إدارة", "رئيس مجلس إدارة" },
                    { 2, "محاسب", "محاسب" },
                    { 3, "عامل بوفيه", "عامل بوفيه" }
                });

            migrationBuilder.InsertData(
                table: "DependencyEquipments",
                columns: new[] { "ID", "Description", "Name" },
                values: new object[] { 1, "", "كاتر بلر" });

            migrationBuilder.InsertData(
                table: "EquipmentCalculationMethods",
                columns: new[] { "ID", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "بالمتر المكعب", "بالمتر" },
                    { 2, "قياس بالساعة الانتاجية", "بالساعة" }
                });

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
                table: "OperationCareers",
                columns: new[] { "ID", "Description", "Name", "isSysSubAdmin", "isSysSubUser" },
                values: new object[,]
                {
                    { 2, "تباع", "تباع", false, false },
                    { 3, "مخول له ادارة حسابات العملية والتسجيل على الكمبيوتر", "محاسب عملية ", true, true },
                    { 1, "يعمل على البلدوزر بشكل أساسي", "سائق بلدوزر", false, false }
                });

            migrationBuilder.InsertData(
                table: "OperationGeneralDatas",
                columns: new[] { "ID", "Description", "EndDate", "Location", "Name", "StartDate" },
                values: new object[] { 1, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "رأس البر", "عملية رأس البر", new DateTime(2018, 11, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "ID", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "مثال زيت معدة البلدوزر", "زيوت" },
                    { 2, "قطع غيار معدات", "قطع غيار" },
                    { 3, null, "هياكل" }
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
                table: "Careers",
                columns: new[] { "ID", "CareerTypeID", "Description", "Name", "isSysAdmin", "isSysUser" },
                values: new object[,]
                {
                    { 1, 1, "", "رئيس مجلس الإدارة", true, true },
                    { 2, 1, "", "محاسب", true, true },
                    { 3, 1, "", "عامل بوفيه", false, false }
                });

            migrationBuilder.InsertData(
                table: "Equipments",
                columns: new[] { "ID", "Barcode", "ChassisNo", "Code", "DependencyID", "EquipmentTypeID", "Model", "Name", "isActive" },
                values: new object[,]
                {
                    { 1, "123456", "125543", "123456", 1, 1, "2010", "AX25 BU", true },
                    { 2, "123456", "125543", "123456", 1, 2, "1998", "MRT98 FGH", true }
                });

            migrationBuilder.InsertData(
                table: "OperationEmployees",
                columns: new[] { "ID", "Address", "Name", "OperationCareerID", "Salary" },
                values: new object[,]
                {
                    { 1, "مدينة نصر", "محمود سلامة النويجع", 2, 5600m },
                    { 2, "مدينة نصر", "تامر كمال المحمودي", 3, 3500m }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "ID", "Address", "City", "CompanyName", "DateRemainderAmount", "Fax", "MAXDebtAmount", "Mobile", "Name", "Phone", "RemainderAmount", "SupplierCategoryID", "isActive" },
                values: new object[,]
                {
                    { 1, "الحرفيين", "مدينة نصر", "شركة الغزال للتوريد", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0m, "01060322354", "محمد احمد ماهر", null, 52000m, 1, true },
                    { 2, "الحرفيين", "مدينة نصر", "شركة السلامة للتوريد", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0m, "01060322354", "سلامة سالم مسلم", null, 16250m, 2, true }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "CareerID", "Description", "Gender", "Name", "NationalNumber", "Salary", "isProcurementOfficials" },
                values: new object[,]
                {
                    { 1, 2, "Nothing", true, "أسامة محمود", "12345678912345", 5000m, true },
                    { 2, 3, "Nothing", true, "قاسم سلامة القيعي", "12345678912345", 1500m, false }
                });

            migrationBuilder.InsertData(
                table: "OperationEquipments",
                columns: new[] { "ID", "AddedDate", "AgreementDate", "Description", "EquipmentCalculationMethodID", "EquipmentID", "OperationGeneralDataID", "UpdatedDate" },
                values: new object[,]
                {
                    { 2, new DateTime(2018, 11, 22, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2018, 11, 22, 0, 0, 0, 0, DateTimeKind.Local), "", 2, 1, 1, new DateTime(2018, 11, 22, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 1, new DateTime(2018, 11, 22, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2018, 11, 22, 0, 0, 0, 0, DateTimeKind.Local), "", 1, 2, 1, new DateTime(2018, 11, 22, 0, 0, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Barcode", "Code", "DefaultSupplierID", "Description", "Name", "ProductCategoryID", "ProductionCompanyName", "PurchasePrice", "isActive" },
                values: new object[,]
                {
                    { 1, "123", "123", 1, "Nothing", "سكاترة لودر 506", 1, "SSTDF", 5630m, true },
                    { 2, "456", "456", 1, "Nothing", "سكاترة لودر 59", 1, "SSTDF", 15230m, true }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Careers_CareerTypeID",
                table: "Careers",
                column: "CareerTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_CareerID",
                table: "Employees",
                column: "CareerID");

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

            migrationBuilder.CreateIndex(
                name: "IX_OfficeRepositories_ProductID",
                table: "OfficeRepositories",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_OperationEmployees_OperationCareerID",
                table: "OperationEmployees",
                column: "OperationCareerID");

            migrationBuilder.CreateIndex(
                name: "IX_OperationEquipments_EquipmentCalculationMethodID",
                table: "OperationEquipments",
                column: "EquipmentCalculationMethodID");

            migrationBuilder.CreateIndex(
                name: "IX_OperationEquipments_EquipmentID",
                table: "OperationEquipments",
                column: "EquipmentID");

            migrationBuilder.CreateIndex(
                name: "IX_OperationEquipments_OperationGeneralDataID",
                table: "OperationEquipments",
                column: "OperationGeneralDataID");

            migrationBuilder.CreateIndex(
                name: "IX_OperationWorkTimes_OperationCareerID",
                table: "OperationWorkTimes",
                column: "OperationCareerID");

            migrationBuilder.CreateIndex(
                name: "IX_OperationWorkTimes_OperationEmployeeID",
                table: "OperationWorkTimes",
                column: "OperationEmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_OperationWorkTimes_OperationGeneralDataID",
                table: "OperationWorkTimes",
                column: "OperationGeneralDataID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_DefaultSupplierID",
                table: "Products",
                column: "DefaultSupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductCategoryID",
                table: "Products",
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
                name: "IX_Suppliers_SupplierCategoryID",
                table: "Suppliers",
                column: "SupplierCategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EquipmentDefaultMeasurementType_Equipments");

            migrationBuilder.DropTable(
                name: "OfficeRepositories");

            migrationBuilder.DropTable(
                name: "OperationEquipments");

            migrationBuilder.DropTable(
                name: "OperationWorkTimes");

            migrationBuilder.DropTable(
                name: "PurchaseOrderItems");

            migrationBuilder.DropTable(
                name: "EquipmentDefaultMeasurementTypes");

            migrationBuilder.DropTable(
                name: "EquipmentCalculationMethods");

            migrationBuilder.DropTable(
                name: "Equipments");

            migrationBuilder.DropTable(
                name: "OperationEmployees");

            migrationBuilder.DropTable(
                name: "OperationGeneralDatas");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "PurchaseOrders");

            migrationBuilder.DropTable(
                name: "DependencyEquipments");

            migrationBuilder.DropTable(
                name: "EquipmentTypes");

            migrationBuilder.DropTable(
                name: "OperationCareers");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "Careers");

            migrationBuilder.DropTable(
                name: "SupplierCategories");

            migrationBuilder.DropTable(
                name: "CareerTypes");
        }
    }
}
