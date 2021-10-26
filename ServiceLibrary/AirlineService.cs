using Airlines.Domain.Models;
using Airlines.Domain.Services;
using Airlines.Infra.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLibrary
{
    public class AirlineService : IAirlineService
    {
        private readonly IAirlinesRepository _airlineRepository;

        public AirlineService(IAirlinesRepository airlineRepository)
        {
            _airlineRepository = airlineRepository;
        }

        public Airline Get(int id)
        {
            return _airlineRepository.Get(id);
        }

        public List<Airline> GetAll()
        {
            return _airlineRepository.GetAll();
        }
    }
}