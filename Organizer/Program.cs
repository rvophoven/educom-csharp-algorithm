using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace Organizer
{
    public class Program
    {
        private static Stopwatch stopWatch = new Stopwatch();
        private static ShiftHighestSort mySort = new ShiftHighestSort();
        private static RotateSort myRotate = new RotateSort();

        public static void Main(string[] args)
        {
            Console.WriteLine("How many numbers in list?");

            int amount = Convert.ToInt32(Console.ReadLine());//get number of objects in list

            List<int> randomList = MakeList(amount);
            stopWatch.Start();
            Console.WriteLine(stopWatch.Elapsed);//test time
            List<int> sortList = mySort.Sort(randomList);
            Console.WriteLine(stopWatch.Elapsed);
            stopWatch.Stop();

            Console.WriteLine("First sorted and second unsorted list:");

            for (int x = 0; x < sortList.Count && x < 50 ; x++)
            {
                Console.Write(sortList[x]);
                Console.Write(" , ");
                Console.WriteLine(randomList[x]);
            }

            List<int> sortList2 = mySort.SortFunction(randomList);

            Console.WriteLine("Sorted list:");

            for (int x = 0; x < sortList.Count && x < 50; x++)
            {
                Console.WriteLine(sortList2[x]);
            }



        }

        /* Example of a static function */

        /// <summary>
        /// Show the list in lines of 20 numbers each
        /// </summary>
        /// <param name="label">The label for this list</param>
        /// <param name="theList">The list to show</param>
        public static List<int> MakeList(int amount)//(string label, List<int> theList)
        {
            Random randomNumber = new Random();
            List<int> randomList = new List<int>();

            for (int x = 0; x < amount; x++)
            {
                randomList.Add(randomNumber.Next(-99, 99));// returns random integers >= -99 and < 99
            }

            return randomList;

        }

        public static void checkList()// number bigger or the same as the on before?
        {

        }


    }
}
