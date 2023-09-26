using lubeeProject.Modelos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace lubeeProject.Interfaces.Repositorios
{
	public interface IProductosRepositorio
	{
		Task<List<Producto>> GetProductos();
	}
}
