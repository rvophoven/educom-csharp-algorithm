using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BornToMove
{
    public class Program
    {
        private static Move myMove = new Move();
        

        public static void Main(string[] args)
        {

            Console.WriteLine("Get moving!!!!!!!!!!!");

            Console.WriteLine("");
            Console.WriteLine("Do you want a suggestion or to choose?");
            Console.WriteLine("1: Suggestion");
            Console.WriteLine("2: choose");
            int choice = Convert.ToInt32(Console.ReadLine());
            while(choice != 1 && choice != 2)
            {
                Console.WriteLine("invalid number: {0}! choose again ", choice);
                choice = Convert.ToInt32(Console.ReadLine());
            }

            if(choice == 1)
            {
                suggestion();
            }else
            {
                choose();
            }
            Console.WriteLine("Finished? Then press enter.");
            Console.ReadLine();
            rating();

            Console.WriteLine("Thank you for the hard work");
            Console.ReadLine();//hold end
        }

        private static void suggestion()
        {
            //get ids and choose a random one
            int choice = 1;//random id
            myMove.getExerRow(choice);
        }

        private static void choose()
        {
            Console.WriteLine("");
            Console.WriteLine("What exercise do you wanna do?");

            Console.WriteLine("0: create exercise");
            //get exercises from database....
            Console.WriteLine("Type the number for more information.");
            int choice = Convert.ToInt32(Console.ReadLine());

            if(choice == 0)
            {
                addexer();
            }
            else
            {
                //show choice
                myMove.getExerRow(choice);
            }
        }

        private static void addexer()
        {
            Console.WriteLine("Give it a name:");
            string name = Console.ReadLine();
            //check name in database
            Console.WriteLine("Give it a discription:");
            string description = Console.ReadLine();
            Console.WriteLine("Give it a sweatrate:");
            int sweatrate = Convert.ToInt32(Console.ReadLine());

            //send to database
        }

            private static void rating()
        {
            Console.WriteLine("From 1-5 what dit you thing of the exercise?");
            int rating = Convert.ToInt32(Console.ReadLine());
            Console.Write("And from 1-5 how intense was it?");
            int score = Convert.ToInt32(Console.ReadLine());

            //send to database...
        }


        private static void connect()//old connect methode
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\rvoph\\source\\repos\\educom-csharp-algorithm\\BornToMove\\born2move.mdf;Integrated Security=True");

            string sql = "select id, name, description, sweatrate from exercises";
            SqlCommand cmd = new SqlCommand(sql, conn);

            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Console.WriteLine("{0} {1} {2} {3}", reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3));
                }
            }
            else
            {
                Console.WriteLine("No data found");
            }
            conn.Close();


        }

    }
}
