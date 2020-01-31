using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutLogger.Web.ViewModels;

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
            var dummyData = new List<CategoryViewModel>
            {
                new CategoryViewModel()
                {
                    Id = 1,
                    Name = "Squats",
                    Exercises = new List<ExerciseViewModel>()
                    {
                        new ExerciseViewModel()
                        {
                            Id = 1,
                            Name = "Back Squat",
                            OneRepMax = new RepMaxViewModel{Date = new DateTime(), Weight = 128 },
                        },
                        new ExerciseViewModel()
                        {
                            Id = 2,
                            Name = "Front Squat",
                            OneRepMax = new RepMaxViewModel{Date = new DateTime(2019,7,12), Weight = 105 },
                        }
                    }

                },
                new CategoryViewModel()
                {
                    Id = 2,
                    Name = "Cleans",
                    Exercises = new List<ExerciseViewModel>()
                    {
                        new ExerciseViewModel()
                        {
                            Id = 3,
                            Name = "Power Clean",
                            OneRepMax = new RepMaxViewModel{Date = new DateTime(), Weight = 100 },
                        },
                        new ExerciseViewModel()
                        {
                            Id = 4,
                            Name = "Squat Clean",
                            OneRepMax = new RepMaxViewModel{Date = new DateTime(2019,7,12), Weight = 105 },
                        }
                    }

                }
            };
            return View(dummyData);
        }
    }
}
