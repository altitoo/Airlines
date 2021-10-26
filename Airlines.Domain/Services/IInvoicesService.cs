using Airlines.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines.Domain.Services
{
    public interface IInvoicesService
    {
        List<Invoices> GetAll();
    }
}