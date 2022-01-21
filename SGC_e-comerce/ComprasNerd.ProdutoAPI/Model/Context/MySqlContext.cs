
using Microsoft.EntityFrameworkCore;


namespace ComprasNerd.ProdutoAPI.Model.Context
{
    public class MySqlContext: DbContext
    {
        public MySqlContext(){ }
        
        public MySqlContext(DbContextOptions<MySqlContext> options):base(options) { }

        public DbSet<Produto> Produto { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id=5,
                Nome = "Nome",
                Preco = new decimal(69.9),
                Descricao = "Teste de inserção via OnModelCreating",
                UrlImagem = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/00_no_image.jpg",
                Categoria = "Camiseta"

            });

            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 6,
                Nome = "Nome",
                Preco = new decimal(40.9),
                Descricao = "Teste de inserção via OnModelCreating 2",
                UrlImagem = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/00_no_image.jpg",
                Categoria = "Camiseta"

            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 7,
                Nome = "Nome",
                Preco = new decimal(80.9),
                Descricao = "Teste de inserção via OnModelCreating 3",
                UrlImagem = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/00_no_image.jpg",
                Categoria = "Camiseta"

            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 8,
                Nome = "Nome",
                Preco = new decimal(10.9),
                Descricao = "Teste de inserção via OnModelCreating 4",
                UrlImagem = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/00_no_image.jpg",
                Categoria = "Camiseta"

            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 9,
                Nome = "Nome",
                Preco = new decimal(180.9),
                Descricao = "Teste de inserção via OnModelCreating 5",
                UrlImagem = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/00_no_image.jpg",
                Categoria = "Camiseta"

            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 10,
                Nome = "Nome",
                Preco = new decimal(325.9),
                Descricao = "Teste de inserção via OnModelCreating 6",
                UrlImagem = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/00_no_image.jpg",
                Categoria = "Camiseta"

            });

        }

    }
}
