using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TEOAG.Data.Context;
using TEOAG.Domain.Entities;
using TEOAG.Domain.Services;

namespace TEOAG.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ProductService _productService;

        public ProductController(ProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> get()
        {
            try
            {
                var products = await _productService.GetAllProductsAsync();
                if (products == null) return NoContent();

                return Ok(products);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,
                $"Erro ao tentar recuperar produtos. Erro: {ex.Message}");
            }

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> get(int id)
        {
            try
            {
                var product = await _productService.GetAllProductByIdAsync(id);
                if (product == null) return NoContent();

                return Ok(product);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,
                $"Erro ao tentar recuperar produto ${id}. Erro: {ex.Message}");
            }

        }

        [HttpPost]
        public async Task <IActionResult> post(Product model)
        {
            try
            {
                var product = await _productService.PostProduct(model);
                if (product == null) return NotFound("");

                return Ok(product);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,
                $"Erro ao tentar adicionar produto. Erro: {ex.Message}");
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> put(int id, Product model)
        {
            try
            {
                if(model.Id != id)
                this.StatusCode(StatusCodes.Status409Conflict,
                "Você está tentando atualizar o produto errado.");

                var product = await _productService.UpdateProduct(model);
                if (product == null) return NoContent();

                return Ok(product);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,
                $"Erro ao tentar atualizar produto ${id}. Erro: {ex.Message}");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var product = await _productService.GetAllProductByIdAsync(id);
                if (product == null) 
                this.StatusCode(StatusCodes.Status409Conflict,
                "Você está tentando deletar o produto que não existe.");

                if (await _productService.DeleteProduct(id))
                {
                    return Ok(new { message = "Deletado com sucesso."});
                }
                else
                {
                     return BadRequest("Ocorreu um problema não específico ao tentar deletar o produto.");
                }

            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,
                $"Erro ao tentar deletar produto ${id}. Erro: {ex.Message}");
            }
        }
    }
}
