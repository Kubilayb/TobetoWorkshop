using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Add_Color_test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductColors_ColorsGood_ColorId",
                table: "ProductColors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ColorsGood",
                table: "ColorsGood");

            migrationBuilder.DeleteData(
                table: "ColorsGood",
                keyColumn: "ColorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.RenameTable(
                name: "ColorsGood",
                newName: "Colors");

            migrationBuilder.AlterColumn<string>(
                name: "ColorName",
                table: "Colors",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Colors",
                table: "Colors",
                column: "ColorId");

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "ColorId", "ColorName" },
                values: new object[] { 2, "Lacivert" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Price", "ProductName", "Size", "Stock" },
                values: new object[] { 2, 2500.0, "Elbise", "L", 15 });

            migrationBuilder.AddForeignKey(
                name: "FK_ProductColors_Colors_ColorId",
                table: "ProductColors",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "ColorId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductColors_Colors_ColorId",
                table: "ProductColors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Colors",
                table: "Colors");

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.RenameTable(
                name: "Colors",
                newName: "ColorsGood");

            migrationBuilder.AlterColumn<string>(
                name: "ColorName",
                table: "ColorsGood",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ColorsGood",
                table: "ColorsGood",
                column: "ColorId");

            migrationBuilder.InsertData(
                table: "ColorsGood",
                columns: new[] { "ColorId", "ColorName" },
                values: new object[] { 1, "Kırmızı" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Price", "ProductName", "Size", "Stock" },
                values: new object[] { 1, 150.0, "Kazak", "XL", 50 });

            migrationBuilder.AddForeignKey(
                name: "FK_ProductColors_ColorsGood_ColorId",
                table: "ProductColors",
                column: "ColorId",
                principalTable: "ColorsGood",
                principalColumn: "ColorId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
