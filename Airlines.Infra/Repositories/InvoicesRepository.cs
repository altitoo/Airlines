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
    public class InvoicesRepository : IInvoicesRepository
    {
        protected readonly AirlineContext _airlineContext;
        protected readonly DbSet<Invoices> _invoicesEntity;

        public InvoicesRepository(AirlineContext airlineContext)
        {
            _airlineContext = airlineContext;
            _invoicesEntity = _airlineContext.Set<Invoices>();
        }

        public List<Invoices> GetAll()
        {
            try
            {
                var entity = _invoicesEntity.ToList();
                return entity;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}