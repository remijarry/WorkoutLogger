using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutLogger.Web.ViewModels
{
    public class CategoryViewModel : BaseViewModel
    {
        public string Name { get; set; }

        public ICollection<ExerciseViewModel> Exercises { get; set; }
    }
}
