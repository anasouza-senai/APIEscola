using System.ComponentModel.DataAnnotations;

namespace APIEscola.Models
{
    public class Turma
    {
        public Guid TurmaId { get; set; }

        [Required(ErrorMessage = "O Campo Curso é Obrigatório")]
        public Guid CursoId { get; set; }

        [Required(ErrorMessage = "O Campo Data de Início é Obrigatório")]
        [DataType(DataType.Date, ErrorMessage = "A Data de Início deve ser uma data válida")]
        public DateTime DataInicio { get; set; }

        [Required(ErrorMessage = "O Campo Data de Fim é Obrigatório")]
        [DataType(DataType.Date, ErrorMessage = "A Data de Fim deve ser uma data válida")]
        public DateTime DataFim { get; set; }

        [Required(ErrorMessage = "O Campo Descrição é Obrigatório")]
        [StringLength(200, ErrorMessage = "A Descrição deve ter no máximo 200 caracteres")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O Campo Sigla é Obrigatório")]
        [StringLength(10, ErrorMessage = "A Sigla deve ter no máximo 10 caracteres")]
        public string Sigla { get; set; }
    }
}
