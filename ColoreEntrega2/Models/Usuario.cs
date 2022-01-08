using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Colore_Entrega2.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public int id { get; set; }
    }
}
