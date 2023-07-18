using System.ComponentModel.DataAnnotations;

namespace Traversal.Entities.Concrete
{
    public class Feature2
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public bool Status { get; set; }
    }
}
