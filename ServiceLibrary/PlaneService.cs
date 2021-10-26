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
    public class PlaneService : IPlaneService
    {
        private readonly IPlaneRepository _invoicesRepository;

        public PlaneService(IPlaneRepository invoicesRepository)
        {
            _invoicesRepository = invoicesRepository;
        }

        public List<Plane> GetAll()
        {
            return _invoicesRepository.GetAll();
        }
    }
}