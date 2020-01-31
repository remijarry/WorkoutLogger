using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutLogger.Web.Controllers
{
    public class BarbellController : Controller
    {
        private readonly ILogger<BarbellController> _logger;

        public BarbellController(ILogger<BarbellController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
