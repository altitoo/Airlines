using Airlines.Domain.Services;
using Airlines.Infra.Context;
using Airlines.Infra.Repositories;
using Autofac;
using Autofac.Integration.Mvc;
using ServiceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Serilog;
using System.Configuration;

namespace Airlines.MVC
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.MSSqlServer(
                connectionString: ConfigurationManager.ConnectionStrings["Airlines"].ConnectionString,
                tableName: "Logs",
                autoCreateSqlTable: true)
                .WriteTo.File("log.txt", rollingInterval: RollingInterval.Day, rollOnFileSizeLimit: true)
                .CreateLogger();

            var builder = new ContainerBuilder();
            builder.RegisterType<AirlineContext>().WithParameter("connectionName", "Airlines");
            builder.RegisterType<AirlineRepository>().As<IAirlinesRepository>();
            builder.RegisterType<PassengerRepository>().As<IPassengerRepository>();
            builder.RegisterType<InvoicesRepository>().As<IInvoicesRepository>();
            builder.RegisterType<AirlineService>().As<IAirlineService>();
            builder.RegisterType<InvoicesService>().As<IInvoicesService>();
            builder.RegisterType<PassengerService>().As<IPassengersService>();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}