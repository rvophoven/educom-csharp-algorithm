using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BornToMove
{
    internal class Program
    {

        private static Move myID = new Move ();

        static void Main(string[] args)
        {
            Console.WriteLine("Get moving!!!!!!!!!!!");
            Console.WriteLine("");
            Console.WriteLine("Do you want a suggestion or to choose?");
            Console.WriteLine("1: Suggestion");
            Console.WriteLine("2: choose");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("What exercise do you wanna do?");
            

            //placeholders get database
            Console.WriteLine("0: create");
            Console.WriteLine("1: Push up");
            Console.WriteLine("2: Planking");
            Console.WriteLine("3: Squat");
            Console.WriteLine("Type the number for more information.");
            choice = Convert.ToInt32(Console.ReadLine());
            myID.ID();

            Console.WriteLine("What dit you thing of the exercise:");
            string comment = Console.ReadLine();
            Console.Write("And from 1-5 how intense was it:");
            int score = Convert.ToInt32(Console.ReadLine());


            Console.ReadLine();//hold end
        }
    }
}
