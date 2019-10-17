using RabbitSamples.Samples;
using System;
using System.Threading.Tasks;

namespace RabbitSamples
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var sample = new BasicPublisher();
            try
            {
                await sample.ExecuteAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                sample.Dispose();
            }
            Console.ReadKey();
        }
    }
}
