using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace MinhaArte.Models
{
    //Não foi necessário expecificar "[Table('Categoria')]" pois por padrão o entity já reconhece como uma tabela com descrição que fiz na  classe DbContex.
    public class CategoriaModel
    {
        [Key]
        public int CategoriaId { get; set; }
        //[StringLength(100, ErrorMessage ="O tamanho máximo é 100 caractéres")]  (Ver se usando o regex abaixo precisa usar o StringLength)
        [Required(ErrorMessage = "Informe o nome da Categoria.")]
        [MaxLength(50, ErrorMessage = "O nome deve conter menos de 50 caracteres")]
        [Display(Name = "Informe o nome da Categoria")]
        public string CategoriaNome { get; set; }


        [StringLength(100, ErrorMessage = "O tamanho máximo é 100 caractéres")]
        [Required(ErrorMessage = "Informe o nome da Categoria.")]
        //[RegularExpression("^[A-Za-zÀ-Üà-ü\\s]{6,100}$", ErrorMessage = "Erro. Nome inválido.")]  (No caso da descrição não achei necessário)
        [Display(Name = "Informe o nome da Categoria")]
        public string CategoriaDescricao { get; set; }
        public List<QuadroModel> Quadros { get; set; }
    }
}
