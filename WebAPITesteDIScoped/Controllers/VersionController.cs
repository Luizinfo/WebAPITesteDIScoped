using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebAPITesteDIScoped.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VersionController : ControllerBase
    {
        // GET api/version
        [HttpGet]
        public ActionResult<string> Get()
        {
            var assembly = GetType().Assembly.GetName();
            return assembly.Name + " V" + assembly.Version.ToString();
        }
    }
}
