using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Colore_Entrega2.Models
{
    [Table("Vagas")]
    public class Vagas
    {
        [Key]
        public int id { get; set; }
        public string? titulo { get; set; }
        public double salario { get; set; }        
        public string? descricao { get; set; }
        public string? beneficios { get; set; }        
        public string? area { get; set; }
        //Requisitos
        public string? escolaridade { get; set; }
        public int? experiencia{ get; set; }
        public int? experienciaArea{ get; set; }
        public string? idiomas { get; set; }

        [ForeignKey("Empresa")]
        public int idEmpresa { get; set; }
    }
}
