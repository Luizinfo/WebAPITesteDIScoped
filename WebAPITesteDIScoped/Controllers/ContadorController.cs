using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPITesteDIScoped.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContadorController : ControllerBase
    {
        private IContadorService contadorService;
        public ContadorController(IContadorService contadorService)
        {
            this.contadorService = contadorService;
        }

        // POST api/Contador
        [HttpPost]
        public IActionResult Post([FromBody] string text)
        {
            var result = contadorService.Processar(text);

            return Ok(result);
        }
    }
}