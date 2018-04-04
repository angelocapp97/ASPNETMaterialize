using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VidlyMaterialize.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(255)]
        public string LastName { get; set; }

        public DateTime? Birthdate { get; set; }

        [Required]
        public bool IsSubscribedToNewsletter { get; set; }

        [Required]
        public Gender Gender { get; set; }
        public byte GenderId { get; set; }
    }
}