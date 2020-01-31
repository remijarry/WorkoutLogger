using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutLogger.Web.Controllers
{
    public class LogBookController : Controller
    {
        private readonly ILogger<LogBookController> _logger;

        public LogBookController(ILogger<LogBookController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
