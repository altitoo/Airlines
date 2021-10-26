using Airlines.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Airlines.MVC.Controllers
{
    public class PlaneController : Controller
    {
        private readonly IPlaneService _planeService;

        public PlaneController()
        {
            _planeService = (IPlaneService)DependencyResolver.Current.GetService(typeof(IPlaneService));
        }

        public ActionResult Index()
        {
            return View(_planeService.GetAll());
        }
    }
}