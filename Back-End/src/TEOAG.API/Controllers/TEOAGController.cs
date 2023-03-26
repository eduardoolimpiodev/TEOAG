using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TEOAG.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TEOAGController : ControllerBase
    {
        [HttpGet]
        public string get()
        {
            return "Method Get Test";
        }

         [HttpGet("{id}")]
        public string get(int id)
        {
            return $"Method Get Test id: {id}";
        }

        [HttpPost]
        public string post()
        {
            return "Method Post Test";
        }

         [HttpPut]
        public string put(int id)
        {
            return $"Method Put Test id: {id}";
        }

         [HttpDelete]
        public string Delete(int id)
        {
            return $"Method Delete Test id: {id}";
        }
    }
}
