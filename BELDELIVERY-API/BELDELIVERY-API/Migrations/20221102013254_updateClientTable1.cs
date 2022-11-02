using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BELDELIVERY_API.Migrations
{
    public partial class updateClientTable1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Client_ClientProfile_ClientProfileId",
                table: "Client");

            migrationBuilder.DropIndex(
                name: "IX_Client_ClientProfileId",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "ClientProfileId",
                table: "Client");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClientProfileId",
                table: "Client",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Client_ClientProfileId",
                table: "Client",
                column: "ClientProfileId");

            migrationBuilder.AddForeignKey(
                name: "FK_Client_ClientProfile_ClientProfileId",
                table: "Client",
                column: "ClientProfileId",
                principalTable: "ClientProfile",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
