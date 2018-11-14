using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ContractingCompany.Migrations
{
    public partial class operations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "EquipmentCalculationMethods",
                columns: new[] { "ID", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "بالمتر المكعب", "بالمتر" },
                    { 2, "قياس بالساعة الانتاجية", "بالساعة" }
                });

            migrationBuilder.InsertData(
                table: "OperationCareers",
                columns: new[] { "ID", "Description", "Name", "isSysSubAdmin", "isSysSubUser" },
                values: new object[,]
                {
                    { 1, "يعمل على البلدوزر بشكل أساسي", "سائق بلدوزر", false, false },
                    { 2, "تباع", "تباع", false, false },
                    { 3, "مخول له ادارة حسابات العملية والتسجيل على الكمبيوتر", "محاسب عملية ", true, true }
                });

            migrationBuilder.InsertData(
                table: "OperationGeneralDatas",
                columns: new[] { "ID", "Description", "EndDate", "Location", "Name", "StartDate" },
                values: new object[] { 1, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "رأس البر", "عملية رأي البر", new DateTime(2018, 11, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "OperationEmployees",
                columns: new[] { "ID", "Address", "Name", "OperationCareerID", "Salary" },
                values: new object[,]
                {
                    { 1, "مدينة نصر", "محمود سلامة النويجع", 2, 5600m },
                    { 2, "مدينة نصر", "تامر كمال المحمودي", 3, 3500m }
                });

            migrationBuilder.InsertData(
                table: "OperationEquipments",
                columns: new[] { "ID", "AddedDate", "AgreementDate", "Description", "EquipmentCalculationMethodID", "EquipmentID", "OperationGeneralDataID", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2018, 11, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2018, 11, 14, 0, 0, 0, 0, DateTimeKind.Local), "", 1, 2, 1, new DateTime(2018, 11, 14, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 2, new DateTime(2018, 11, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2018, 11, 14, 0, 0, 0, 0, DateTimeKind.Local), "", 2, 1, 1, new DateTime(2018, 11, 14, 0, 0, 0, 0, DateTimeKind.Local) }
                });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OperationEquipments");

            migrationBuilder.DropTable(
                name: "OperationWorkTimes");

            migrationBuilder.DropTable(
                name: "EquipmentCalculationMethods");

            migrationBuilder.DropTable(
                name: "OperationEmployees");

            migrationBuilder.DropTable(
                name: "OperationGeneralDatas");

            migrationBuilder.DropTable(
                name: "OperationCareers");
        }
    }
}
