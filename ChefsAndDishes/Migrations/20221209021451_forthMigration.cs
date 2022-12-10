using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChefsAndDishes.Migrations
{
    public partial class forthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FisrtName",
                table: "Users",
                newName: "FirstName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Users",
                newName: "FisrtName");
        }
    }
}
