using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MinhaArte.Project.Data.Migrations
{
    /// <inheritdoc />
    public partial class AtualizaPopulaQuadro : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Quadro(CategoriaId,UsuarioId,QuadroNome,DataCriacao,Preco,DescricaoCurta,Descricao,ImagemUrl,Pintor,IsPreferido,Disponivel) " +
               "VALUES(4,4,'El Maricón','02/02/1502',19999.25,'Uma obra muito hermosa'," +
               "'Uma frase para usar como exemplo multiplicada Uma frase para usar como exemplo multiplicada Uma frase para usar como exemplo multiplicada'," +
               "'C:\\Users\\mathe\\source\\repos\\MinhaArte.Project\\MinhaArte.Project\\wwwroot\\Images\\download (1).jpg','O Grande',1,1)");

            migrationBuilder.Sql("INSERT INTO Quadro(CategoriaId,UsuarioId,QuadroNome,DataCriacao,Preco,DescricaoCurta,Descricao,ImagemUrl,Pintor,IsPreferido,Disponivel) " +
               "VALUES(5,5,'O bajulador','05/10/1855',1008.25,'Olha essa arte'," +
               "'Uma frase para usar como exemplo multiplicada Uma frase para usar como exemplo multiplicada Uma frase para usar como exemplo multiplicada'," +
               "'C:\\Users\\mathe\\source\\repos\\MinhaArte.Project\\MinhaArte.Project\\wwwroot\\Images\\download.jpg','El caj',0,1)");

            migrationBuilder.Sql("INSERT INTO Quadro(CategoriaId,UsuarioId,QuadroNome,DataCriacao,Preco,DescricaoCurta,Descricao,ImagemUrl,Pintor,IsPreferido,Disponivel) " +
               "VALUES(6,6,'O suprasumo','10/11/1020',1258.25,'Parece um espelho sem forma'," +
               "'Uma frase para usar como exemplo multiplicada Uma frase para usar como exemplo multiplicada Uma frase para usar como exemplo multiplicada'," +
               "'C:\\Users\\mathe\\source\\repos\\MinhaArte.Project\\MinhaArte.Project\\wwwroot\\Images\\images.jpg','El G',1,1)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categoria");
        }
    }
}
