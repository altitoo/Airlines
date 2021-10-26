using Airlines.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines.Infra.Context
{
    public class AirlineMapping : EntityTypeConfiguration<Airline>
    {
        public AirlineMapping()
        {
            HasKey(i => i.Id);
            Property(i => i.Name);
            Property(i => i.CreationYear);
            Property(i => i.AvgAnualInvoice);
            ToTable("Airline");
        }
    }
}