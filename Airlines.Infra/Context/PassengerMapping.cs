using Airlines.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines.Infra.Context
{
    public class PassengerMapping : EntityTypeConfiguration<Passenger>
    {
        public PassengerMapping()
        {
            HasKey(i => i.Dni);
            Property(i => i.FullName);
            Property(i => i.BirthDate);
            Property(i => i.Retired);
            ToTable("Passenger");
        }
    }
}