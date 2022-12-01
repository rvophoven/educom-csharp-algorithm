using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
        public static List<Exercise> GetExerciseById(int myId)
        {
            List<Exercise> getExercise = new List<Exercise>();

            using (var db = new MoveContext())
            {
              getExercise =  db.exercises.Where(a => a.Id == myId).ToList();
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
       






    }
}
