using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BornToMove.DAL2
{
    public class MoveContext : DbContext
    {
        private string source = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\rvoph\\source\\repos\\educom-csharp-algorithm\\BornToMove\\born2move.mdf;Integrated Security=True";
       
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(source);
            base.OnConfiguring(builder);
        }

        //public DbSet<Move> Move { get; }
        // move database of mave class BornToMove

    }
}
