using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ContractingCompany.Migrations
{
    public partial class initialProj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isActive",
                table: "Products",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<bool>(
                name: "isProcurementOfficials",
                table: "Employees",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "OperationEquipments",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "AddedDate", "AgreementDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 11, 21, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2018, 11, 21, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2018, 11, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "OperationEquipments",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "AddedDate", "AgreementDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 11, 21, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2018, 11, 21, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2018, 11, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "OperationGeneralDatas",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Name", "StartDate" },
                values: new object[] { "عملية رأس البر", new DateTime(2018, 11, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "ID", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "مثال زيت معدة البلدوزر", "زيوت" },
                    { 2, "قطع غيار معدات", "قطع غيار" },
                    { 3, null, "هياكل" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "isActive",
                table: "Products");

            migrationBuilder.AlterColumn<bool>(
                name: "isProcurementOfficials",
                table: "Employees",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.UpdateData(
                table: "OperationEquipments",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "AddedDate", "AgreementDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2018, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2018, 11, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "OperationEquipments",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "AddedDate", "AgreementDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2018, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2018, 11, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "OperationGeneralDatas",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Name", "StartDate" },
                values: new object[] { "عملية رأي البر", new DateTime(2018, 11, 16, 0, 0, 0, 0, DateTimeKind.Local) });
        }
    }
}
