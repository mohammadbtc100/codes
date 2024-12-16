using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Server(0) or Client(1) mode : ");
            string s = Console.ReadLine();
            int n=int.Parse(s);
            if (n == 0) 
                Server.TcpServer.Run();
            else if (n == 1)
                Client.TcpClientExample.Run();
            else
                Console.WriteLine("Your input is incorrect!");

            Console.ReadKey();
        }
    }
}
