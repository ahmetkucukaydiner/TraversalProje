using System.ComponentModel.DataAnnotations;

namespace Traversal.Entities.Concrete
{
    public class Testimonial
    {
        [Key]
        public int Id { get; set; }
        public string Client { get; set; }
        public string Comment { get; set; }
        public string ImageUrl { get; set; }
        public bool Status { get; set; }
    }
}
