using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Colore_Entrega2.Models
{
    [Table("Curriculo")]
    public class Curriculo
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string? Nome { get; set; }
        
        [Required]
        public string? Sobrenome { get; set; }
        
        [Required]
        public string? Nome_Social { get; set; }
       
        [Required]
        public int CPF { get; set; }
       
        [Required]
        public int RG { get; set; }
        
        [Required]
        public string? Data_Nasc { get; set; }
       
        [Required]
        public int CEP { get; set; }
        
        [Required]
        public string? Endereco { get; set; }
       
        [Required]
        public int Numero { get; set; }
        
        [Required]
        public string? Complemento { get; set; }
        
        [Required]
        public string? Bairro { get; set; }
        
        [Required]
        public string? Cidade { get; set; }
       
        [Required]
        public string? UF { get; set; }
        
        [Required]
        public string? Pais { get; set; }
        
        [Required]
        public string? Area_Desejada { get; set; }
       
        [Required]
        public string? Experiencia { get; set; }
       
        [Required]
        public int Tempo { get; set; }
       
        [Required]
        public string? Escolaridade { get; set; }
       
        [Required]
        public string? Curso { get; set; }
        
        [Required]
        public string? Instituicao { get; set; }
    }
}
