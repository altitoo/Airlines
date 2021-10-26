using Airlines.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines.Infra.Context
{
    public class PlaneMapping : EntityTypeConfiguration<Plane>
    {
        public PlaneMapping()
        {
            Property(i => i.Registration);
            HasKey(i => i.Mark);
            Property(i => i.Model);
            Property(i => i.FabricationYear);
            Property(i => i.Revisions);
            Property(i => i.AirlineId);
            ToTable("Plane");
        }
    }
}