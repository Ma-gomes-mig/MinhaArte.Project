using MinhaArte.Project.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MinhaArte.Models
{
    //Não foi necessário expecificar "[Table('Quadro')]" pois por padrão o entity já reconhece como uma tabela com descrição que fiz na  classe DbContex.
    public class QuadroModel
    {
        [Key]
        public int QuadroId { get; set; }

        //[StringLength(100, ErrorMessage ="O tamanho máximo é 100 caractéres")]  (Ver se usando o regex abaixo precisa usar o StringLength)
        [Required(ErrorMessage = "Informe o nome da Categoria.")]
        [MaxLength(70, ErrorMessage = "O nome deve conter menos de 70 caracteres")]
        [Display(Name = "Informe o nome do Quadro")]
        public string QuadroNome { get; set; }

        [Display(Name = "Informe a Data de Criação")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        public DateTime DataCriacao { get; set; }

        [Required(ErrorMessage = "O valor precisa ser informado.")]
        [Display(Name = "Digite o valor do quadro")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1, 999999.99, ErrorMessage = "O valor deve estar entre 1 e 999.999,99")]
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "A descrição deve ser informada.")]
        [Display(Name = "Digite uma frase que combine ou descreva o quadro.")]
        [MinLength(5, ErrorMessage = "A descrição deve conter no min 5 caracteres.")]
        [MaxLength(30, ErrorMessage = "A descrição deve conter no máximo 30 caracteres.")]
        public string DescricaoCurta { get; set; }

        [Required(ErrorMessage = "A descrição deve ser informada.")]
        [Display(Name = "Digite uma descrição para o quadro.")]
        [MinLength(15, ErrorMessage = "A descrição deve conter no min 5 caracteres.")]
        [MaxLength(200, ErrorMessage = "A descrição deve conter no máximo 30 caracteres.")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "A imagem é obrigatoria")]
        [Display(Name = "Caminho Imagem Quadro")]
        [StringLength(300, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        public string ImagemUrl { get; set; }

        [Display(Name = "Caminho Imagem Quadro Miniatura")]
        [StringLength(300, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        public string ImagemThumbnailUrl { get; set; }

        [Required(ErrorMessage = "Informe o nome do Pintor.")]
        [MaxLength(100, ErrorMessage = "O nome deve conter menos de 100 caracteres")]
        [Display(Name = "Informe o nome do Pinto")]
        public string Pintor { get; set; }

        [Display(Name = "Digite aqui os materiais usados.")]
        [MinLength(5, ErrorMessage = "A descrição deve conter no min 5 caracteres.")]
        [MaxLength(100, ErrorMessage = "A descrição deve conter no máximo 100 caracteres.")]
        public string Material { get; set; }

        [Display(Name = "Preferido?")]
        public bool IsPreferido { get; set; }

        [Display(Name = "Disponível?")]
        public bool Disponivel { get; set; }

        public int CategoriaId { get; set; }
        public virtual CategoriaModel Categoria { get; set; }

        public int UsuarioId { get; set; }
        public virtual UsuarioModel Usuario { get; set; }

    }
}
