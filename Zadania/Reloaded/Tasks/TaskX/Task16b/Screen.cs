using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.TaskX.Task16b
{
    public class Screen
    {
        public Screen(bool orShine, double diagonal, Resolution resolution)
        {
            OrShine = orShine;
            Diagonal = diagonal;
            Resolution = resolution;
        }
        public bool OrShine { get; set; }
        public double Diagonal { get; set; }
        public Resolution Resolution { get; set; }
    }
}
