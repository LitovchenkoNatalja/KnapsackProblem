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
        public int ResultC { get; set; }
        public int ResultW { get; set; }
        public List<int> ObjectiveDetails { get; set; }
    }
}
