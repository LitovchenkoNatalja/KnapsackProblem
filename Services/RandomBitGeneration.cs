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
        public BitArray GenerateBitArray(int size)
        {
            bool[] XArray = new bool[size];

            Random random = new Random();
            for (int i=0; i< size; i++)
            {
                bool randomValue = Convert.ToBoolean(random.Next(2));
                XArray[i] = randomValue;
            }
            return new BitArray(XArray);
        }
    }
}
