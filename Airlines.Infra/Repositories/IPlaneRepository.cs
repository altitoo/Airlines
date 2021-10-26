using Airlines.Domain.Models;
using System.Collections.Generic;

namespace Airlines.Infra.Repositories
{
    public interface IPlaneRepository
    {
        List<Plane> GetAll();
    }
}