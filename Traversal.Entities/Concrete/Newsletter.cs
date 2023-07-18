using System.ComponentModel.DataAnnotations;

namespace Traversal.Entities.Concrete
{
    public class Newsletter
    {
        [Key]
        public int Id { get; set; }
        public string Mail { get; set; }
    }
}
