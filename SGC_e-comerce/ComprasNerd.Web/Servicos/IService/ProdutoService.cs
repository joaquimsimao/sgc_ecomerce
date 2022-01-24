using ComprasNerd.Web.Models;
using ComprasNerd.Web.Utils;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ComprasNerd.Web.Servicos.IService
{
    public class ProdutoService : IProdutoServico
    {
        private readonly HttpClient _cliente;
        public const string BasePath = "api/v1/Produto";

        public ProdutoService(HttpClient cliente)
        {
            _cliente = cliente; 
        }

        public async Task<IEnumerable<ProdutoModel>> FindAllProdutos()
        {
            var response = await _cliente.GetAsync(BasePath);

            return await response.ReadContextAs<List<ProdutoModel>>();
        }

        public async Task<ProdutoModel> FindById(long id)
        {
            var response = await _cliente.GetAsync($"{BasePath}/{id}");

            return await response.ReadContextAs<ProdutoModel>();
        }
        public async Task<ProdutoModel> CreateProduto(ProdutoModel model)
        {
            var response = await _cliente.PostAsJson(BasePath, model);
            if (response.IsSuccessStatusCode) return await response.ReadContextAs<ProdutoModel>();
            else
                throw new Exception("Algo deu errado ao chamar a API");
        }                     

        public async Task<ProdutoModel> UpdateProduto(ProdutoModel model)
        {
            var response = await _cliente.PutAsJson(BasePath, model);
            if (response.IsSuccessStatusCode) return await response.ReadContextAs<ProdutoModel>();
            else
                throw new Exception("Algo deu errado ao chamar a API");
        }

        public async Task<bool> DeleteProdutoById(long id)
        {
            var response = await _cliente.DeleteAsync($"{BasePath}/{id}");
            if (response.IsSuccessStatusCode) 
                return await response.ReadContextAs<bool>();
            else throw new Exception("Algo deu errado ao chamar a API");
        }                   
           
        


    }
}
