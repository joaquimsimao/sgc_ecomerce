namespace ComprasNerd.Web.Models
{
    public class ProdutoModel
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public string Descricao { get; set; }
        public string Categoria { get; set; }
        public string UrlImagem { get; set; }
    }
}
