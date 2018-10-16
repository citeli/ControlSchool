using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Aplicacao.ViewModels
{
    public class AlunoViewModel : PessoaViewModel
    {
        public AlunoViewModel()
        {
            this.Turmas = new List<TurmaViewModel>();
        }
        
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        [DisplayName("Matrícula")]
        public string Matricula { get; set; }
        public virtual ICollection<TurmaViewModel> Turmas { get; set; }
    }
}
