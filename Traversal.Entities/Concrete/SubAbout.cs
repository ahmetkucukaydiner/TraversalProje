using System.ComponentModel.DataAnnotations;

namespace Traversal.Entities.Concrete
{
    public class SubAbout
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

    }
}
