using System.ComponentModel.DataAnnotations;

namespace ColoreEntrega2.Models
{
    public class SendEmailDto
    {
        [Required]
        public string? Nome { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Telefone { get; set; }
        [Required]
        public string? Assunto { get; set; }
        [Required]
        public string? Mensagem { get; set; }

        public string? Body { get; set; }

        public string? To { get; set; }

        public string? From { get; set; }

        public string? Subject { get; set; }

        public string? Content { get; set; }
    }
}
