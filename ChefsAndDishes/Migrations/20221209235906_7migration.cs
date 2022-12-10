using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChefsAndDishes.Migrations
{
    public partial class _7migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Chefs");

            migrationBuilder.AddColumn<int>(
                name: "Calories",
                table: "Dishes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Calories",
                table: "Dishes");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Chefs",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
