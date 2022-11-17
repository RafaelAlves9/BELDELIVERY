using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BELDELIVERY_API.Migrations
{
    public partial class changetables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MainAddress",
                table: "StoreAddress");

            migrationBuilder.DropColumn(
                name: "MainAddress",
                table: "ClientAddress");

            migrationBuilder.RenameColumn(
                name: "MainColor",
                table: "StoreProfile",
                newName: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "StoreProfile",
                newName: "MainColor");

            migrationBuilder.AddColumn<bool>(
                name: "MainAddress",
                table: "StoreAddress",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "MainAddress",
                table: "ClientAddress",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
