using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BornToMove.DAL2
{
    public class MoveCrud : MoveContext
    {
       // public static MoveContext myMoves = new MoveContext();

        //rewrite
        //using var db = new MoveContext();

        //create
        //db.Add(insert....);
        //db.SaveChanges();
        //public Exercises Add(Exercises exercise)
        //{
       //     exercise.Id = 
       // }


        public static void CreateExercises(Exercise myExercise)
        {

            using (var db = new MoveContext())
            {
                db.exercises.Add(myExercise);
                db.SaveChanges();
            }
            
            
        }

        public static void AddRating(Rating myRating)
        {

            using (var db = new MoveContext())
            {
                db.rating.Add(myRating);
                db.SaveChanges();
            }


        }



        // public static List<MoveContext.Exercises> getExersises
        // {
        //     MoveContext.Exercises.Select
        // }


        //read
        //db......OrderBy(b => b.Id).First();

        //update
        //rating.ratings.Add(insert....);

        //delete
        //db.remove();
        //db.SaveChanges();

        //get move id
        //getMoveById

        //getAllMoves -> use movecontext





    }
}
