using System.ComponentModel.DataAnnotations.Schema;

namespace BornToMove.DAL2
{
    [Table("ExerRating")]
    public class ExerRating
    {
        public int Id { get; set; }
        public Exercise Exercise { get; set; }
        public double Rating { get; set; }
        public double Vote { get; set; }
    }
}
