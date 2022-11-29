using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BornToMove.DAL2
{
    public partial class MoveContext : DbContext
    {
        public DbSet<Exercise> exercises { get; set; }
        public DbSet<Rating> rating { get; set; }

        private string source = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\rvoph\\source\\repos\\educom-csharp-algorithm\\BornToMove\\born2move.mdf;Integrated Security=True";
        private string source2 = "Server=(localdb)\\mssqllocaldb;Database=born2move;Trusted_Connection=True;";

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(source);
            base.OnConfiguring(builder);
        }

    }
}
