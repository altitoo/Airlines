using Airlines.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines.ConsoleView
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (var db = new AirlineContext("Airlines"))
            {
                var query = db.Airlines.Where(x => x.Id > 0).ToList();

                foreach (var item in query)
                {
                    Console.WriteLine($"{item.Id} {item.Name}");
                }
                db.SaveChanges();
                Console.ReadLine();
            }
        }
    }
}