using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bubituzagi.Migrations
{
    public partial class baha0201 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AuthotId",
                table: "Posts",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Delete",
                table: "AspNetUsers",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "nchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_AuthotId",
                table: "Posts",
                column: "AuthotId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_AspNetUsers_AuthotId",
                table: "Posts",
                column: "AuthotId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_AspNetUsers_AuthotId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_AuthotId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "AuthotId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "Delete",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");
        }
    }
}
