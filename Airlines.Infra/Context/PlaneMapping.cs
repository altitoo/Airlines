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
            HasKey(i => i.Registration);
            HasKey(i => i.Mark);
            HasKey(i => i.Model);
            HasKey(i => i.FabricationYear);
            HasKey(i => i.Revisions);
            HasKey(i => i.AirlineId);
            ToTable("Plane");
        }
    }
}