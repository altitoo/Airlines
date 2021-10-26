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
    public class PlaneRepository : IPlaneRepository
    {
        protected readonly AirlineContext _airlineContext;
        protected readonly DbSet<Plane> _planeEntity;

        public PlaneRepository(AirlineContext airlineContext)
        {
            _airlineContext = airlineContext;
            _planeEntity = _airlineContext.Set<Plane>();
        }

        public List<Plane> GetAll()
        {
            var entity = _planeEntity.ToList();
            return entity;
        }
    }
}