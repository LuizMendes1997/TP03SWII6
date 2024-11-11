using System.ComponentModel.DataAnnotations;

namespace SistemaTP03.Models
{
    public class Produto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do produto é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome do produto deve ter no máximo 100 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A descrição do produto é obrigatória.")]
        [StringLength(500, ErrorMessage = "A descrição do produto deve ter no máximo 500 caracteres.")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O preço do produto é obrigatório.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "O preço deve ser maior que zero.")]
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "A quantidade em estoque é obrigatória.")]
        [Range(0, int.MaxValue, ErrorMessage = "A quantidade em estoque não pode ser negativa.")]
        public int QuantidadeEmEstoque { get; set; }
    }
}
