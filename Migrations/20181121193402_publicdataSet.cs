using Microsoft.EntityFrameworkCore.Migrations;

namespace ContractingCompany.Migrations
{
    public partial class publicdataSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Barcode", "Code", "DefaultSupplierID", "Description", "Name", "ProductCategoryID", "ProductionCompanyName", "PurchasePrice", "isActive" },
                values: new object[] { 1, "123", "123", 1, "Nothing", "سكاترة لودر 506", 1, "SSTDF", 5630m, true });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Barcode", "Code", "DefaultSupplierID", "Description", "Name", "ProductCategoryID", "ProductionCompanyName", "PurchasePrice", "isActive" },
                values: new object[] { 2, "456", "456", 1, "Nothing", "سكاترة لودر 59", 1, "SSTDF", 15230m, true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2);
        }
    }
}
