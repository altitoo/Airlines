using Airlines.Domain.Services;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Airlines.MVC.Controllers
{
    public class PassengerController : Controller
    {
        private readonly IPassengersService _passengerService;

        public PassengerController()
        {
            _passengerService = (IPassengersService)DependencyResolver.Current.GetService(typeof(IPassengersService));
        }

        public ActionResult Index()
        {
            var data = _passengerService.GetAll();
            Log.Debug("Han visitado la pagina de passengers");
            return View(data);
        }
    }
}