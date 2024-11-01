using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SimplesSaborMVC.Migrations
{
    /// <inheritdoc />
    public partial class adicionadomaisingredientes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Ingrediente",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 2, "Pimentão" },
                    { 3, "Cebola" },
                    { 4, "Carne Moída" },
                    { 5, "Cream Cheese" },
                    { 6, "Queijo Cheddar" }
                });

            migrationBuilder.InsertData(
                table: "ReceitaIngrediente",
                columns: new[] { "IngredienteId", "ReceitaId", "Quantidade" },
                values: new object[,]
                {
                    { 2, 1, "1 unidade" },
                    { 3, 1, "1 unidade" },
                    { 4, 1, "x gramas" },
                    { 5, 1, "x gramas" },
                    { 6, 1, "x gramas" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ReceitaIngrediente",
                keyColumns: new[] { "IngredienteId", "ReceitaId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "ReceitaIngrediente",
                keyColumns: new[] { "IngredienteId", "ReceitaId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "ReceitaIngrediente",
                keyColumns: new[] { "IngredienteId", "ReceitaId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "ReceitaIngrediente",
                keyColumns: new[] { "IngredienteId", "ReceitaId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "ReceitaIngrediente",
                keyColumns: new[] { "IngredienteId", "ReceitaId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "Ingrediente",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ingrediente",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ingrediente",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ingrediente",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ingrediente",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
