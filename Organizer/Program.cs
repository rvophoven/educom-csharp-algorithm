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

            if (amount > 100)// number bigger than 100 display error
            {
                Console.WriteLine("List is to long. List is > 100.");
            }
            else//else make and show list
            {
                MakeList(amount);
            }

        }

        /* Example of a static function */

        /// <summary>
        /// Show the list in lines of 20 numbers each
        /// </summary>
        /// <param name="label">The label for this list</param>
        /// <param name="theList">The list to show</param>
        public static void MakeList(int amount)//(string label, List<int> theList)
        {
            Random randomNumber = new Random();
            List<int> randomList = new List<int>();

            Console.WriteLine("Unsorted list:");
            for (int x = 0; x < amount; x++)
            {
                randomList.Add(randomNumber.Next(-99, 99));// returns random integers >= -99 and < 99
                Console.WriteLine(randomList[x]);// print random list
            }

            stopWatch.Start();
            Console.WriteLine(stopWatch.Elapsed);//test time
            List<int> sortList = mySort.Sort(randomList); //sort random list
            Console.WriteLine(stopWatch.Elapsed);
            stopWatch.Stop();

            Console.WriteLine("Sorted list:");
            foreach (var num in sortList)// print sorted list
            {
                Console.WriteLine(num);
            }

        }

        public static void checkList()// number bigger or the same as the on before?
        {

        }


    }
}
