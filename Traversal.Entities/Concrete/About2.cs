using System.ComponentModel.DataAnnotations;

namespace Traversal.Entities.Concrete
{
    public class About2
    {
        [Key]
        public int Id { get; set; }
        public string Title1 { get; set; }
        public string Title2 { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

    }
}
