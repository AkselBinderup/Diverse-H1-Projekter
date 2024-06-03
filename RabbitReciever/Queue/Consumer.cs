using RabbitMQ.Client.Events;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Consumer;
public class Consume
{
    public IConnection Connection { get; set; }
    public string ExchangeName { get; set; }
    public string RoutingKey { get; set; }
    public string QueueName { get; set; }
    public IModel Channel { get; set; }

    public EventingBasicConsumer Consumer(string name)
    {
        try
        {
            ConnectionFactory factory = new();
            factory.Uri = new Uri(uriString: "amqp://guest:guest@rabbitmq:5672");
            factory.ClientProvidedName = "SFTP watcher sender";

            Connection = factory.CreateConnection();

            Channel = Connection.CreateModel();

            ExchangeName = $"{name}-Exchange";
            RoutingKey = $"{name}-routing-key";
            QueueName = $"{name}-Queue";

            Channel.ExchangeDeclare(ExchangeName, ExchangeType.Direct);
            Channel.QueueDeclare(QueueName, false, false, false, null);
            Channel.QueueBind(QueueName, ExchangeName, RoutingKey, arguments: null);
            Channel.BasicQos(0, 1, false);

            var consumer = new EventingBasicConsumer(Channel);

            return consumer;

        }
        catch (Exception ex)
        {
            Console.WriteLine("consumer " + ex.ToString());
            throw;
        }
    }
}