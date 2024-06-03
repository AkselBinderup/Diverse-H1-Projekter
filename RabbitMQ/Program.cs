using System.Diagnostics;
using System.Text;
using Models.RabbitMQ;
using Newtonsoft.Json;
using RabbitMQ.Client;

Publish publisher = new Publish();
string message = "Docker rabbit message test test";

using (var publish = publisher.SendToMQ("SortedEmployeeAPI"))
{
    var serialized = JsonConvert.SerializeObject(message);
    byte[] messageBodyBytes = Encoding.UTF8.GetBytes(serialized);
    Debug.WriteLine("Sent message");
    publish.BasicPublish(publisher.ExchangeName, publisher.RoutingKey, null, messageBodyBytes);
}