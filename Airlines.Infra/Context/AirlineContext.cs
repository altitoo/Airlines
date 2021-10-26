using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Configuration;
using Airlines.Domain.Models;

namespace Airlines.Infra.Context
{
    public class AirlineContext : DbContext
    {
        public AirlineContext(string connectionName) : base(ConfigurationManager.ConnectionStrings[connectionName].ConnectionString) //base(@"Data Source=(localdb)\Airlines;Integrated Security=True")//
        {
        }

        public DbSet<Airline> Airlines { get; set; }
        public DbSet<Invoices> Invoices { get; set; }
        public DbSet<Passenger> Passenger { get; set; }
        public DbSet<Plane> Plane { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AirlineMapping());
            modelBuilder.Configurations.Add(new InvoicesMapping());
            modelBuilder.Configurations.Add(new PassengerMapping());
            modelBuilder.Configurations.Add(new PlaneMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}