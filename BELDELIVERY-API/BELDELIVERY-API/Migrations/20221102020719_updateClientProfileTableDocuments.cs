using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BELDELIVERY_API.Migrations
{
    public partial class updateClientProfileTableDocuments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Document",
                table: "Client");

            migrationBuilder.AddColumn<string>(
                name: "Document",
                table: "ClientProfile",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Document",
                table: "ClientProfile");

            migrationBuilder.AddColumn<string>(
                name: "Document",
                table: "Client",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
