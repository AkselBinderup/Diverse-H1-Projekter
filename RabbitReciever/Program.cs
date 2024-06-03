using Consumer;
using RabbitMQ.Client;
using System.Text;

Consume _consume = new Consume();
var _consumer = _consume.Consumer("SortedEmployeeDB");

using (var _connection = _consume.Connection)
using (var _channel = _consume.Channel)
{
    _consumer.Received += (sender, args) =>
    {
        Task.Delay(TimeSpan.FromSeconds(5)).Wait();

        var body = args.Body.ToArray();

        string message = Encoding.UTF8.GetString(body);

        Console.WriteLine(message);

        _channel.BasicAck(args.DeliveryTag, false);
    };
    string consumerTag = _channel.BasicConsume(_consume.QueueName, false, _consumer);
    Console.ReadLine();
    _channel.BasicCancel(consumerTag);
}