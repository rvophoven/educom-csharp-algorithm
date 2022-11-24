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
        private List<int> id_list = new List<int>();
        public string[] name { get; set; }
        public string[] description { get; set; }
        public int[] sweatrate { get; set; }

        private string source = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\rvoph\\source\\repos\\educom-csharp-algorithm\\BornToMove\\born2move.mdf;Integrated Security=True";

        //..............................................................................
        public List<int> getID()
        {
            SqlConnection conn = new SqlConnection(source);
            string sql = "select id from exercises";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                   id_list.Add(reader.GetInt32(0));  
                }
            }else{Console.WriteLine("No data found");}
            conn.Close();
            return id_list;
        }

        public int checkName(string name)
        {
            SqlConnection conn = new SqlConnection(source);
            string sql = "select COUNT(*) from exercises where name like @name";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            cmd.Parameters.AddWithValue("@name", name);
            int nameCount = (int)cmd.ExecuteScalar();
            conn.Close();
            return nameCount;
        }

        //..............................................................................
        public void getExer()
        {
            SqlConnection conn = new SqlConnection(source);
            string sql = "select id, name, sweatrate from exercises";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Console.WriteLine("Nr:{0} Name:{1} Sweatrate: {2}", reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2));
                }
            }
            else { Console.WriteLine("No data found"); }
            conn.Close();
        }
        //..............................................................................
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
        //..............................................................................
        public void setExerRow(string name, string descript, int rate)
        {
            SqlConnection conn = new SqlConnection(source);

            string sql = "insert into exercises(name,description,sweatrate) values (@name,@descript, @rate)";
            var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@descript", descript);
            cmd.Parameters.AddWithValue("@rate", rate);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        //..............................................................................
        public void setRatingRow(int id, int score, int rate)
        {
            SqlConnection conn = new SqlConnection(source);

            string sql = "insert into rating(exer_id,intensity,rating) values (@id,@score, @rate)";
            var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@score", score);
            cmd.Parameters.AddWithValue("@rate", rate);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        //..............................................................................





    }
}
