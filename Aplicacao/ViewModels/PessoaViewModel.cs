using System;
using System.ComponentModel.DataAnnotations;

namespace Aplicacao.ViewModels
{
    public class PessoaViewModel
    {
        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        [MaxLength(50, ErrorMessage = "Máximo 50 Caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo 2 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        [MaxLength(50, ErrorMessage = "Máximo 50 Caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo 2 caracteres")]
        public string SobreNome { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        [MaxLength(23, ErrorMessage = "Máximo 23 Caracteres")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        [MaxLength(12, ErrorMessage = "Máximo 12 Caracteres")]
        public string Rg { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date, ErrorMessage = "Formato inválido de data")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        [EmailAddress(ErrorMessage = "Preencha com um e-mail válido")]
        [MaxLength(80, ErrorMessage = "Máximo 80 Caracteres")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        public string NumeroTelefone { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        public string NumeroCelular { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        [MaxLength(200, ErrorMessage = "Máximo 200 Caracteres")]
        public string Endereco { get; set; }
    }
}
