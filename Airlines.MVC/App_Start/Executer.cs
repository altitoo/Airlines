using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Airlines.MVC.App_Start
{
    public static class Executer
    {
        public static void ExecuteAndLog(Action action, string message)
        {
            try
            {
                action();
            }
            catch (Exception ex)
            {
                Log.Error(ex, message);
            }
        }

        public static ActionResult<T> ExecuteAndLog<T>(Func<T> action, string message)
        {
            try
            {
                return new ActionResult<T>(action());
            }
            catch (Exception ex)
            {
                Log.Error(ex, message);
                return new ActionResult<T>(ex.Message);
            }
        }
    }
}