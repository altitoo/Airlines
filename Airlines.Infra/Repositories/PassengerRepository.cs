using Airlines.Domain.Models;
using Airlines.Infra.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines.Infra.Repositories
{
    public class PassengerRepository : IPassengerRepository
    {
        protected readonly AirlineContext _airlineContext;
        protected readonly DbSet<Passenger> _passengerEntity;

        public PassengerRepository(AirlineContext airlineContext)
        {
            _airlineContext = airlineContext;
            _passengerEntity = _airlineContext.Set<Passenger>();
        }

        public List<Passenger> GetAll()
        {
            var entity = _passengerEntity.ToList();
            return entity;
        }
    }
}