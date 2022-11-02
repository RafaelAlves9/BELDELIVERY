using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BELDELIVERY_API.Migrations
{
    public partial class updateClientTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "StoreAddress",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Product",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Orders",
                table: "ClientProfile",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "StoreProfileId",
                table: "Client",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_StoreAddress_ClientId",
                table: "StoreAddress",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ClientId",
                table: "Product",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Client_StoreProfileId",
                table: "Client",
                column: "StoreProfileId");

            migrationBuilder.AddForeignKey(
                name: "FK_Client_StoreProfile_StoreProfileId",
                table: "Client",
                column: "StoreProfileId",
                principalTable: "StoreProfile",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Client_ClientId",
                table: "Product",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StoreAddress_Client_ClientId",
                table: "StoreAddress",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Client_StoreProfile_StoreProfileId",
                table: "Client");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Client_ClientId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_StoreAddress_Client_ClientId",
                table: "StoreAddress");

            migrationBuilder.DropIndex(
                name: "IX_StoreAddress_ClientId",
                table: "StoreAddress");

            migrationBuilder.DropIndex(
                name: "IX_Product_ClientId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Client_StoreProfileId",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "StoreAddress");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "StoreProfileId",
                table: "Client");

            migrationBuilder.AlterColumn<string>(
                name: "Orders",
                table: "ClientProfile",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
