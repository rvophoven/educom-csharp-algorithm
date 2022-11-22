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

            Console.WriteLine("Sort time");
            stopWatch.Start();
            List<int> sortList = mySort.Sort(randomList);
            Console.WriteLine(stopWatch.Elapsed);
            stopWatch.Reset();

            checkList(sortList);

            Console.WriteLine("Rotate time");
            stopWatch.Start();
            List<int> rotateList = myRotate.Sort(randomList);
            Console.WriteLine(stopWatch.Elapsed);
            stopWatch.Stop();

            Console.WriteLine("First sorted, second unsorted and third rotated list:");

            for (int x = 0; x < sortList.Count && x < 50; x++)
            {
                Console.Write(sortList[x]);
                Console.Write(" , ");
                Console.Write(randomList[x]);
                Console.Write(" , ");
                Console.WriteLine(rotateList[x]);
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

        public static void checkList(List<int> input)// number bigger or the same as the on before?
        {
            List<int> sortList = new List<int>(input);

            for (int x = 1; x < sortList.Count; x++)
            {
                int indexA = sortList[x];
                int indexB = sortList[x - 1];

                if (indexA < indexB)
                {
                    Console.Write("One number is smaller!");
                    Console.Write(indexA);
                    Console.Write(" , ");
                    Console.WriteLine(indexB);

                }
            }
        }


    }
}
