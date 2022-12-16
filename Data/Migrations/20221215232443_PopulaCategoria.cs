using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MinhaArte.Project.Data.Migrations
{
    /// <inheritdoc />
    public partial class PopulaCategoria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categoria(CategoriaNome, CategoriaDescricao) " +
                            "VALUES('Pintura à Oleo', 'Pintura usando tinta à oleo.')");

            migrationBuilder.Sql("INSERT INTO Categoria(CategoriaNome, CategoriaDescricao) " +
                "VALUES('Aquarela', 'A pintura de aquarela geralmente é feita no papel.')");

            migrationBuilder.Sql("INSERT INTO Categoria(CategoriaNome, CategoriaDescricao) " +
                "VALUES('Pintura à Têmpera', 'Têmpera é um meio de pintura permanente e de secagem rápida')");

            migrationBuilder.Sql("INSERT INTO Categoria(CategoriaNome, CategoriaDescricao) " +
                "VALUES('Pintura Acrilica', 'Estas são pinturas solúveis em água, torna-se resistente à água')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categoria");
        }
    }
}
