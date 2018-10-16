using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades
{
    public class Aluno : Pessoa
    {
        public Aluno()
        {
            this.Turmas = new List<Turma>();
        }
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        public string Matricula { get; set; }
        public virtual ICollection<Turma> Turmas { get; set; }
    }
}