using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutLogger.Web.Controllers
{
    public class BenchmarkController : Controller
    {
        private readonly ILogger<BenchmarkController> _logger;

        public BenchmarkController(ILogger<BenchmarkController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}
