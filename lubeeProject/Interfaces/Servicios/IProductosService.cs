using lubeeProject.Modelos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace lubeeProject.Interfaces.Servicios
{
	public interface IProductosService
	{
		Task<List<Producto>> GetProductos();
	}
}
