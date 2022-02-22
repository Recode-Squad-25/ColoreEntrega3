using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Colore_Entrega2.Models
{
    [Table("Empresa")]
    public class Empresa
    {
        [Key]
        public int id { get; set; }
        public string? nome { get; set; }
        public string? email { get; set; }
        public string? senha { get; set; }
        public string? telefone { get; set; }
        public string? cnpj { get; set; }

        public string? image { get; set; }
    }
}