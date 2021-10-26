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
    public class AirlineRepository : IAirlinesRepository
    {
        protected readonly AirlineContext _airlineContext;
        protected readonly DbSet<Airline> _airlineEntity;

        public AirlineRepository(AirlineContext airlineContext)
        {
            _airlineContext = airlineContext;
            _airlineEntity = _airlineContext.Set<Airline>();
        }

        public List<Airline> GetAll()
        {
            var entity = _airlineEntity.ToList();
            return entity;
        }

        public Airline Get(int id)
        {
            try
            {
                var entity = _airlineEntity.FirstOrDefault(x => x.Id == id);
                return entity;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}