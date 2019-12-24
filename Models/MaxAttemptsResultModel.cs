using System.Collections.Generic;

namespace KnapsackProblem.Models
{
    public class MaxAttemptsResultModel
    {
        public SortedDictionary<double, double> AttemptStatistics { set; get; }
        public double Delta { set; get; }
        public List<List<double>> ObjectivesDetails { get; set; }
    }
}
