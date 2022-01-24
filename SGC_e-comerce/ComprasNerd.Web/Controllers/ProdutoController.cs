using ComprasNerd.Web.Models;
using ComprasNerd.Web.Servicos.IService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace ComprasNerd.Web.Controllers
{
    public class ProdutoController : Controller
    {

        private readonly IProdutoServico _productService;

        public ProdutoController(IProdutoServico productService)
        {
            _productService = productService ?? throw new ArgumentNullException(nameof(productService));
        }

        public async Task<IActionResult> ProdutoIndex()
        {
            var products = await _productService.FindAllProdutos();
            return View(products);
        }
    
        public  IActionResult CadastrarProduto()
        {
            return View();
        }
      

        [HttpPost]
        public async Task<ActionResult<ProdutoModel>> CadastrarProduto(ProdutoModel model)
        {

            if (ModelState.IsValid)
            {
                var result = await _productService.CreateProduto(model);
                if(result != null) return RedirectToAction(nameof(ProdutoIndex));
               
            }           
                return BadRequest(model);
                     
        }

        public async Task<IActionResult> EditarProduto(int id)
        {
            var model = await _productService.FindById(id);
            if(model != null) return View(model);
            return NotFound();
        }

        [HttpPost]
        public async Task<ActionResult<ProdutoModel>> EditarProduto(ProdutoModel model)
        {

            if (ModelState.IsValid)
            {
                var result = await _productService.UpdateProduto(model);
                if (result != null) return RedirectToAction(nameof(ProdutoIndex));

            }
            return View(model);

        }

        public async Task<IActionResult> ExcluirProduto(int id)
        {
            var model = await _productService.FindById(id);
            if (model != null) return View(model);
            return NotFound();
        }

        [HttpPost]
        public async Task<ActionResult<ProdutoModel>> ExcluirProduto(ProdutoModel model)
        {
                       
                var result = await _productService.DeleteProdutoById(model.Id);
                if (result) return RedirectToAction(nameof(ProdutoIndex));

         
            return View(model);

        }



    }
}
