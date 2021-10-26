using System;
using System.Collections.Generic;
using System.Text;

namespace Airlines.Domain.Models
{
    public class Passenger
    {
        public string Dni { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public bool Retired { get; set; }
    }
}