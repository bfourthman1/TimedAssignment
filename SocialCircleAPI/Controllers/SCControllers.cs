using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TimedAssignment.SocialCircleAPI.Controllers
{
    [Route("[controller]")]
    public class SCControllers : Controller
    {
        private readonly ILogger<SCControllers> _logger;

        public SCControllers(ILogger<SCControllers> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}