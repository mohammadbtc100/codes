using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;

namespace OWIN
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseUrl = "http://localhost:9000";

            using (WebApp.Start<Startup>(url: baseUrl))
            {
                Console.WriteLine($"Web API is running at {baseUrl}");
                Console.WriteLine("Press Enter to quit.");
                Console.ReadLine();
            }
        }
    }

}
