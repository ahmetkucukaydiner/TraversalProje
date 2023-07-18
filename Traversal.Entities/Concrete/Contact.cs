﻿using System.ComponentModel.DataAnnotations;

namespace Traversal.Entities.Concrete
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public string Mail { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string MapLocation { get; set; }
        public bool Status { get; set; }
    }
}
