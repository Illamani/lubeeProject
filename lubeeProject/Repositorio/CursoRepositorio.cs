using lubeeProject.Interfaces.Repositorios;
using lubeeProject.Modelos;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lubeeProject.Repositorio
{
	public class CursoRepositorio : ICursoRepositorio
	{
		private AppDbContext _context;
        public CursoRepositorio(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Curso>> GetCursos()
        {
            var curso = await _context.Curso.Include(x => x.Contrato).ThenInclude(x => x.Producto).ToListAsync();
            return curso;
		}

        public async Task<List<Curso>> GetCursoById(int id)
        {
			var curso = await _context.Curso.Where(x => x.Id == id)
				.Include(x => x.Contrato)
				.ThenInclude(x => x.Producto)
				.ToListAsync();
            return curso;
		}

        public async Task InsertCurso(Curso curso)
        {
            await _context.Curso.AddAsync(curso);
            await _context.SaveChangesAsync();
        }

    }
}
