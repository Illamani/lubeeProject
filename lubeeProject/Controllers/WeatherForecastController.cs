using lubeeProject.Interfaces.Servicios;
using lubeeProject.Modelos;
using lubeeProject.Repositorio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
		private readonly IProductosService _productosService;

		public WeatherForecastController(ILogger<WeatherForecastController> logger, IProductosService productosService)
		{
			_logger = logger;
			_productosService = productosService;
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
		[Route("get-productos")]
		public async Task<List<Producto>> PruebaEntityFramework([FromServices] AppDbContext context)
		{
			var productos = await _productosService.GetProductos();
			return productos;
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
