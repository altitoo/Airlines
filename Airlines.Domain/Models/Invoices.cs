using System;
using System.Collections.Generic;
using System.Text;

namespace Airlines.Domain.Models
{
    public class Invoices
    {
        public string PlaneRegistration { get; set; }
        public string Dni { get; set; }
        public DateTime FlightDate { get; set; }
        public decimal Cost { get; set; }
    }
}