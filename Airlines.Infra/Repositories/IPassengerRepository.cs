using Airlines.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines.Infra.Repositories
{
    public interface IPassengerRepository
    {
        List<Passenger> GetAll();
    }
}