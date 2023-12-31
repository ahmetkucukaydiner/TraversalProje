﻿using System.ComponentModel.DataAnnotations;

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
        public string CoverImage { get; set; }
        public string Details1 { get; set; }
        public string Details2 { get; set; }
        public string ImageUrl2 { get; set; }
        public List<Comment> Comment { get; set; }
        public List<Reservation> Reservations { get; set; }
        public int? GuideID { get; set; }
        public Guide Guide { get; set; }
        public DateTime BlogPostDate { get; set; }
    }
}
