using Airlines.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines.Infra.Context
{
    public class InvoicesMapping : EntityTypeConfiguration<Invoices>
    {
        public InvoicesMapping()
        {
            Property(i => i.PlaneRegistration);
            HasKey(i => i.Dni);
            Property(i => i.FlightDate);
            Property(i => i.Cost);
            ToTable("Invoices");
        }
    }
}