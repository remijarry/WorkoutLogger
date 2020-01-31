using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutLogger.Web.Controllers
{
    public class FriendsController : Controller
    {
        private readonly ILogger<FriendsController> _logger;

        public FriendsController(ILogger<FriendsController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
