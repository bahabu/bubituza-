using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bubituzagi.Migrations
{
    public partial class baha06011 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Posts",
                type: "image",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Posts");
        }
    }
}
