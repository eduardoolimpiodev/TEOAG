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

        [HttpPost]
        public IEnumerable<Product> post(Product product)
        {
            _context.Products.Add(product);
            if (_context.SaveChanges() > 0)
                return _context.Products;
            else
                throw new Exception("Você não conseguiu adicionar um produto.");
        }

        [HttpPut("{id}")]
        public Product put(int id, Product product)
        {
            if (product.Id != id) throw new Exception("Você está tentando atualizar o produto errado.");

            _context.Update(product);
            if (_context.SaveChanges() > 0)
                return _context.Products.FirstOrDefault(pr => pr.Id == id);
            else
                return new Product();
        }

        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            var product = _context.Products.FirstOrDefault(pr => pr.Id == id);
            if (product == null)
                throw new Exception("Você está tentando deletar um produto inexistente.");

            _context.Remove(product);

            return _context.SaveChanges() > 0;
        }
    }
}
