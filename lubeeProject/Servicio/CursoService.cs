using lubeeProject.Interfaces.Repositorios;
using lubeeProject.Interfaces.Servicios;
using lubeeProject.Modelos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace lubeeProject.Servicio
{
	public class CursoService : ICursoService
	{
		private readonly ICursoRepositorio _cursoRepositorio;

        public CursoService(ICursoRepositorio cursoRepositorio)
        {
            _cursoRepositorio = cursoRepositorio;
        }

        public async Task<List<Curso>> GetCursoById(int id)
        {
            return await _cursoRepositorio.GetCursoById(id);
        }

		public async Task<List<Curso>> GetCursos()
        {
            return await _cursoRepositorio.GetCursos();
        }

        public async Task InsertCurso(Curso curso)
        {
            await _cursoRepositorio.InsertCurso(curso);
        }
    }
}
