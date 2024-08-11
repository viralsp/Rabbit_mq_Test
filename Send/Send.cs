using System.Text;
using RabbitMQ.Client;

var factory = new ConnectionFactory() { HostName = "localhost" };
var connection = factory.CreateConnection();
var channel = connection.CreateModel();

string message = "Hello World Test";

var bodyMessage  = Encoding.UTF8.GetBytes(message);

channel.BasicPublish(exchange:"",routingKey:"Test",basicProperties:null,body:bodyMessage);

Console.WriteLine("Hello, World!");
Console.ReadLine();