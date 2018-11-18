using Microsoft.EntityFrameworkCore.Migrations;

namespace ContractingCompany.Migrations
{
    public partial class updatecareermodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "isSysUser",
                table: "Careers",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "isSysAdmin",
                table: "Careers",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "isSysUser",
                table: "Careers",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<bool>(
                name: "isSysAdmin",
                table: "Careers",
                nullable: true,
                oldClrType: typeof(bool));
        }
    }
}
