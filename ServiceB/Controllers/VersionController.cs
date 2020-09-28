using System;

using Microsoft.AspNetCore.Mvc;

using ServiceB.Application;

namespace ServiceB.Controllers
{
    [Route("api/[controller]")]
    public class VersionController : Controller
    {
        
        public IActionResult Get()
        {
            return new OkObjectResult(VersionRegistry.Value);
        }

    }
}
