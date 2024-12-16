using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataStreamApp.DataStream
{
    public class DataProducer
    {
        public event Action<int> DataProduced; // Event to notify when data is produced

        public async Task StartProducingDataAsync(CancellationToken cancellationToken)
        {
            for (int i = 0; i < 10; i++)
            {
                // Simulate data generation delay
                await Task.Delay(1000, cancellationToken); // Delay for 1 second

                // Raise the event to notify subscribers
                DataProduced?.Invoke(i);
            }
        }
    }

}
