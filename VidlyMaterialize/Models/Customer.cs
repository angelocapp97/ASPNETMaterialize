using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VidlyMaterialize.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? Birthdate { get; set; }
    }
}