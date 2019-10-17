using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RabbitSamples.Samples
{
    public class BasicPublisher : BaseSample
    {
        private const string QueueBasicPublisherName = "basic.publisher";
        public override async Task ExecuteAsync()
        {
            _channel.QueueDeclare(
                queue: QueueBasicPublisherName,
                durable: true,
                exclusive: false,
                autoDelete: false,
                arguments: null);
            
            int i = 0;
            while (i++ < 2)
            {
                string body = $"{Guid.NewGuid()}";

                _channel.BasicPublish(
                    exchange: string.Empty,
                    routingKey: QueueBasicPublisherName,
                    mandatory: false,
                    basicProperties: null,
                    body: Encoding.UTF8.GetBytes(body));

                Console.WriteLine($"Message published: {body}");
                await Task.Delay(5000);
            }
        }
    }
}
