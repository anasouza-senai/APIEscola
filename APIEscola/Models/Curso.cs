using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.ComponentModel.DataAnnotations;
using System.Runtime.ConstrainedExecution;

namespace APIEscola.Models
{
    public class Curso
    {
        public Guid CursoId { get; set; }

        [Required(ErrorMessage = "O Campo Sigla é Obrigatório")]
        [StringLength(10, ErrorMessage = "A Sigla deve ter no máximo 10 caracteres")]
        public string? Sigla { get; set; }

        [Required(ErrorMessage = "O Campo Descrição é Obrigatório")]
        [StringLength(200, ErrorMessage = "A Descrição deve ter no máximo 200 caracteres")]
        public string? Descricao { get; set; }
    }
}
