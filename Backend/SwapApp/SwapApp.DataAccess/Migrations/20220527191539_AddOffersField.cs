using Microsoft.EntityFrameworkCore.Migrations;

namespace SwapApp.DataAccess.Migrations
{
    public partial class AddOffersField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductID",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductID",
                table: "Products",
                column: "ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Products_ProductID",
                table: "Products",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Products_ProductID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductID",
                table: "Products");
        }
    }
}
