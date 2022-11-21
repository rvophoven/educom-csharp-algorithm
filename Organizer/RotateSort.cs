using System;
using System.Collections.Generic;
using System.Collections;

namespace Organizer
{
	public class RotateSort
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

            if (array.Count < 2)//trow exeption when array to short
            throw new Exception("array is to short");

            Random randomNumber = new Random();// get a random number
            int number = randomNumber.Next(1, array.Count);

            //Partitioning(number);

            Console.WriteLine(array[number]);

            //SortFunction(0, array.Count - 1);
            return array;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="low">De index within this.array to start with</param>
        /// <param name="high">De index within this.array to stop with</param>
        private void SortFunction(int low, int high)
        {
            throw new NotImplementedException();
        }

        /// 
        /// Partition the array in a group 'low' digits (e.a. lower than a choosen pivot) and a group 'high' digits
        /// </summary>
        /// <param name="low">De index within this.array to start with</param>
        /// <param name="high">De index within this.array to stop with</param>
        /// <returns>The index in the array of the first of the 'high' digits</returns>
        private void Partitioning(int number)
        {
            randomList = array;
            int part = array[number];
            List<int> higher = new List<int>();
            List<int> lower = new List<int>();

            higher.Add(array[number]);

            //nog aanpassen
            for (int x = 0; x < randomList.Count; x++)
                {
              

                    if (indexA <= part)
                    {
                        randomList[x] = indexB;
                        randomList[x + 1] = indexA;
                    }
                }
               
            
            array = randomList;
        }



    
    }
}
