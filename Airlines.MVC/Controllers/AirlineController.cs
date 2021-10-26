using Airlines.Domain.Services;
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
            var data = _airlineService.GetAll();
            return View(data);
        }
    }
}