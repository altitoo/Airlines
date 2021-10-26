using System;

namespace Airlines.Domain.Models
{
    public class Plane
    {
        public string Registration { get; set; }
        public string Mark { get; set; }
        public string Model { get; set; }
        public int FabricationYear { get; set; }
        public int Revisions { get; set; }
        public int AirlineId { get; set; }
    }
}