using Microsoft.EntityFrameworkCore.Migrations;

namespace webapisqlite.Data.Migrations
{
    public partial class Updatingcompanytable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CompanyName",
                table: "Company",
                newName: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Company",
                newName: "CompanyName");
        }
    }
}
