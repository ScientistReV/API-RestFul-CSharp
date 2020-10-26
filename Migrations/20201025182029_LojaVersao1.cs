using Microsoft.EntityFrameworkCore.Migrations;

namespace Loja.Migrations
{
    public partial class LojaVersao1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Bicicletas",
                table: "Bicicletas");

            migrationBuilder.RenameTable(
                name: "Bicicletas",
                newName: "Bicicleta");

            migrationBuilder.AlterColumn<decimal>(
                name: "Preco",
                table: "Bicicleta",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Modelo",
                table: "Bicicleta",
                type: "varchar(120)",
                maxLength: 120,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bicicleta",
                table: "Bicicleta",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Bicicleta",
                table: "Bicicleta");

            migrationBuilder.RenameTable(
                name: "Bicicleta",
                newName: "Bicicletas");

            migrationBuilder.AlterColumn<decimal>(
                name: "Preco",
                table: "Bicicletas",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<string>(
                name: "Modelo",
                table: "Bicicletas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(120)",
                oldMaxLength: 120);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bicicletas",
                table: "Bicicletas",
                column: "Id");
        }
    }
}
