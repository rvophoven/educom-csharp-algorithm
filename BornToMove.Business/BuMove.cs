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
        //MoveCrud();
        public static void createExercise(Exercise myExercise)
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

        public static void AddRating(Rating myRating)
        {
          
                MoveCrud.AddRating(myRating);
           

        }


        public void randomMove()
        {
            //return random move
            return;
        }

        public void randomMoves()
        {
            //return random list moves
            return;
        }

        public void checkMove()
        {
            // control move and save or if exist then update?
            return;
        }

    }
}
