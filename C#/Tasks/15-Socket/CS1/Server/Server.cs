using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace CS1.Server
{
    public class TcpServer
    {
        public static void Run()
        {
            // Set up the server to listen on port 11111
            int port = 11111;
            IPAddress localAddr = IPAddress.Parse("127.0.0.1");
            TcpListener server = new TcpListener(localAddr, port);

            // Start listening for client requests
            server.Start();
            Console.WriteLine("Server started, waiting for a connection...");

            while (true)
            {
                // Accept an incoming client connection
                using (TcpClient client = server.AcceptTcpClient())
                {
                    Console.WriteLine("Connected to client.");
                    NetworkStream stream = client.GetStream();

                    // Buffer for reading data
                    byte[] bytes = new byte[1024];
                    int bytesRead;

                    // Read data from the client
                    while ((bytesRead = stream.Read(bytes, 0, bytes.Length)) != 0)
                    {
                        // Decode the received data and display it
                        string message = Encoding.ASCII.GetString(bytes, 0, bytesRead);
                        Console.WriteLine($"Received: {message}");

                        // Echo the message back to the client
                        byte[] msg = Encoding.ASCII.GetBytes("Echo: " + message);
                        stream.Write(msg, 0, msg.Length);
                        Console.WriteLine("Sent: " + message);
                    }
                }
            }
        }
    }

}
