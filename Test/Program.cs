using System;
using System.Threading;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static async Task Main(string[] args)
        {
            /*var step1 = new Step1();
            step1.TooLongProcess();
            Console.ReadLine();*/


            var step2 = new Step2();
            var tokenSource = new CancellationTokenSource();
            var cancellationToken = tokenSource.Token;
            step2.TooLongProcess(cancellationToken);
            await Task.Delay(TimeSpan.FromSeconds(5));
            tokenSource.Cancel();
            Console.ReadLine();
        }
    }
}