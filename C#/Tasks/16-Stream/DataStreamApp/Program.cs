using DataStreamApp.DataStream;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataStreamApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var producer = new DataProducer();
            var consumer = new DataConsumer();

            consumer.Subscribe(producer); // Subscribe to receive data

            // Use a cancellation token to allow graceful shutdown
            var cancellationTokenSource = new CancellationTokenSource();

            try
            {
                Console.WriteLine("Starting data production...");
                await producer.StartProducingDataAsync(cancellationTokenSource.Token);
                Console.WriteLine("Data production completed.");
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("Data production was canceled.");
            }
            finally
            {
                cancellationTokenSource.Dispose();
            }
            Console.ReadKey();
        }
    }

}
