
using Microsoft.EntityFrameworkCore;


namespace ComprasNerd.ProdutoAPI.Model.Context
{
    public class MySqlContext: DbContext
    {
        public MySqlContext(){ }
        
        public MySqlContext(DbContextOptions<MySqlContext> options):base(options) { }

        public DbSet<Produto> Produto { get; set; }

    }
}
