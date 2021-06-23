using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerilogExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Index action executed at {date}", DateTime.UtcNow);

            //try
            //{
            //    throw new Exception("Error!");
            //}
            //catch (Exception ex)
            //{
            //    _logger.LogError(ex, "An unkown error occurred on the Home/Error action of the HomeController");
            //}

            return Ok();
        }
    }
}
