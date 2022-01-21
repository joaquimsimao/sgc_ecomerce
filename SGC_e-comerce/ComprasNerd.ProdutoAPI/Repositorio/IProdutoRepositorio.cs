using ComprasNerd.ProdutoAPI.Data.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComprasNerd.ProdutoAPI.Repositorio
{
    public interface IProdutoRepositorio
    {
        Task<IEnumerable<ProdutoVO>> FindAll();
       
        Task<ProdutoVO> FindById(long id);

        Task<ProdutoVO> Create(ProdutoVO produtoVO);

        Task<ProdutoVO> Update(ProdutoVO produtoVO);

        Task<bool> Delete(long id);
                
    }
}
