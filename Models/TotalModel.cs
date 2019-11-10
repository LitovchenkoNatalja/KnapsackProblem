using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnapsackProblem.Models
{
    public class TotalModel
    {
        public int TotalWeight { get; set; }
        public int TotalCost { get; set; }
        public bool IsModelAppropriate { get; set; } = true;
    }
}
