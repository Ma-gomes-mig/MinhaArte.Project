using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MinhaArte.Project.Data.Migrations
{
    /// <inheritdoc />
    public partial class PopulaUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Usuario(UsuarioNome,UsuarioSobrenome,DataNascimento,CPF,FormaPg,Endereco,ImagemUrl) " +
                            "VALUES('Matheus','Gomes','03/10/1993','104.696.598-89','Cartão','Rio de Janeiro','C:\\Users\\mathe\\source\\repos\\MinhaArte\\MinhaArte\\Img\\Usuario1.jpg,')");

            migrationBuilder.Sql("INSERT INTO Usuario(UsuarioNome,UsuarioSobrenome,DataNascimento,CPF,FormaPg,Endereco,ImagemUrl) " +
                "VALUES('Miguel','Gomes','03/10/2014','185.669.874-52','Cartão','Estados Unidos','C:\\Users\\mathe\\source\\repos\\MinhaArte\\MinhaArte\\Img\\Usuario2.jpg,')");

            migrationBuilder.Sql("INSERT INTO Usuario(UsuarioNome,UsuarioSobrenome,DataNascimento,CPF,FormaPg,Endereco,ImagemUrl) " +
                "VALUES('Eliane','Almeida','03/10/1885','104.855.633-10','Cartão','Rio Grande do Sul','C:\\Users\\mathe\\source\\repos\\MinhaArte\\MinhaArte\\Img\\Usuario3.jpg,')");

           
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categoria");
        }
    }
}

