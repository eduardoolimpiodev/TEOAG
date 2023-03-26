using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TEOAG.API.Models;

namespace TEOAG.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TEOAGController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Product> get()
        {
            return new List<Product>()
            {
                new Product(),
                new Product(),
                new Product()
            };
        }

         [HttpGet("{id}")]
        public string get(int id)
        {
            return $"Method Get Test id: {id}";
        }

        [HttpPost]
        public Product post(Product product)
        {
            return product;
        }

         [HttpPut]
        public Product put(int id, Product product)
        {
            product.Id = product.Id+1;
            return product;
        }

         [HttpDelete]
        public string Delete(int id)
        {
            return $"Method Delete Test id: {id}";
        }
    }
}
