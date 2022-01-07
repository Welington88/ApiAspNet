using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apiVendas.Models
{
    [Table("Vendedor")]
    public class Vendedor
    {
        public Vendedor()
        {
        }

        [Key]
        public int IdVendedor { get; set; }

        [Display(Name = "Nome")]
        [Required]
        [StringLength(50)]
        public String NomeVendedor { get; set; }
    }
}
