using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

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
            int number = randomNumber.Next(1, array.Count);//between 1 and end. no 0.

            //Console.Write("Rotate number: ");//check rotate number but takes takesstopwatch time
            //Console.WriteLine(array[number]);

            Partitioning(number);//partitioning

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
            int part = array[number];//get the number in array
            List<int> higher = new List<int>();//make 2 listes
            List<int> lower = new List<int>();

            higher.Add(array[number]);//start higher at rotation number
            array.RemoveAt(number);//remove rotation number from list

            for (int x = 0; x < randomList.Count; x++)
            {
                    if (array[x]<= part){//if lower add
                    lower.Add(array[x]);
                    }else{              //iff higher add
                    higher.Add(array[x]);
                    }
            }
            //add together
            higher.ForEach(item => lower.Add(item));
            array = lower;
        }
    }
}
