﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnapsackProblem.Services
{
    class Neighborhood
    {
        //Contains position (number) of element that should be changed
        //N - size of flip (once you can change only max N elements)
        public int[] NFlip;
        public bool stop = false;
        
        //Ex: 54321
        public void InitNFlip(int N)
        {
            NFlip = new int[N];
            for (int i = 0; i < NFlip.Length; i++)
            {
                NFlip[i] = N--;
            }
        }

        public BitArray GetNextNeighborhood(BitArray X)
        {
            //invert start binary array
            foreach(var bitNumber in NFlip) if (bitNumber != 0)//stop because there is no bitNumber elements left
                { 
                if (bitNumber != 0)
                {
                    X[bitNumber - 1] = !X[bitNumber - 1];
                }
            }

            //search the last 0 element
            int nullElement;
            for(nullElement = 0; nullElement < NFlip.Length; nullElement++)
            {
                if (NFlip[nullElement] == 0) break;
            }

            //if there is no last 0 element, decrease the last element
            if (nullElement == NFlip.Length)
                NFlip[nullElement - 1] -= 1;
            //if it is the end, stop the process
            else if (nullElement == 0)
                stop = true;
            else
            {
                //decrease the element before 0
                int count = NFlip[nullElement - 1] = NFlip[nullElement - 1] - 1;

                //cange elements after 0 (ex: 50000 -> 43210)
                int index = nullElement;
                while (count != 0)
                {
                    NFlip[index++] = --count;
                }
            }
            return X;
        }
    }
}