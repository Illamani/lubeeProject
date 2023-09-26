using lubeeProject.Interfaces.Repositorios;
using lubeeProject.Interfaces.Servicios;
using lubeeProject.Modelos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace lubeeProject.Servicio
{
	public class ProductosService : IProductosService
	{
		private readonly IProductosRepositorio _productosRepositorio;
		public ProductosService(IProductosRepositorio productosRepositorio)
		{
			_productosRepositorio = productosRepositorio;
		}

		public async Task<List<Producto>> GetProductos()
		{
			return await _productosRepositorio.GetProductos();
		}

		public async Task InsertProducto(Producto producto)
		{
			await _productosRepositorio.InsertProducto(producto);
		}
	}
}
