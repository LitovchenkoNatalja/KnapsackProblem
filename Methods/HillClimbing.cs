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
        public ResultModel HillClimbingMethod(KnapsackModel model)
        {
            //selec inital X at random
            BitArray X = new RandomBitGeneration().GenerateBitArray(model.N);

            //initialize settings
            var neighborhood = new Neighborhood();
            neighborhood.InitNFlip(1, model.N);
            var objectiveCalculation = new ObjectiveCalculation();
            var xTotalModel = objectiveCalculation.CalculateObjectiveValue(X, model);

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
                        }
                        else
                            neighborhood.MoveNext();
                    }
                    else
                    {
                        X = (BitArray)Y.Clone();
                        xTotalModel = yTotalModel;
                        neighborhood.InitNFlip(1, model.N);
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
            resultModel.X = (BitArray)X.Clone();

            return resultModel;
        }
    }
}
