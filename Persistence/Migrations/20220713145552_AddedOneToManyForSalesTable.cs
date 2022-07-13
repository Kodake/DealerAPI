using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddedOneToManyForSalesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Sellers_SellerId1",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Sales_SellerId1",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "SellerId1",
                table: "Sales");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SellerId1",
                table: "Sales",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sales_SellerId1",
                table: "Sales",
                column: "SellerId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Sellers_SellerId1",
                table: "Sales",
                column: "SellerId1",
                principalTable: "Sellers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
