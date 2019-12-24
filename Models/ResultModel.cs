using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnapsackProblem.Models
{
    public class ResultModel
    {
        public BitArray X { get; set; }
        public double ResultC { get; set; }
        public double ResultW { get; set; }
        public List<double> ObjectiveDetails { get; set; }
    }
}
