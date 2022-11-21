﻿using System;
using System.Collections.Generic;

namespace Organizer
{
	public class ShiftHighestSort
    {
        private List<int> array = new List<int>();
        private List<int> randomList = new List<int>();

        /// <summary>
        /// Sort an array using the functions below
        /// </summary>
        /// <param name="input">The unsorted array</param>
        /// <returns>The sorted array</returns>
        public List<int> Sort(List<int> input)
        {
           array = new List<int>(input);

           SortFunction();
           
            return array;
        }

        /// <summary>
        /// Sort the array from low to high
        /// </summary>
        /// <param name="low">De index within this.array to start with</param>
        /// <param name="high">De index within this.array to stop with</param>
        private void SortFunction()  //int low, int high
        {
            randomList = array;
            
            int i = 1;

            while (i < array.Count +1)
            {
                for (int x = 0; x < randomList.Count - i; x++)
                {
                    int indexA = randomList[x];
                    int indexB = randomList[x+1];

                    if (indexA > indexB)
                    {
                        randomList[x] = indexB;
                        randomList[x + 1] = indexA;
                    }
                }
                i++;
            }
            array =  randomList;
        }
    }
}
