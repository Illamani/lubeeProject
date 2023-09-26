using lubeeProject.Interfaces.Repositorios;
using lubeeProject.Modelos;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace lubeeProject.Repositorio
{
	public class ProductosRepositorio : IProductosRepositorio
	{
        private readonly AppDbContext _context;
        public ProductosRepositorio(AppDbContext dbContext)
        {
            _context = dbContext;
        }

        public async Task<List<Producto>> GetProductos()
        {
            var productos = await _context.Producto.ToListAsync();
            return productos;
        }

        public async Task InsertProducto(Producto producto)
        {
            await _context.Producto.AddAsync(producto);
            await _context.SaveChangesAsync();
        }
    }
}
