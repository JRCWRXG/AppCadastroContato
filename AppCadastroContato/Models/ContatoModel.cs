using System.ComponentModel.DataAnnotations;

namespace AppCadastroContato.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite nome do contato")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Digite email do contato")]
        [EmailAddress(ErrorMessage = "o email não é valido")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Digite celular do contato")]
        [Phone(ErrorMessage ="Celular invalido")]
        public string? Celular { get; set; }
    }
}
