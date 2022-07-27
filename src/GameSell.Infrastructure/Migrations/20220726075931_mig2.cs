using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameSell.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GameCategoryId",
                table: "Games",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "GameCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameCategory", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Games_GameCategoryId",
                table: "Games",
                column: "GameCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_GameCategory_GameCategoryId",
                table: "Games",
                column: "GameCategoryId",
                principalTable: "GameCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_GameCategory_GameCategoryId",
                table: "Games");

            migrationBuilder.DropTable(
                name: "GameCategory");

            migrationBuilder.DropIndex(
                name: "IX_Games_GameCategoryId",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "GameCategoryId",
                table: "Games");
        }
    }
}
