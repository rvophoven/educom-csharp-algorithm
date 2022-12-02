using System.ComponentModel.DataAnnotations.Schema;

namespace BornToMove.DAL2
{
        // move database of move class BornToMove
        [Table("exercises")]
        public class Exercise
        {
            public int Id { get; set; }
            [Column(name : "name")]
            public string? Name { get; set; }

            public string? description { get; set; }

            public int sweatrate { get; set; }

            public ICollection<ExerRating>? Rating { get; set; }

    }

}
