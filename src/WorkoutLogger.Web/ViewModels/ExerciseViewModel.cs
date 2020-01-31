using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutLogger.Web.ViewModels
{
    public class ExerciseViewModel : BaseViewModel
    {
        public string Name { get; set; }

        public RepMaxViewModel OneRepMax { get; set; }

        public RepMaxViewModel TwoRepMax { get; set; }

        public RepMaxViewModel ThreeRepMax { get; set; }

        public RepMaxViewModel FiveRepMax { get; set; }
    }
}
