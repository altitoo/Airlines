using Airlines.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Airlines.MVC.Controllers
{
    public class InvoicesController : Controller
    {
        private readonly IInvoicesService _airlineService = (IInvoicesService)DependencyResolver.Current.GetService(typeof(IInvoicesService));

        // GET: Invoices
        public ActionResult Index()
        {
            var data = _airlineService.GetAll();
            return View(data);
        }
    }
}