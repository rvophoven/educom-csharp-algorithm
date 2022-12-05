using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;


namespace BornToMove.DAL2
{
    public class MoveCrud
    {
        //..............................................................................
        public static void UpdateExercises(Exercise myExercise)
        {
            using (var db = new MoveContext())
            {
                db.exercises.Update(myExercise);
                db.SaveChanges();
            }
        }
        //..............................................................................
        public static void DeleteExercises(Exercise myExercise)
        {
            using (var db = new MoveContext())
            {
                db.exercises.Remove(myExercise);
                db.SaveChanges();
            }
        }
        //..............................................................................
        public static void CreateExercises(Exercise myExercise)
        {
            using (var db = new MoveContext())
            {
                db.exercises.Add(myExercise);
                db.SaveChanges();
            }    
        }
        //..............................................................................
        public static void CreateRating(Rating myRating)
        {
            using (var db = new MoveContext())
            {
                db.rating.Add(myRating);
                db.SaveChanges();
            }
        }
        //..............................................................................
        public static void CreateExerRating(ExerRating myRating)
        {
            //Console.WriteLine("{0},{1},{2},{3}",myRating.Exercise.Id,myRating.Rating,myRating.Vote,myRating.Exercise.Name);
            using (var db = new MoveContext())
            {
                //myRating.Exercise = db.exercises.Find(myRating.Exercise.Id);
                db.Attach(myRating.Exercise);
                db.ExerRating.Add(myRating);
                db.SaveChanges();
            }
        }
        //..............................................................................
        public static Exercise GetExerciseById(int myId)
        {
            Exercise getExercise = new Exercise();

            using (var db = new MoveContext())
            {
              getExercise =  db.exercises.First(a => a.Id == myId);
            }
            return getExercise;
        }
        //..............................................................................
        public static List<Exercise> GetAllExercisesIds()
        {
            List<Exercise> getExercise = new List<Exercise>();

            using (var db = new MoveContext())
            {
                getExercise = db.exercises.Select(p => new Exercise { Id = p.Id}).ToList();
            }

            return getExercise;
        }
        //..............................................................................
        public static List<Exercise> GetAllExercises()
        {
            List<Exercise> getExercise = new List<Exercise>() ;

            using (var db = new MoveContext())
            {
                getExercise = db.exercises.ToList();   
            }

            return getExercise;
        }
        //..............................................................................
        public static List<double> GetAllRatingById(int myId)//get all ratings by id
        {
            List<double> getRating = new List<double>();
            using (var db = new MoveContext())
            {
                getRating = db.ExerRating.Where(a => a.Exercise.Id == myId).Select(a => a.Rating).ToList();
            }
            if (getRating.Count == 0)//if empty make 0
            {
                getRating.Add(0);
            }
            return getRating; 
        }







    }
}
