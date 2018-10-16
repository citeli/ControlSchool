using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades
{
    public class Professor : Pessoa
    {
        public Professor()
        {
            this.Turmas = new List<Turma>();
        }

        [Key]
        public int Id { get; set; }
        public ICollection<Turma> Turmas { get; set; }
    }
}