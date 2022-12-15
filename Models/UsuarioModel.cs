using MinhaArte.Project.Models;
using System.ComponentModel.DataAnnotations;

namespace MinhaArte.Models
{
    //Não foi necessário expecificar "[Table('Quadro')]" pois por padrão o entity já reconhece como uma tabela com descrição que fiz na  classe DbContex.
    public class UsuarioModel
    {

        [Key]
        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "Informe o nome do Usuario.")]
        [MaxLength(50, ErrorMessage = "O nome deve conter menos de 50 caracteres")]
        [Display(Name = "Informe o nome do Usuario")]
        public string UsuarioNome { get; set; }

        [Required(ErrorMessage = "Informe o Sobrenome do Usuario.")]
        [MaxLength(70, ErrorMessage = "O nome deve conter menos de 70 caracteres")]
        [Display(Name = "Informe o Sobrenome do Usuario.")]
        public string UsuarioSobreNome { get; set; }

        [Display(Name = "Informe a Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "O Cpf deve ser informado.")]
        [Display(Name = "Digite seu Cpf.")]
        [MinLength(10, ErrorMessage = "O cpf está errado")]
        [MaxLength(15, ErrorMessage = "O cpf está errado")]
        public string CPF { get; set; }


        [Display(Name = "Qual a forma de pagamento ?")]
        [MinLength(5, ErrorMessage = "A descrição deve conter no min 5 caracteres.")]
        [MaxLength(30, ErrorMessage = "A descrição deve conter no máximo 30 caracteres.")]
        public string FormaPg { get; set; }

        [Required(ErrorMessage = "O Endereço deve ser informado")]
        [Display(Name = "digite seu endereço.")]
        [MinLength(5, ErrorMessage = "A descrição deve conter no min 5 caracteres.")]
        [MaxLength(30, ErrorMessage = "A descrição deve conter no máximo 30 caracteres.")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "A imagem é obrigatoria")]
        [Display(Name = "Caminho Imagem Usuario")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        public string ImagemUrl { get; set; }


        [Display(Name = "Caminho Imagem Usuario")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        public string ImagemThumbnailUrl { get; set; }
        public List<QuadroModel> Quadros { get; set; }
    }
}
