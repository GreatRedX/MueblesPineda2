using Microsoft.AspNetCore.Mvc;
using RabbitMQ.Client;
using System.Text;

[Route("api/[controller]")]
[ApiController]
public class MessageController : ControllerBase
{
	private readonly string _hostname = "localhost";

	[HttpPost("to-app")]
	public IActionResult EnviarAMiCola2([FromBody] string message)
	{
		var factory = new ConnectionFactory() { HostName = _hostname };
		using var connection = factory.CreateConnection();
		using var channel = connection.CreateModel();

		channel.QueueDeclare(queue: "mi-cola2", durable: false, exclusive: false, autoDelete: false);
		var body = Encoding.UTF8.GetBytes(message);
		channel.BasicPublish(exchange: "", routingKey: "mi-cola2", body: body);

		return Ok("Mensaje enviado a la app");
	}

	[HttpGet("from-app")]
	public IActionResult RecibirDesdeMiCola()
	{
		var factory = new ConnectionFactory() { HostName = _hostname };
		using var connection = factory.CreateConnection();
		using var channel = connection.CreateModel();

		channel.QueueDeclare(queue: "mi-cola", durable: false, exclusive: false, autoDelete: false);
		var result = channel.BasicGet("mi-cola", true);

		if (result == null)
			return Ok("");

		return Ok(Encoding.UTF8.GetString(result.Body.ToArray()));
	}
}
