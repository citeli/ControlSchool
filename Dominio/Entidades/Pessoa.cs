using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades
{
    public abstract class Pessoa
    {
        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        [MaxLength(50, ErrorMessage = "Máximo 50 Caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo 2 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        [MaxLength(50, ErrorMessage = "Máximo 50 Caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo 2 caracteres")]
        [DisplayName("Sobre Nome")]
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
        [DisplayName("Data de nascimento")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        [EmailAddress(ErrorMessage = "Preencha com um e-mail válido")]
        [MaxLength(80, ErrorMessage = "Máximo 80 Caracteres")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        [DisplayName("Número de telefone")]
        public string NumeroTelefone { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        [DisplayName("Número de celular")]
        public string NumeroCelular { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        [MaxLength(200, ErrorMessage = "Máximo 200 Caracteres")]
        [DisplayName("Endereço")]
        public string Endereco { get; set; }
    }
}