using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class order_orderdetail_update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Orders_OrderId",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Productss_ProductId",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Productss_Categories_CategoryId",
                table: "Productss");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Productss",
                table: "Productss");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails");

            migrationBuilder.RenameTable(
                name: "Productss",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "OrderDetails",
                newName: "OrderDetailsS");

            migrationBuilder.RenameIndex(
                name: "IX_Productss_CategoryId",
                table: "Products",
                newName: "IX_Products_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetailsS",
                newName: "IX_OrderDetailsS_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetailsS",
                newName: "IX_OrderDetailsS_OrderId");

            migrationBuilder.AlterColumn<double>(
                name: "TotalPrice",
                table: "OrderDetailsS",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderDetailsS",
                table: "OrderDetailsS",
                column: "OrderDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetailsS_Orders_OrderId",
                table: "OrderDetailsS",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetailsS_Orders_OrderId",
                table: "OrderDetailsS");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetailsS_Products_ProductId",
                table: "OrderDetailsS");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderDetailsS",
                table: "OrderDetailsS");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Productss");

            migrationBuilder.RenameTable(
                name: "OrderDetailsS",
                newName: "OrderDetails");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CategoryId",
                table: "Productss",
                newName: "IX_Productss_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetailsS_ProductId",
                table: "OrderDetails",
                newName: "IX_OrderDetails_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetailsS_OrderId",
                table: "OrderDetails",
                newName: "IX_OrderDetails_OrderId");

            migrationBuilder.AlterColumn<int>(
                name: "TotalPrice",
                table: "OrderDetails",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Productss",
                table: "Productss",
                column: "ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails",
                column: "OrderDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Orders_OrderId",
                table: "OrderDetails",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Productss_ProductId",
                table: "OrderDetails",
                column: "ProductId",
                principalTable: "Productss",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Productss_Categories_CategoryId",
                table: "Productss",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
