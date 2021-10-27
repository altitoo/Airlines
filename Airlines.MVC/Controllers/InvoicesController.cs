using Airlines.Domain.Services;
using Serilog;
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
            try
            {
                var data = _airlineService.GetAll();
                Log.Debug("Han visitado la pagina de invoices");
                return View(data);
            }
            catch (Exception)
            {
                Log.Information("Fallo en el servicio de aerolineas");
            }
            return View();
        }
    }
}