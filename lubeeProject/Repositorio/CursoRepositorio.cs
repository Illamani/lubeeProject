using lubeeProject.Interfaces.Repositorios;
using lubeeProject.Modelos;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
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
            return await _context.Curso.ToListAsync();
        }

        public async Task InsertCurso(Curso curso)
        {
            await _context.Curso.AddAsync(curso);
            await _context.SaveChangesAsync();
        }

    }
}
