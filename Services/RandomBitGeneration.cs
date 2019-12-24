using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnapsackProblem.Services
{
    public class RandomBitGeneration
    {
        private const double PROBABILITY = 0.5;

        public BitArray GenerateBitArray(int size, Random randomHelp = null)
        {
            bool[] XArray = new bool[size];

            Random random = randomHelp!=null ? randomHelp : new Random();
            for (int i=0; i< size; i++)
            {
                double randomValue = random.NextDouble();
                XArray[i] = randomValue > PROBABILITY ? true : false;
            }
            return new BitArray(XArray);
        }
    }
}
