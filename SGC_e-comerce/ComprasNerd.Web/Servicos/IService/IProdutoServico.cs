using ComprasNerd.Web.Models;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ComprasNerd.Web.Servicos.IService
{
    public interface IProdutoServico
    {
        Task<IEnumerable<ProdutoModel>> FindAllProdutos();

        Task<ProdutoModel> FindById(long id);
        Task<ProdutoModel> CreateProduto(ProdutoModel model);
        Task<ProdutoModel> UpdateProduto(ProdutoModel model);
        Task<bool> DeleteProdutoById(long id);


    }
}
