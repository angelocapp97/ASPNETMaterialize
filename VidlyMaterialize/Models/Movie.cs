using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VidlyMaterialize.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime? ReleasedDate { get; set; }
    }
}