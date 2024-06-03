using RabbitMQ.Client;
namespace Models.RabbitMQ;

public class Publish
{
    public IConnection Connection { get; set; }
    public string ExchangeName { get; set; }
    public string RoutingKey { get; set; }
    public string QueueName { get; set; }

    public IModel SendToMQ(string text)
    {
        ConnectionFactory factory = new ConnectionFactory();

        factory.Uri = new Uri(uriString: "amqp://guest:guest@rabbitmq:5672");
        factory.ClientProvidedName = "Kommers Rabbit Queue";

        Connection = factory.CreateConnection();

        IModel channel = Connection.CreateModel();

        ExchangeName = $"{text}Exchange";
        RoutingKey = $"{text}-routing-key";
        QueueName = $"{text}Queue";

        channel.ExchangeDeclare(ExchangeName, ExchangeType.Direct);
        channel.QueueDeclare(QueueName, false, false, false, null);
        channel.QueueBind(QueueName, ExchangeName, RoutingKey, null);

        return channel;
    }
}
