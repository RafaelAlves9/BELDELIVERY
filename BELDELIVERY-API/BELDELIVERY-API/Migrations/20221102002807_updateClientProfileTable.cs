using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BELDELIVERY_API.Migrations
{
    public partial class updateClientProfileTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "StoreAddress");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Product");

            migrationBuilder.RenameColumn(
                name: "StoreProfileId",
                table: "Client",
                newName: "ClientProfileId");

            migrationBuilder.RenameIndex(
                name: "IX_Client_StoreProfileId",
                table: "Client",
                newName: "IX_Client_ClientProfileId");

            migrationBuilder.AlterColumn<string>(
                name: "TittleStatus",
                table: "ClientProfile",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "TellPhone",
                table: "ClientProfile",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CellPhone",
                table: "ClientProfile",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_Client_ClientProfile_ClientProfileId",
                table: "Client",
                column: "ClientProfileId",
                principalTable: "ClientProfile",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Client_ClientProfile_ClientProfileId",
                table: "Client");

            migrationBuilder.RenameColumn(
                name: "ClientProfileId",
                table: "Client",
                newName: "StoreProfileId");

            migrationBuilder.RenameIndex(
                name: "IX_Client_ClientProfileId",
                table: "Client",
                newName: "IX_Client_StoreProfileId");

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

            migrationBuilder.AlterColumn<string>(
                name: "TittleStatus",
                table: "ClientProfile",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TellPhone",
                table: "ClientProfile",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CellPhone",
                table: "ClientProfile",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StoreAddress_ClientId",
                table: "StoreAddress",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ClientId",
                table: "Product",
                column: "ClientId");

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
    }
}
