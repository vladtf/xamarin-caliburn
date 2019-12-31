using System;
using System.Collections.Generic;
using System.Text;

namespace XCMDEMO.Models
{
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get => FirstName + " " + LastName; }
    }
}
