using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ContractingCompany.Migrations
{
    public partial class updatecareerclass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                column: "StartDate",
                value: new DateTime(2018, 11, 16, 0, 0, 0, 0, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "OperationEquipments",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "AddedDate", "AgreementDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 11, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2018, 11, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2018, 11, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "OperationEquipments",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "AddedDate", "AgreementDate", "UpdatedDate" },
                values: new object[] { new DateTime(2018, 11, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2018, 11, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2018, 11, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "OperationGeneralDatas",
                keyColumn: "ID",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2018, 11, 14, 0, 0, 0, 0, DateTimeKind.Local));
        }
    }
}
