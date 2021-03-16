using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace api.Controllers
{
    [ApiController]
    [Route("/hello")]
    public class WelcomeController : ControllerBase
    {
        [HttpGet]
        public ActionResult Hello()
        {
            return Ok("Hola mundo");
        }
    }
}
