using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoCRUD.Models
{
    [Table ("Produtos")]
    public class Produto
    {
        [Column ("Id")]
        [Display (Name = "Id")]

        public int Id { get; set; }

        [Column ("Descricao")]
        [Display (Name = "Descricao")]

        public string Descricao { get; set; }
    }
}
