using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace CS1.Client
{
    public class TcpClientExample
    {
        public static void Run()
        {
            try
            {
                // Connect to the server on localhost at port 11111
                TcpClient client = new TcpClient("127.0.0.1", 11111);
                NetworkStream stream = client.GetStream();

                // Message to send to the server
                string message = "Hello, Server!";
                byte[] data = Encoding.ASCII.GetBytes(message);

                // Send the message to the server
                stream.Write(data, 0, data.Length);
                Console.WriteLine($"Sent: {message}");

                // Buffer for reading responses from the server
                byte[] responseBuffer = new byte[1024];
                int bytesRead = stream.Read(responseBuffer, 0, responseBuffer.Length);

                // Decode and display the response from the server
                string responseMessage = Encoding.ASCII.GetString(responseBuffer, 0, bytesRead);
                Console.WriteLine($"Received: {responseMessage}");

                // Close everything
                stream.Close();
                client.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception: {e.Message}");
            }
        }
    }

}
