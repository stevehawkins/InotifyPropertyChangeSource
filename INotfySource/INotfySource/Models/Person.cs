using System;
using System.Collections.Generic;
using System.Text;

// in reality we would pull these from a db or service
namespace INotfySource.Models
{
    public  class Person
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PersonInfo()
        {
            return $"{FirstName} {LastName} Age:{Age}";
        }
    }
}
