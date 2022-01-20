using ComprasNerd.ProdutoAPI.Model.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComprasNerd.ProdutoAPI.Model
{
    [Table("produto")]
    public class Produto : BaseEntity
    {
        [Column("nome")]
        [Required]
        [StringLength(150)]
        public string Nome { get; set; }

        [Column("preco")]
        [Required]
        [Range(1, 10000)]
        public decimal Preco { get; set; }
        [Column("descricao")]
        [StringLength(500)]
        public string Descricao { get; set; }

        [Column("categoria")]
        [StringLength(50)]
        public string Categoria { get; set; }

        [Column("url_imagem")]
        [StringLength(300)]
        public string UrlImagem { get; set; }
       
    }
}
