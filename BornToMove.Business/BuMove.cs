using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BornToMove.DAL2;

namespace BornToMove.Business
{
    public class BuMove
    {
        
        public static void CreateExercise(Exercise myExercise) // add exercise
        {
            if (myExercise.Name == "test")//test if name in database get new name
            {
                Console.WriteLine("Error");
            }
            else// name correct send to database
            {
                MoveCrud.CreateExercises(myExercise);
            }  

        }
        //..............................................................................
        public static void CreateRating(Rating myRating)// add rating
        {
                MoveCrud.CreateRating(myRating);
        }
        //..............................................................................
        public static void CreateExerRating(ExerRating myRating)// add rating
        {
            MoveCrud.CreateExerRating(myRating);
        }
        //..............................................................................
        public static List<Exercise> GetAllExercises() //get all exercises
        {
            List<Exercise> get = new List<Exercise>();
            get = MoveCrud.GetAllExercises();
            return get;
        }
        //..............................................................................
        public static Exercise GetExerciseById(int myId)//get an exercise by id
        {
            Exercise get = new Exercise();
            get = MoveCrud.GetExerciseById(myId);
            return get;
        }
        //..............................................................................
        public static Exercise RandomExercise()
        {
            List<Exercise> ListExercise = new List<Exercise>();
            Random randomNumber = new Random();// get a random number
            ListExercise = MoveCrud.GetAllExercises();
            //ListExercise = ListExercise.Select(p => new Exercise { Id = p.Id }).ToList();
            int index = randomNumber.Next(ListExercise.Count);
            Exercise exercise = GetExerciseById(index);

            //return random move
            return exercise;
        }
        //..............................................................................
        public static bool CheckExercise(string name)// check if name valid
        {
            bool check = false;
            List<Exercise> ListExercises = new List<Exercise>();
            ListExercises = GetAllExercises();
            foreach (var get in ListExercises)
            {
                if (get.Name == name)
                {
                    check = true;
                }
            }
            return check;
        }
        //..............................................................................
        public static double GetAvarageRatingById(int myId)//get average ratings by id
        {
            List<double> ListRatings = new List<double>();
            var get = MoveCrud.GetAllRatingById(myId).Average();

            return get;
        }

    }
}
