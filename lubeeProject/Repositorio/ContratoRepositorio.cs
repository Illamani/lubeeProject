using lubeeProject.Interfaces.Repositorios;
using lubeeProject.Modelos;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lubeeProject.Repositorio
{
	public class ContratoRepositorio : IContratoRepositorio
	{
		private readonly AppDbContext _context;
		private readonly MapperlyMapper _mapperly = new();
		public ContratoRepositorio(AppDbContext context)
		{
			_context = context;
		}

		public async Task<List<Contrato>> GetContratos()
		{
			var contrato = await _context.Contrato
				//.Include(x => x.Curso)
				//.Include(x => x.Producto)
				.ToListAsync();
			var contratoOutput = _mapperly.Map(contrato);
			return contrato;
		}

		public async Task InsertContratos(Contrato contrato)
		{
			await _context.Contrato.AddAsync(contrato);
			_context.Entry(contrato).State = EntityState.Added;
			await _context.SaveChangesAsync();
		}

		public async Task<Contrato> GetContratosById(int id)
		{
			var contrato = await _context.Contrato.Where(x => x.Id == id)
				.Include(x => x.Curso)
				.Include(x => x.Producto)
				.FirstOrDefaultAsync();
			var contratoOutput = _mapperly.Map(contrato);
			return contrato;
		}

	}
}
