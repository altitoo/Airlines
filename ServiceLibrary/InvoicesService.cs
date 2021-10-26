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
    public class InvoicesService : IInvoicesService
    {
        private readonly IInvoicesRepository _invoicesRepository;

        public InvoicesService(IInvoicesRepository invoicesRepository)
        {
            _invoicesRepository = invoicesRepository;
        }

        public List<Invoices> GetAll()
        {
            return _invoicesRepository.GetAll();
        }
    }
}