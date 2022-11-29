using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BornToMove.Business;
using BornToMove.DAL2;

namespace BornToMove2
{
    public class Program
    {
        private static Move myMove = new Move();

        //..............................................................................
        public static void Main(string[] args)
        {

            //test add exercise and add rating
            Exercise newExercise = new Exercise() { Name = "test6", description = "test6", sweatrate = 2 };
            BuMove.createExercise(newExercise);

            Rating newRating = new Rating() { exer_id = 1, intensity = 1, ratings = 1 };
            BuMove.AddRating(newRating);



            Console.WriteLine("Get moving!!!!!!!!!!!");
            Console.WriteLine("");
            Console.WriteLine("Do you want a suggestion or to choose?");
            Console.WriteLine("1: Suggestion");
            Console.WriteLine("2: choose");
            int choice = Convert.ToInt32(Console.ReadLine());
            while (choice != 1 && choice != 2)
            {
                Console.WriteLine("invalid number: {0}! choose again ", choice);
                choice = Convert.ToInt32(Console.ReadLine());
            }

            if (choice == 1)
            {
                suggestion();
            }
            else
            {
                choice = choose();
            }

            if (choice != 0)//get rating if chosen to do a exercise
            { addRating(choice); }


            Console.WriteLine("Thank you for the hard work");
            Console.ReadLine();//hold end
        }
        //..............................................................................
        private static void suggestion()
        {
            List<int> randomId = myMove.getID();
            Random randomNumber = new Random();// get a random number
            int number = randomNumber.Next(1, randomId.Count);
            //get ids and choose a random one
            myMove.getExerRow(number);
            Console.WriteLine("Finished? Then press enter.");
            Console.ReadLine();
        }
        //..............................................................................
        private static int choose()
        {
            Console.WriteLine("");
            Console.WriteLine("What exercise do you wanna do?");

            Console.WriteLine("Nr:0 Name: create exercise");
            myMove.getExer();// print rest exercises
            Console.WriteLine("Type the number to start.");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 0)//if 0 add exercise
            {
                addExer();
            }
            else//else get chosen exercise
            {
                //show choice
                myMove.getExerRow(choice);
                Console.WriteLine("Finished? Then press enter.");
                Console.ReadLine();
            }
            return choice;
        }
        //..............................................................................
        private static void addExer()
        {
            Console.WriteLine("Give it a name:");
            string name = Console.ReadLine();
            int check = myMove.checkName(name); //check name in database
            while (check != 0)//name found? type again
            {
                Console.WriteLine("Name already in use:");
                name = Console.ReadLine();
                check = myMove.checkName(name);
            }
            Console.WriteLine("Give it a discription:");
            string description = Console.ReadLine();
            Console.WriteLine("Give it a sweatrate:");
            int sweatrate = Convert.ToInt32(Console.ReadLine());

            myMove.setExerRow(name, description, sweatrate); //add to database
        }
        //..............................................................................
        private static void addRating(int id)
        {
            Console.WriteLine("From 1-5 what dit you thing of the exercise?");
            int rating = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("And from 1-5 how intense was it?");
            int score = Convert.ToInt32(Console.ReadLine());
            myMove.setRatingRow(id, score, rating);//add to database...
        }
        //..............................................................................
    }
}