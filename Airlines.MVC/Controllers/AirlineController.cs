using Airlines.Domain.Models;
using Airlines.Domain.Services;
using Airlines.MVC.App_Start;
using Serilog;
using ServiceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Airlines.MVC.Controllers
{
    public class AirlineController : Controller
    {
        private readonly IAirlineService _airlineService;

        public AirlineController()
        {
            _airlineService = (IAirlineService)DependencyResolver.Current.GetService(typeof(IAirlineService));
        }

        public ActionResult Index()
        {
            var res = Executer.ExecuteAndLog(GetAllAirlines, "Datos");
            if (res.success)
                Log.Debug("Han visitado la pagina de aerolineas");
                Log.Information("Va de locos");
            {
                return View(res.data);
            }
            return View();
        }

        private List<Airline> GetAllAirlines()
        {
            List<Airline> list = new List<Airline>();
            try
            {
                list = _airlineService.GetAll();
            }
            catch (Exception)
            {
                Log.Error("Error with airline services");
            }
            return list;
        }
    }
}