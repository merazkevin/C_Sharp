using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChefsAndDishes.Migrations
{
    public partial class _9migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChefId",
                table: "Dishes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ChefId",
                table: "Dishes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
