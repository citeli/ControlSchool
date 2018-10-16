using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Aplicacao.ViewModels
{
    public class ProfessorViewModel : PessoaViewModel
    {
        public ProfessorViewModel()
        {
            this.Turmas = new List<TurmaViewModel>();
        }

        [Key]
        public int Id { get; set; }
        public ICollection<TurmaViewModel> Turmas { get; set; }
    }
}
