using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChefsAndDishes.Migrations
{
    public partial class _10migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChefDish");

            migrationBuilder.AddColumn<int>(
                name: "ChefId",
                table: "Dishes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Dishes_ChefId",
                table: "Dishes",
                column: "ChefId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dishes_Chefs_ChefId",
                table: "Dishes",
                column: "ChefId",
                principalTable: "Chefs",
                principalColumn: "ChefId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dishes_Chefs_ChefId",
                table: "Dishes");

            migrationBuilder.DropIndex(
                name: "IX_Dishes_ChefId",
                table: "Dishes");

            migrationBuilder.DropColumn(
                name: "ChefId",
                table: "Dishes");

            migrationBuilder.CreateTable(
                name: "ChefDish",
                columns: table => new
                {
                    DishCreatorChefId = table.Column<int>(type: "int", nullable: false),
                    DishesDishID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChefDish", x => new { x.DishCreatorChefId, x.DishesDishID });
                    table.ForeignKey(
                        name: "FK_ChefDish_Chefs_DishCreatorChefId",
                        column: x => x.DishCreatorChefId,
                        principalTable: "Chefs",
                        principalColumn: "ChefId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChefDish_Dishes_DishesDishID",
                        column: x => x.DishesDishID,
                        principalTable: "Dishes",
                        principalColumn: "DishID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_ChefDish_DishesDishID",
                table: "ChefDish",
                column: "DishesDishID");
        }
    }
}
