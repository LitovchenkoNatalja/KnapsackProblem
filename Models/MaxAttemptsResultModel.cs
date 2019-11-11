using System.Collections.Generic;

namespace KnapsackProblem.Models
{
    public class MaxAttemptsResultModel
    {
        public SortedDictionary<int, int> AttemptStatistics { set; get; }
        public int Delta { set; get; }
        public List<List<int>> ObjectivesDetails { get; set; }
    }
}
