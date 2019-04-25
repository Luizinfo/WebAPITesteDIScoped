using Microsoft.AspNetCore.Mvc;

namespace WebAPITesteDIScoped.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContadorController : ControllerBase
    {
        private IContadorService contadorService;
        private ContextoVolatil context;

        public ContadorController(IContadorService contadorService, ContextoVolatil context)
        {
            this.contadorService = contadorService;
            this.context = context;
        }

        // POST api/Contador
        [HttpPost]
        public IActionResult Post([FromBody] string text)
        {
            context.textoRecebido = text;
            contadorService.Processar();

            return Ok(context.Resposta);
        }
    }
}