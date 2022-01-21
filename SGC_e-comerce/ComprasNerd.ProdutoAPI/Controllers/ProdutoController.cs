using ComprasNerd.ProdutoAPI.Data.ValueObject;
using ComprasNerd.ProdutoAPI.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ComprasNerd.ProdutoAPI
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private IProdutoRepositorio _repositorio;

        public ProdutoController(IProdutoRepositorio repositorio)
        {
            _repositorio = repositorio ?? throw new 
                ArgumentNullException(nameof(repositorio));
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProdutoVO>>> FindAllProduto()
        {
            var produtos = await _repositorio.FindAll();
            if (produtos == null) return NotFound();
            return Ok(produtos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProdutoVO>> GetProduto(long id)
        {
             var prod = await _repositorio.FindById(id);

            if(prod == null) return NotFound();
            return Ok(prod);    
           
        }

        [HttpPost]
        public async Task<ActionResult<ProdutoVO>> CreateProduto(ProdutoVO produto)
        {
            if(produto== null) return BadRequest();
            var prod = await _repositorio.Create(produto);
           
            return Ok(prod);

        }

        [HttpPut]
        public async Task<ActionResult<ProdutoVO>> UpdateProduto(ProdutoVO produto)
        {
            if (produto == null) return BadRequest();
            var prod = await _repositorio.Update(produto);

            return Ok(prod);

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteProduto(long id)
        {
            var status = await _repositorio.Delete(id);
            if(status) return BadRequest();
            return Ok(status);

        }





    }
}
