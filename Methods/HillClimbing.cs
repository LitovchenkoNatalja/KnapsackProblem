using KnapsackProblem.Models;
using KnapsackProblem.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnapsackProblem.Methods
{
    class HillClimbing
    {
        public ResultModel FirstAscendHillClimbingMethod(KnapsackModel model, bool needObjectiveDetails = false)
        {
            //selec inital X at random
            BitArray X = new RandomBitGeneration().GenerateBitArray(model.N);

            //initialize settings
            var neighborhood = new Neighborhood();
            neighborhood.InitNFlip(1, model.N);
            var objectiveCalculation = new ObjectiveCalculation();
            var xTotalModel = objectiveCalculation.CalculateObjectiveValue(X, model);

            //for objective Details
            var objectiveDetails = new List<int>();
            objectiveDetails.Add(xTotalModel.IsModelAppropriate?xTotalModel.TotalCost:-1);

            while (!neighborhood.stop)
            {
                BitArray Y = neighborhood.GetNextNeighborhood(X);
                var yTotalModel = objectiveCalculation.NextObjectiveValue(neighborhood.NFlip, X, xTotalModel, model);
                if (!xTotalModel.IsModelAppropriate)
                {
                    if (!yTotalModel.IsModelAppropriate)
                    {
                        if (xTotalModel.TotalWeight > yTotalModel.TotalWeight)
                        {
                            X = (BitArray)Y.Clone();
                            xTotalModel = yTotalModel;
                            neighborhood.InitNFlip(1, model.N);
                            objectiveDetails.Add(xTotalModel.IsModelAppropriate ? xTotalModel.TotalCost : -1);
                        }
                        else
                            neighborhood.MoveNext();
                    }
                    else
                    {
                        X = (BitArray)Y.Clone();
                        xTotalModel = yTotalModel;
                        neighborhood.InitNFlip(1, model.N);
                        objectiveDetails.Add(xTotalModel.IsModelAppropriate ? xTotalModel.TotalCost : -1);
                    }
                }
                else
                {
                    if (yTotalModel.IsModelAppropriate)
                    {
                        if (xTotalModel.TotalCost < yTotalModel.TotalCost)
                        {
                            X = (BitArray)Y.Clone();
                            xTotalModel = yTotalModel;
                            neighborhood.InitNFlip(1, model.N);
                            objectiveDetails.Add(xTotalModel.IsModelAppropriate ? xTotalModel.TotalCost : -1);
                        }
                        else
                            neighborhood.MoveNext();
                    }
                    else
                        neighborhood.MoveNext();
                }
            }

            var resultModel = new ResultModel();
            resultModel.ResultC = xTotalModel.TotalCost;
            resultModel.ResultW = xTotalModel.TotalWeight;
            resultModel.X = (BitArray)X.Clone();
            if (needObjectiveDetails)
                resultModel.ObjectiveDetails = objectiveDetails;

            return resultModel;
        }

        public MaxAttemptsResultModel MultiStartHillClimbingMethod(KnapsackModel model, int maxAttemts, bool objDetails)
        {
            var maxAttemptsResultModel = new MaxAttemptsResultModel();
            maxAttemptsResultModel.AttemptStatistics = new SortedDictionary<int, int>();
            maxAttemptsResultModel.ObjectivesDetails = new List<List<int>>();

            for (int attempt = 0; attempt< maxAttemts; attempt++)
            {
                var result = FirstAscendHillClimbingMethod(model, objDetails);
                if (maxAttemptsResultModel.AttemptStatistics.ContainsKey(result.ResultC)) 
                {
                    maxAttemptsResultModel.AttemptStatistics[result.ResultC] += 1;
                }
                else
                {
                    maxAttemptsResultModel.AttemptStatistics.Add(result.ResultC, 1);
                }
                maxAttemptsResultModel.ObjectivesDetails.Add(result.ObjectiveDetails);
            }

            maxAttemptsResultModel.Delta = maxAttemptsResultModel.AttemptStatistics.Keys.Last() - maxAttemptsResultModel.AttemptStatistics.Keys.First();
            
            return maxAttemptsResultModel;
        }
    }
}
