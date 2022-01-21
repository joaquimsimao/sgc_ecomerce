using AutoMapper;
using ComprasNerd.ProdutoAPI.Data.ValueObject;
using ComprasNerd.ProdutoAPI.Model;
using ComprasNerd.ProdutoAPI.Model.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComprasNerd.ProdutoAPI.Repositorio
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        private readonly MySqlContext _context;
        private IMapper _mapper;
      

        public ProdutoRepositorio(MySqlContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

                  

        async Task<IEnumerable<ProdutoVO>> IProdutoRepositorio.FindAll()
        {
            List<Produto> products = await _context.Produto.ToListAsync();
            return _mapper.Map<List<ProdutoVO>>(products);
        }

        async Task<ProdutoVO> IProdutoRepositorio.FindById(long id)
        {
            Produto prod = await _context.Produto.FindAsync(id);

            return _mapper.Map<ProdutoVO>(prod);
        }

        public async Task<ProdutoVO> Create(ProdutoVO produtoVO)
        {
            Produto prod = _mapper.Map<Produto>(produtoVO);
            _context.Produto.Add(prod);
            await _context.SaveChangesAsync();

            return _mapper.Map<ProdutoVO>(prod);
        }

        public async Task<ProdutoVO> Update(ProdutoVO produtoVO)
        {
            Produto prod = _mapper.Map<Produto>(produtoVO);
            _context.Produto.Update(prod);
            await _context.SaveChangesAsync();

            return _mapper.Map<ProdutoVO>(prod);
        }

        public async Task<bool> Delete(long id)
        {
            try
            {
                Produto prod = await _context.Produto.FindAsync(id);
                if (prod == null) return false;
                _context.Produto.Remove(prod);
                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {
                return false;

            }
        }

    }
}
