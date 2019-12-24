using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnapsackProblem.Models
{
    public class KnapsackModel
    {
        public int N { get; set; }
        public double C { get; set; }
        public List<Tuple<double, double>> Items { get; set; }
    }
}
