using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStreamApp.DataStream
{
    public class DataConsumer
    {
        public void Subscribe(DataProducer producer)
        {
            producer.DataProduced += OnDataProduced; // Subscribe to the event
        }

        private void OnDataProduced(int data)
        {
            Console.WriteLine($"Received: {data}");
        }
    }

}
