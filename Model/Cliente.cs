using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace TrabalhoReact.Model
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(70)]
        public string Nome { get; set; }
        [Required]
        public int Idade { get; set; }
        [Required]
        [StringLength(50)]
        public string Endereco { get; set; }
        [Required]
        [StringLength (14)]
        public string CPF { get; set; }
        [Required]
        [StringLength(20)]
        public string Telefone { get; set; }
        [Required]
        [StringLength(1)]
        public string Sexo { get; set; }
        [AllowNull]
        public int RG { get; set; }
    }
}
