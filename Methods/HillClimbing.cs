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
            bool found = true;
            var neighborhood = new Neighborhood();
            neighborhood.InitNFlip(1);

            while (found)
            {

            }

            return null;
        }
    }
}
