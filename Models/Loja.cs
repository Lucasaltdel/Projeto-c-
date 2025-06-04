using System.ComponentModel.DataAnnotations;

namespace portal_cliente.csproj.Models
{
    public class Loja
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo CEP é obrigatório.")]
        [Display(Name = "CEP")]
        [StringLength(9, MinimumLength = 8, ErrorMessage = "CEP deve ter entre 8 e 9 caracteres.")]
        public string Cep { get; set; } = string.Empty;

        [Required(ErrorMessage = "O campo Rua é obrigatório.")]
        [Display(Name = "Rua")]
        public string Rua { get; set; } = string.Empty;

        [Required(ErrorMessage = "O campo Número é obrigatório.")]
        [Display(Name = "Número")]
        public string Numero { get; set; } = string.Empty;

        [Display(Name = "Complemento")]
        public string? Complemento { get; set; }

        [Required(ErrorMessage = "O campo Bairro é obrigatório.")]
        [Display(Name = "Bairro")]
        public string Bairro { get; set; } = string.Empty;

        [Required(ErrorMessage = "O campo Cidade é obrigatório.")]
        [Display(Name = "Cidade")]
        public string Cidade { get; set; } = string.Empty;

        [Required(ErrorMessage = "O campo UF é obrigatório.")]
        [Display(Name = "UF")]
        [StringLength(2, MinimumLength = 2, ErrorMessage = "UF deve ter 2 caracteres.")]
        public string Uf { get; set; } = string.Empty;

        [Required(ErrorMessage = "O campo Nome Fantasia é obrigatório.")]
        [Display(Name = "Nome Fantasia")]
        public string NomeFantasia { get; set; } = string.Empty;

        [Required(ErrorMessage = "O campo Seguimento é obrigatório.")]
        [Display(Name = "Seguimento")]
        public string Seguimento { get; set; } = string.Empty;

        [Required(ErrorMessage = "O campo Razão Social é obrigatório.")]
        [Display(Name = "Razão Social")]
        public string RazaoSocial { get; set; } = string.Empty;

        [Required(ErrorMessage = "O campo CNPJ é obrigatório.")]
        [Display(Name = "CNPJ")]
        [StringLength(18, MinimumLength = 14, ErrorMessage = "CNPJ deve ter entre 14 e 18 caracteres (com ou sem formatação).")]
        public string Cnpj { get; set; } = string.Empty;

        [Required(ErrorMessage = "O campo E-mail Comercial é obrigatório.")]
        [EmailAddress(ErrorMessage = "Formato de E-mail inválido.")]
        [Display(Name = "E-mail Comercial")]
        public string Email { get; set; } = string.Empty;

        
    }
}
