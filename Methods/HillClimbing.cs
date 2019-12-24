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
        private BitArray XInit;
        public HillClimbing() { }
        public HillClimbing(KnapsackModel model)
        {
             XInit = new RandomBitGeneration().GenerateBitArray(model.N);
        }

        public ResultModel FirstAscendHillClimbingMethod(KnapsackModel model, bool needObjectiveDetails = false)
        {
            //selec inital X at random
            BitArray X = XInit != null ? XInit : new RandomBitGeneration().GenerateBitArray(model.N);

            //initialize settings
            var neighborhood = new Neighborhood();
            neighborhood.InitNFlip(1, model.N);
            var objectiveCalculation = new ObjectiveCalculation();
            var xTotalModel = objectiveCalculation.CalculateObjectiveValue(X, model);
            new FileProcess().WriteFile(X, xTotalModel, "ResultFAHillClimbing");

            //for objective Details
            var objectiveDetails = new List<double>();
            if (needObjectiveDetails)
            {
                objectiveDetails.Add(xTotalModel.IsModelAppropriate ? xTotalModel.TotalCost : -1);
            }

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
                            xTotalModel = new TotalModel
                            {
                                TotalCost = yTotalModel.TotalCost,
                                TotalWeight = yTotalModel.TotalWeight,
                                IsModelAppropriate = yTotalModel.IsModelAppropriate
                            };
                            neighborhood.InitNFlip(1, model.N);
                            new FileProcess().WriteFile(X, xTotalModel, "ResultFAHillClimbing");

                            if (needObjectiveDetails)
                            {
                                objectiveDetails.Add(xTotalModel.IsModelAppropriate ? xTotalModel.TotalCost : -1);
                            }
                        }
                        else
                            neighborhood.MoveNext();
                    }
                    else
                    {
                        X = (BitArray)Y.Clone();
                        xTotalModel = new TotalModel
                        {
                            TotalCost = yTotalModel.TotalCost,
                            TotalWeight = yTotalModel.TotalWeight,
                            IsModelAppropriate = yTotalModel.IsModelAppropriate
                        };
                        neighborhood.InitNFlip(1, model.N);
                        new FileProcess().WriteFile(X, xTotalModel, "ResultFAHillClimbing");

                        if (needObjectiveDetails)
                        {
                            objectiveDetails.Add(xTotalModel.IsModelAppropriate ? xTotalModel.TotalCost : -1);
                        }
                    }
                }
                else
                {
                    if (yTotalModel.IsModelAppropriate)
                    {
                        if (xTotalModel.TotalCost < yTotalModel.TotalCost)
                        {
                            X = (BitArray)Y.Clone();
                            xTotalModel = new TotalModel
                            {
                                TotalCost = yTotalModel.TotalCost,
                                TotalWeight = yTotalModel.TotalWeight,
                                IsModelAppropriate = yTotalModel.IsModelAppropriate
                            };
                            neighborhood.InitNFlip(1, model.N);
                            new FileProcess().WriteFile(X, xTotalModel, "ResultFAHillClimbing");

                            if (needObjectiveDetails)
                            {
                                objectiveDetails.Add(xTotalModel.IsModelAppropriate ? xTotalModel.TotalCost : -1);
                            }
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
            maxAttemptsResultModel.AttemptStatistics = new SortedDictionary<double, double>();
            maxAttemptsResultModel.ObjectivesDetails = new List<List<double>>();

            for (int attempt = 0; attempt< maxAttemts; attempt++)
            {
                var result = HillClimbingMethod(model, objDetails);
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

        public ResultModel HillClimbingMethod(KnapsackModel model, bool needObjectiveDetails = false)
        {
            //selec inital X at random
            BitArray X = XInit != null ? XInit : new RandomBitGeneration().GenerateBitArray(model.N);

            //initialize settings
            var neighborhood = new Neighborhood();
            neighborhood.InitNFlip(1, model.N);
            var objectiveCalculation = new ObjectiveCalculation();
            var xTotalModel = objectiveCalculation.CalculateObjectiveValue(X, model);
            new FileProcess().WriteFile(X, xTotalModel, "ResultHillClimbing");

            //for objective Details
            var objectiveDetails = new List<double>();
            if (needObjectiveDetails)
            {
                objectiveDetails.Add(xTotalModel.IsModelAppropriate ? xTotalModel.TotalCost : -1);
            }

            //best
            var bestTotalModel = new TotalModel 
            { 
                TotalWeight = xTotalModel.TotalWeight,
                TotalCost = xTotalModel.TotalCost,
                IsModelAppropriate = xTotalModel.IsModelAppropriate
            };
            BitArray best = (BitArray)X.Clone();

            bool found = false;
            while (!found)
            {
                while (!neighborhood.stop)
                {
                    BitArray Y = neighborhood.GetNextNeighborhood(X);
                    var yTotalModel = objectiveCalculation.NextObjectiveValue(neighborhood.NFlip, X, xTotalModel, model);
                    if (!bestTotalModel.IsModelAppropriate)
                    {
                        if (!yTotalModel.IsModelAppropriate)
                        {
                            if (bestTotalModel.TotalWeight > yTotalModel.TotalWeight)
                            {
                                best = (BitArray)Y.Clone();
                                bestTotalModel.TotalCost = yTotalModel.TotalCost;
                                bestTotalModel.TotalWeight = yTotalModel.TotalWeight;
                                bestTotalModel.IsModelAppropriate = yTotalModel.IsModelAppropriate;
                            }
                        }
                        else
                        {
                            best = (BitArray)Y.Clone();
                            bestTotalModel.TotalCost = yTotalModel.TotalCost;
                            bestTotalModel.TotalWeight = yTotalModel.TotalWeight;
                            bestTotalModel.IsModelAppropriate = yTotalModel.IsModelAppropriate;
                        }
                    }
                    else
                    {
                        if (yTotalModel.IsModelAppropriate)
                        {
                            if (bestTotalModel.TotalCost < yTotalModel.TotalCost)
                            {
                                best = (BitArray)Y.Clone();
                                bestTotalModel.TotalCost = yTotalModel.TotalCost;
                                bestTotalModel.TotalWeight = yTotalModel.TotalWeight;
                                bestTotalModel.IsModelAppropriate = yTotalModel.IsModelAppropriate;
                            }
                        }
                    }
                    neighborhood.MoveNext();
                }
                found = bestTotalModel.TotalWeight == xTotalModel.TotalWeight && bestTotalModel.TotalCost == xTotalModel.TotalCost;
                new FileProcess().WriteFile(best, bestTotalModel, "ResultHillClimbing");
                X = (BitArray)best.Clone();
                xTotalModel.TotalWeight = bestTotalModel.TotalWeight;
                xTotalModel.TotalCost = bestTotalModel.TotalCost;
                xTotalModel.IsModelAppropriate = bestTotalModel.IsModelAppropriate;
                neighborhood.InitNFlip(1, model.N);
            }

            var resultModel = new ResultModel();
            resultModel.ResultC = xTotalModel.TotalCost;
            resultModel.ResultW = xTotalModel.TotalWeight;
            resultModel.X = (BitArray)X.Clone();

            if (needObjectiveDetails)
                resultModel.ObjectiveDetails = objectiveDetails;

            return resultModel;
        }

        public ResultModel NewFirstAscendHillClimbingMethod(KnapsackModel model, double alpha, bool needObjectiveDetails = false)
        {
            //selec inital X at random
            BitArray X = XInit != null ? XInit : new RandomBitGeneration().GenerateBitArray(model.N);

            //initialize settings
            var neighborhood = new Neighborhood();
            neighborhood.InitNFlip(1, model.N);
            var objectiveCalculation = new ObjectiveCalculation();
            var xTotalModel = objectiveCalculation.CalculateNewObjective(X, model, alpha);
            new FileProcess().WriteFile(X, xTotalModel, "ResultFAHillClimbing");

            //for objective Details
            var objectiveDetails = new List<double>();
            if (needObjectiveDetails)
            {
                objectiveDetails.Add(xTotalModel.IsModelAppropriate ? xTotalModel.TotalCost : -1);
            }

            while (!neighborhood.stop)
            {
                BitArray Y = neighborhood.GetNextNeighborhood(X);
                var yTotalModel = objectiveCalculation.CalculateNewObjective(Y, model, alpha);
                if (xTotalModel.TotalCost < yTotalModel.TotalCost)
                {
                    X = (BitArray)Y.Clone();
                    xTotalModel = new TotalModel
                    {
                        TotalCost = yTotalModel.TotalCost,
                        TotalWeight = yTotalModel.TotalWeight,
                        IsModelAppropriate = yTotalModel.IsModelAppropriate
                    };
                    neighborhood.InitNFlip(1, model.N);
                    new FileProcess().WriteFile(X, xTotalModel, "ResultFAHillClimbing");

                    if (needObjectiveDetails)
                    {
                        objectiveDetails.Add(xTotalModel.IsModelAppropriate ? xTotalModel.TotalCost : -1);
                    }
                }
                else
                    neighborhood.MoveNext();
            }

            var resultModel = new ResultModel();
            resultModel.ResultC = xTotalModel.TotalCost;
            resultModel.ResultW = xTotalModel.TotalWeight;
            resultModel.X = (BitArray)X.Clone();
            if (needObjectiveDetails)
                resultModel.ObjectiveDetails = objectiveDetails;

            return resultModel;
        }
    }
}
