using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Colore_Entrega2.Models
{
    [Table("Curriculo")]
    public class Curriculo
    {
        [Key]
        public int id { get; set; }
    }
}
