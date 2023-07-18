using System.ComponentModel.DataAnnotations;

namespace Traversal.Entities.Concrete
{
    public class Destination
    {
        [Key]
        public int Id { get; set; }
        public string City { get; set; }
        public string DayNight { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public int Capacity { get; set; }
        public bool Status { get; set; }
    }
}
