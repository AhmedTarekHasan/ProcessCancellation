using System;
using System.Threading;
using System.Threading.Tasks;

namespace Test
{
    public class Step2
    {
        public async Task TooLongProcess(CancellationToken cancellationToken)
        {
            Console.WriteLine($"Started at {DateTime.Now}");

            for (var i = 1; i <= 10; i++)
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    Console.WriteLine($"Cancelled at {DateTime.Now}");
                    break;
                }

                await Task.Delay(TimeSpan.FromSeconds(1));
            }

            if (!cancellationToken.IsCancellationRequested)
            {
                Console.WriteLine($"Ended at {DateTime.Now}");
            }
        }
    }
}