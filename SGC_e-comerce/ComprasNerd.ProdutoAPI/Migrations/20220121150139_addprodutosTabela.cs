using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComprasNerd.ProdutoAPI.Migrations
{
    public partial class addprodutosTabela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "produto",
                columns: new[] { "id", "categoria", "descricao", "nome", "preco", "url_imagem" },
                values: new object[,]
                {
                    { 5L, "Camiseta", "Teste de inserção via OnModelCreating", "Nome", 69.9m, "https://github.com/joaquimsimao/sgc_ecomerce/blob/master/SGC_e-comerce/ShoppingImages/00_no_image.jpg" },
                    { 6L, "Camiseta", "Teste de inserção via OnModelCreating 2", "Nome", 40.9m, "https://github.com/joaquimsimao/sgc_ecomerce/blob/master/SGC_e-comerce/ShoppingImages/10_milennium_falcon.jpg" },
                    { 7L, "Camiseta", "Teste de inserção via OnModelCreating 3", "Nome", 80.9m, "https://github.com/joaquimsimao/sgc_ecomerce/blob/master/SGC_e-comerce/ShoppingImages/11_mars.jpg" },
                    { 8L, "Camiseta", "Teste de inserção via OnModelCreating 4", "Nome", 10.9m, "https://github.com/joaquimsimao/sgc_ecomerce/blob/master/SGC_e-comerce/ShoppingImages/12_gnu_linux.jpg" },
                    { 9L, "Camiseta", "Teste de inserção via OnModelCreating 5", "Nome", 180.9m, "https://github.com/joaquimsimao/sgc_ecomerce/blob/master/SGC_e-comerce/ShoppingImages/13_dragon_ball.jpg" },
                    { 10L, "Camiseta", "Teste de inserção via OnModelCreating 6", "Nome", 325.9m, "https://github.com/joaquimsimao/sgc_ecomerce/blob/master/SGC_e-comerce/ShoppingImages/14_patch_nasa.jpg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "produto",
                keyColumn: "id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "produto",
                keyColumn: "id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "produto",
                keyColumn: "id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "produto",
                keyColumn: "id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "produto",
                keyColumn: "id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "produto",
                keyColumn: "id",
                keyValue: 10L);
        }
    }
}
