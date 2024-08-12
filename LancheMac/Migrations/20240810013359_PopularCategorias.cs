using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LancheMac.Migrations
{
    /// <inheritdoc />
    public partial class PopularCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert Into Categorias(CategoriaName, Descricao) " +
                "Values('Normal', 'Lanche feito com ingredientes normais')");

            migrationBuilder.Sql("Insert Into Categorias(CategoriaName, Descricao) " +
                "Values('Natural', 'Lanche feito com ingredientes integrais e naturais')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}
