using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;

namespace CommandsService.Controllers
{
    [Route("api/c/[controller]")]
    [ApiController]
    public class PlatformsController : ControllerBase
    {
        public PlatformsController()
        {

        }

        [HttpPost]
        [SwaggerResponse(200, "Command Service for PLatforms OK")]
        [SwaggerResponse(400, "No Platform connection on Commands Service")]
        public ActionResult TestInboundConnection()
        {
            Console.WriteLine("--> Inbound POST # Commands Service");

            return Ok("Inbound test OK from Platforms Controller");
        }
    }
}
