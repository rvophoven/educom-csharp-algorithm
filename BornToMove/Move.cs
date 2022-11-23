using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BornToMove
{
    public class Move
    {
        public int[] id { get; set; }
        public string[] name { get; set; }
        public string[] description { get; set; }
        public int[] sweatrate { get; set; }

        private string source = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\rvoph\\source\\repos\\educom-csharp-algorithm\\BornToMove\\born2move.mdf;Integrated Security=True";


        public void getExerColm(string name)
        {

            SqlConnection conn = new SqlConnection(source);

            string sql = "select " + name + " from exercises";
            
            SqlCommand cmd = new SqlCommand(sql, conn);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Console.WriteLine("{0}", reader.GetString(0));  
                }
            }else{Console.WriteLine("No data found");}
            conn.Close();

        }

        public void getExerRow(int id)
        {
            SqlConnection conn = new SqlConnection(source);

            string sql = "select name, description, sweatrate from exercises where id=" + id;

            SqlCommand cmd = new SqlCommand(sql, conn);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Console.WriteLine("name: {0}",reader.GetString(0));
                    Console.WriteLine("Description: {0}",reader.GetString(1));
                    Console.WriteLine("Sweatrate: {0}",reader.GetInt32(2));
                }
            }
            else { Console.WriteLine("No data found"); }
            conn.Close();

        }

        public void setExerRow(string name, string descript, int rate)
        {
            SqlConnection conn = new SqlConnection(source);
            //change to insert.............
            string sql = "select name, description, sweatrate from exercises where";
            //change
            SqlCommand cmd = new SqlCommand(sql, conn);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            conn.Close();

        }

        public void setRatingRow(int score, int rate)
        {
            SqlConnection conn = new SqlConnection(source);
            //change to insert.............
            string sql = "select name, description, sweatrate from exercises where";
            //change
            SqlCommand cmd = new SqlCommand(sql, conn);

            conn.Open();
            
            conn.Close();

        }






    }
}
