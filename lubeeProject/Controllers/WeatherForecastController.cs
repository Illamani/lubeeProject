using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lubeeProject.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class WeatherForecastController : ControllerBase
	{
		private static readonly string[] Summaries = new[]
		{
			"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
		};

		private readonly ILogger<WeatherForecastController> _logger;

		public WeatherForecastController(ILogger<WeatherForecastController> logger)
		{
			_logger = logger;
		}

		[HttpGet]
		[Route("pruebamysql")]
		public async Task PruebaSql()
		{
			using var connection = new MySqlConnection("Server=localhost;Port=3306;Database=lubee_project;User=root;Password=M@nzana12345;");
			await connection.OpenAsync();

			using var command = new MySqlCommand("SELECT * FROM producto;", connection);
			using var reader = await command.ExecuteReaderAsync();
			while (await reader.ReadAsync())
			{
				var value = reader.GetValue(0);
				// do something with 'value'
			}
		}

		[HttpGet]
		public IEnumerable<WeatherForecast> Get()
		{
			
			var rng = new Random();
			return Enumerable.Range(1, 5).Select(index => new WeatherForecast
			{
				Date = DateTime.Now.AddDays(index),
				TemperatureC = rng.Next(-20, 55),
				Summary = Summaries[rng.Next(Summaries.Length)]
			})
			.ToArray();
		}
	}
}
