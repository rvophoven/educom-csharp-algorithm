using System.ComponentModel.DataAnnotations.Schema;

namespace BornToMove.DAL2
{
    [Table("rating")]
    public class Rating
        {
            public int Id { get; set; }
            public int exer_id { get; set; }
            public int intensity { get; set; }
            public int ratings { get; set; }
        }

}
