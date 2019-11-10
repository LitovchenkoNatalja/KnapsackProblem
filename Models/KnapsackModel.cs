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
        public int C { get; set; }
        public List<Tuple<int, int>> Items { get; set; }
    }
}
