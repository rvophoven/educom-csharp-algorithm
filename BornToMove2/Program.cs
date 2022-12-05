using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BornToMove.Business;
using BornToMove.DAL2;
//                    Comment: error at null inputs
namespace BornToMove2
{
    public class Program
    {
        private static Move myMove = new Move();

        //..............................................................................
        public static void Main(string[] args)
        {
            Console.WriteLine("Get moving!!!!!!!!!!!");
            Console.WriteLine("");
            do//start loop
            {
                Console.WriteLine("Do you want a suggestion or to choose?");
                Console.WriteLine("1: Suggestion or 2: choose");
                if (NumberInput(1, 2) == 1)
                {
                    RandomExercise();//get random exercise
                }
                else
                {
                    ListExercise();//get list exercises
                }

                Console.WriteLine("Thank you for the hard work");
                Console.WriteLine("0: Exit 1: Again ");
            } while (NumberInput(0, 1) != 0);//loop true code
            Console.WriteLine("By see you later.");
        }
        //..............................................................................

        private static void AddExercise()//add exercise to database
        {
            Console.WriteLine("Give it a name:");
            string name = Console.ReadLine();
            while (BuMove.CheckExercise(name)==true)//name found? type again
            {
                Console.WriteLine("Name already in use:");
                name = Console.ReadLine();
            }

            Console.WriteLine("Give it a discription:");
            string description = Console.ReadLine();
            Console.WriteLine("Give it a sweatrate:");
            int sweatrate = NumberInput(1, 5);

            Exercise newExercise = new Exercise() { Name = name, description = description, sweatrate = sweatrate };
            BuMove.CreateExercise(newExercise);

        }
        //..............................................................................
        private static void AddRating(Exercise myExercise)//add rating to database
        {
            Console.WriteLine("From 1-5 what dit you thing of the exercise?");
            double rating = NumberInput(1, 5);
            Console.WriteLine("And from 1-5 how intense was it?");
            double score = NumberInput(1, 5);
            ExerRating newRating = new ExerRating() {Exercise = myExercise, Rating = score, Vote = rating };
            BuMove.CreateExerRating(newRating);
        }
        //..............................................................................
        private static void ChoiceExercise(int choice)//show chosen exercise
        {   //comment: remove list parameter and just use exercise
            Exercise OneExercise = new Exercise();
            OneExercise = BuMove.GetExerciseById(choice);//get exercise by id

                Console.WriteLine("Name: {0}", OneExercise.Name);
                Console.WriteLine("Description: {0}", OneExercise.description);
                Console.WriteLine("Sweatrate: {0}", OneExercise.sweatrate);

            Console.WriteLine("Finished? Then press enter.");
            Console.ReadLine();

            AddRating(OneExercise);
        }
        //..............................................................................
        private static void ListExercise()//show list of exercises
        {   
            List<Exercise> ListExercises = new List<Exercise>();
            Console.WriteLine("");
            Console.WriteLine("What exercise do you wanna do?");
            Console.WriteLine("Nr: 0 Name: create exercise");
            ListExercises = BuMove.GetAllExercises();//get all exercises
            foreach (var get in ListExercises)//display all exercises
            {
                double AverageRating = BuMove.GetAvarageRatingById(get.Id);
                Console.WriteLine("Nr: {0} Name: {1} Sweatrate: {2} Average: {3}", get.Id, get.Name,get.sweatrate, AverageRating);
            }

            Console.WriteLine("Type number of exercise:");
            int choice = NumberInput(0, ListExercises.Count);//chech for valid input
            if (choice == 0)//if 0 add exercise
            {
                AddExercise();
            }
            else//else display chosen exercise
            {
                ChoiceExercise(choice);
            }
        }
        //..............................................................................
        private static void RandomExercise()//get random exercise
        {   //comment: remove list parameter and just use exercise
            Exercise OneExercise = new Exercise();
            OneExercise = BuMove.RandomExercise();//get random exercise

                Console.WriteLine("Name: {0}",OneExercise.Name);
                Console.WriteLine("Description: {0}", OneExercise.description);
                Console.WriteLine("Sweatrate: {0}", OneExercise.sweatrate);
 
            Console.WriteLine("Finished? Then press enter.");
            Console.ReadLine();
            AddRating(OneExercise);
        }
        //..............................................................................
        private static int NumberInput(int start, int end)//check readline input
        {
            int Input =0;
            int x = 0;

            while (x == 0)
            {
                if(!int.TryParse(Console.ReadLine(), out Input))//check for letters
                {
                    Console.WriteLine("Input invalid. You entered an letter");
                }else if (Input < start || Input > end)//check if number in range
                {
                    Console.WriteLine("Input invalid. Number not in range");
                }else//correct then exit loop
                {
                    x = 1;
                }  
            }
            return Input;
        }
        //..............................................................................

        private static void AverageRating() 
        {



        }


    }
}