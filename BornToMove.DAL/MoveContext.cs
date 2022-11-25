using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BornToMove.DAL
{
    
    public class MoveContext : DbContext
    {
        private string source = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\rvoph\\source\\repos\\educom-csharp-algorithm\\BornToMove\\born2move.mdf;Integrated Security=True";
        private string source2 = "Server=(localdb)\\mssqllocaldb;Database=born2move;Trusted_Connection=True;";

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(source);
            base.OnConfiguring(builder);
        }

        public DbSet<exercises> moves { get; set; }
        public DbSet<rating> rates { get; set; }
        // move database of move class BornToMove

        public class exercises
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public string Source { get; set; }

        }

        public class rating
        {
            public int Id { get; set; }
            public int exer_id { get; set; }
            public int intensity { get; set; }
            public int ratings { get; set; }


        }

    }

    
}
