using KnapsackProblem.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnapsackProblem.Services
{
    class ObjectiveCalculation
    {
        public TotalModel CalculateObjectiveValue(BitArray X, KnapsackModel model)
        {
            var totalModel = new TotalModel();
            for (int i=0; i<model.N; i++)
            {
                totalModel.TotalCost += model.Items[i].Item1 * Convert.ToInt32(X[i]);
                totalModel.TotalWeight += model.Items[i].Item2 * Convert.ToInt32(X[i]);
                if (totalModel.IsModelAppropriate && totalModel.TotalWeight > model.C)
                {
                    totalModel.IsModelAppropriate = false;
                }
            }
            return totalModel;
        }

        public TotalModel NextObjectiveValue(int[] NFlip, BitArray X, TotalModel prevTotalModel, KnapsackModel model)
        {
            var totalModel = new TotalModel();
            totalModel.TotalCost = prevTotalModel.TotalCost;
            totalModel.TotalWeight = prevTotalModel.TotalWeight;

            //for each changed bit in start array
            foreach (var bitNumber in NFlip) if (bitNumber != 0)//stop because there is no bitNumber elements left
                {
                    //if add element
                    if (X[bitNumber - 1] == false)
                    {
                        totalModel.TotalCost += model.Items[bitNumber - 1].Item1;
                        totalModel.TotalWeight += model.Items[bitNumber - 1].Item2;
                    }
                    //if delete element
                    else
                    {
                        totalModel.TotalCost -= model.Items[bitNumber - 1].Item1;
                        totalModel.TotalWeight -= model.Items[bitNumber - 1].Item2;
                    }
                    if (totalModel.IsModelAppropriate && totalModel.TotalWeight > model.C)
                    {
                        totalModel.IsModelAppropriate = false;
                    }
                }
            return totalModel;
        }

    }
}
