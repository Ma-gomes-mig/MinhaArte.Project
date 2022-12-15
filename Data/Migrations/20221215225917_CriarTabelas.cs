using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MinhaArte.Project.Data.Migrations
{
    /// <inheritdoc />
    public partial class CriarTabelas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoriaNome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CategoriaDescricao = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.CategoriaId);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioNome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UsuarioSobreNome = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    FormaPg = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ImagemUrl = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ImagemThumbnailUrl = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.UsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "Quadro",
                columns: table => new
                {
                    QuadroId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuadroNome = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Preco = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    DescricaoCurta = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ImagemUrl = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    ImagemThumbnailUrl = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Pintor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Material = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsPreferido = table.Column<bool>(type: "bit", nullable: false),
                    Disponivel = table.Column<bool>(type: "bit", nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quadro", x => x.QuadroId);
                    table.ForeignKey(
                        name: "FK_Quadro_Categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categoria",
                        principalColumn: "CategoriaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Quadro_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Quadro_CategoriaId",
                table: "Quadro",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Quadro_UsuarioId",
                table: "Quadro",
                column: "UsuarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Quadro");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
