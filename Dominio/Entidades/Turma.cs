using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entidades
{
    public class Turma
    {
        public Turma()
        {
            this.Alunos = new List<Aluno>();
            this.Professores = new List<Professor>();
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


        public virtual ICollection<Aluno> Alunos { get; set; }
        public virtual ICollection<Professor> Professores { get; set; }

        [Required]
        [ScaffoldColumn(false)]
        public int CursoId { get; set; }
        [ForeignKey("CursoId")]
        public Curso Curso { get; set; }
    }
}