using System;
using System.Threading.Tasks;

namespace Test
{
    public class Step1
    {
        public async Task TooLongProcess()
        {
            Console.WriteLine($"Started at {DateTime.Now}");

            for (var i = 1; i <= 10; i++)
            {
                await Task.Delay(TimeSpan.FromSeconds(1));
            }

            Console.WriteLine($"Ended at {DateTime.Now}");
        }
    }
}