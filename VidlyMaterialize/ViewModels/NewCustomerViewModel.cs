using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyMaterialize.Models;

namespace VidlyMaterialize.ViewModels
{
    public class NewCustomerViewModel
    {
        public IEnumerable<Gender> Genders { get; set; }
        public Customer Customer { get; set; }
    }
}