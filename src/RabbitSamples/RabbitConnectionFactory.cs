using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace RabbitSamples
{
    public class RabbitConnectionFactory
    {
        internal static ConnectionFactory ConnectionFactory => new ConnectionFactory()
        {
            HostName = "localhost",
            UserName = "guest",
            Password = "guest",
            Port = 5672,
            RequestedConnectionTimeout = 3000, // milliseconds
        };
    }
}
