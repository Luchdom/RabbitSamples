using RabbitMQ.Client;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace RabbitSamples.Samples
{
    public abstract class BaseSample : IDisposable
    {
        protected readonly IConnection _connection;
        protected readonly IModel _channel;
        public BaseSample()
        {
            _connection = RabbitConnectionFactory.ConnectionFactory.CreateConnection();
            _channel = _connection.CreateModel();
        }

        public abstract Task ExecuteAsync();

        public void Dispose()
        {
            _channel.Dispose();
            _connection.Dispose();
        }
    }
}