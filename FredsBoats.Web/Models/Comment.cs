using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FredsBoats.Web.Models
{
    public class Comment
    {
        [Key]
        public int commentsId { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public DateTime CreatedAt { get; set; }
        public int boatId { get; set; }

        [ForeignKey("boatId")]
        public Boat? Boat { get; set; }
    }
}