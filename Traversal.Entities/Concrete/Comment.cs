using System.ComponentModel.DataAnnotations;

namespace Traversal.Entities.Concrete
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }
        public bool State { get; set; }
        public int DestinationId { get; set; }
        public Destination Destination { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
