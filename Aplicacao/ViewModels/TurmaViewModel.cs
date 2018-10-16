using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Dominio.Entidades;

namespace Aplicacao.ViewModels
{
    public class TurmaViewModel
    {
        public TurmaViewModel()
        {
            this.Alunos = new List<AlunoViewModel>();
            this.Professores = new List<ProfessorViewModel>();
        }
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date, ErrorMessage = "Formato inválido de data")]
        public DateTime DataInicio { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date, ErrorMessage = "Formato inválido de data")]
        public DateTime DataFim { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        [MaxLength(50, ErrorMessage = "Máximo 50 Caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo 2 caracteres")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        [MaxLength(20, ErrorMessage = "Máximo 20 Caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo 2 caracteres")]
        public string Horario { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }


        public virtual ICollection<AlunoViewModel> Alunos { get; set; }
        public virtual ICollection<ProfessorViewModel> Professores { get; set; }

        [Required]
        [ScaffoldColumn(false)]
        public int CursoId { get; set; }
        [ForeignKey("CursoId")]
        public Curso CursoViewModel { get; set; }
    }
}
