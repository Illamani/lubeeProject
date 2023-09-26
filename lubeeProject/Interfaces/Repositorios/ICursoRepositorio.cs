using lubeeProject.Modelos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace lubeeProject.Interfaces.Repositorios
{
	public interface ICursoRepositorio
	{
		Task<List<Curso>> GetCursos();
		Task InsertCurso(Curso curso);
	}
}
