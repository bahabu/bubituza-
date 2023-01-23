using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bubituzagi.Migrations
{
    public partial class baha30 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Categories_CategortyId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_CategortyId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "CategortyId",
                table: "Posts");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CatogryId",
                table: "Posts",
                column: "CatogryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Categories_CatogryId",
                table: "Posts",
                column: "CatogryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Categories_CatogryId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_CatogryId",
                table: "Posts");

            migrationBuilder.AddColumn<short>(
                name: "CategortyId",
                table: "Posts",
                type: "smallint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CategortyId",
                table: "Posts",
                column: "CategortyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Categories_CategortyId",
                table: "Posts",
                column: "CategortyId",
                principalTable: "Categories",
                principalColumn: "Id");
        }
    }
}
