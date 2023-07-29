namespace Traversal.Entities.Concrete
{
    public class Reservation
    {
        public int Id { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public int PersonCount { get; set; }
        public string Destination { get; set; }
        public DateTime ReservationDate { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
    }
}
