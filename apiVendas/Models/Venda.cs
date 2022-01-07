using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apiVendas.Models
{
    [Table("Venda")]
    public class Venda
    {
        public Venda()
        {
        }

        [Key]
        public int IdVenda { get; set; }

        [Required]
        [Display(Name = "Número Pedido")]
        public long NumeroPedido { get; set; }

        [Required]
        public int Cliente { get; set; }

        [Required]
        public int Vendedor { get; set; }

        [Required]
        public long Quantidade { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Nome Produto")]
        public String Produto { get; set; }

        [Required]
        [Range(0, 999999999.99)]
        public decimal ValorTotal { get; set; }
    }
}
