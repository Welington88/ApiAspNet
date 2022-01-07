using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apiVendas.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        public Cliente()
        {
        }

        [Key]
        public int IdCliente { get; set; }

        [Required]
        [StringLength(50)]
        public String Nome { get; set; }

        [Display(Name="Endereço")]
        [StringLength(100)]
        public String Endereco { get; set; }
    }
}
