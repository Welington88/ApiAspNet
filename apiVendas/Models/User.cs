using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apiVendas.Models
{
    [Table("Usuarios")]
    public class User
    {
        [Key]
        public int UsuarioId { get; set; }

        [Required]
        [Column("user")]
        public String Nome { get; set; }
        
        [Required]
        [Column("password")]
        public String Senha { get; set; }

        [Column("user_name")]
        [Required]
        public String Email { get; set; }
    }
}