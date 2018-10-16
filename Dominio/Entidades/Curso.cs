using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Curso
    {
        public Curso()
        {
            this.Turmas = new List<Turma>();
        }

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        [MaxLength(50, ErrorMessage = "Máximo 50 Caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo 2 caracteres")]
        public string NomeCurso { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        [MaxLength(100, ErrorMessage = "Máximo 100 Caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo 2 caracteres")]
        public string Descricao { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }


        public virtual ICollection<Turma> Turmas { get; set; }

    }
}
