using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class order_orderdetail_update2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetailsS_Products_ProductId",
                table: "OrderDetailsS");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "ProductS");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CategoryId",
                table: "ProductS",
                newName: "IX_ProductS_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductS",
                table: "ProductS",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetailsS_ProductS_ProductId",
                table: "OrderDetailsS",
                column: "ProductId",
                principalTable: "ProductS",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductS_Categories_CategoryId",
                table: "ProductS",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetailsS_ProductS_ProductId",
                table: "OrderDetailsS");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductS_Categories_CategoryId",
                table: "ProductS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductS",
                table: "ProductS");

            migrationBuilder.RenameTable(
                name: "ProductS",
                newName: "Products");

            migrationBuilder.RenameIndex(
                name: "IX_ProductS_CategoryId",
                table: "Products",
                newName: "IX_Products_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetailsS_Products_ProductId",
                table: "OrderDetailsS",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
