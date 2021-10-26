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
    public class PassengerService : IPassengersService
    {
        private readonly IPassengerRepository _passengerRepository;

        public PassengerService(IPassengerRepository passengerRepository)
        {
            _passengerRepository = passengerRepository;
        }

        public List<Passenger> GetAll()
        {
            return _passengerRepository.GetAll();
        }
    }
}