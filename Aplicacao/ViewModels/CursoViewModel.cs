using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Aplicacao.ViewModels
{
    public class CursoViewModel
    {
        public CursoViewModel()
        {
            this.Turmas = new List<TurmaViewModel>();
        }

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        [MaxLength(50, ErrorMessage = "Máximo 50 Caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo 2 caracteres")]
        [DisplayName("Nome do curso")]
        public string NomeCurso { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        [MaxLength(100, ErrorMessage = "Máximo 100 Caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo 2 caracteres")]
        [DisplayName("Descrição")]
        public string Descricao { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }


        public virtual ICollection<TurmaViewModel> Turmas { get; set; }
    }
}
