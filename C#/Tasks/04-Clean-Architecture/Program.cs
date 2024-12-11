using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Presentation.ConsoleApp consoleApp = new Presentation.ConsoleApp();
            consoleApp.App();

            Console.ReadKey();
        }
    }
}
