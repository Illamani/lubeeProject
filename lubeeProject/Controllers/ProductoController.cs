using lubeeProject.Interfaces.Servicios;
using lubeeProject.Modelos;
using lubeeProject.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace lubeeProject.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductoController : ControllerBase
	{
		private readonly IProductosService _productosService;
		public ProductoController(IProductosService productosService)
		{
			_productosService = productosService;
		}

		[HttpGet]
		[Route("get-productos")]
		public async Task<List<Producto>> GetProductos()
		{
			var productos = await _productosService.GetProductos();
			return productos;
		}

		[HttpPost]
		[Route("post-productos")]
		public async Task InsertProducto(Producto producto)
		{
			await _productosService.InsertProducto(producto);
		}

	}
}
