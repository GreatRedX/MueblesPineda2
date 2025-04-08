using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace MueblesPineda
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			Task.Run(() => RecibirMensajes()); // Inicia el consumidor 
		}

		private void btnEnviar_Click(object sender, EventArgs e)
		{
			var factory = new ConnectionFactory() { HostName = "localhost", Port = 5672 };
			using var connection = factory.CreateConnection();
			using var channel = connection.CreateModel();

			channel.QueueDeclare(queue: "mi-cola",
								 durable: false,
								 exclusive: false,
								 autoDelete: false,
								 arguments: null);

			string message = txtMensaje.Text;
			var body = Encoding.UTF8.GetBytes(message);

			Invoke((MethodInvoker)(() => lstMensajes.Items.Add($"Tú: {message}")));
			channel.BasicPublish(exchange: "",
								 routingKey: "mi-cola",
								 basicProperties: null,
								 body: body);
			txtMensaje.Clear();
		}
		private void RecibirMensajes()
		{
			var factory = new ConnectionFactory()
			{
				HostName = "localhost",
				Port = 5672,
				UserName = "guest",
				Password = "guest"
			};
			using var connection = factory.CreateConnection();
			using var channel = connection.CreateModel();

			channel.QueueDeclare(queue: "mi-cola2",
								 durable: false,
								 exclusive: false,
								 autoDelete: false,
								 arguments: null);

			var consumer = new EventingBasicConsumer(channel);
			consumer.Received += (model, ea) =>
			{
				var body = ea.Body.ToArray();
				var message = Encoding.UTF8.GetString(body);

				Invoke((MethodInvoker)(() => lstMensajes.Items.Add($"Cliente: {message}")));

			};

			channel.BasicConsume(queue: "mi-cola2",
								 autoAck: true,
								 consumer: consumer);

			while (true) { } // Mantiene la escucha activa
		}

	}
}