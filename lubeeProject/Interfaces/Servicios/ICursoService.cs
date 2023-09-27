using lubeeProject.Modelos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace lubeeProject.Interfaces.Servicios
{
	public interface ICursoService
	{
		Task<List<Curso>> GetCursoById(int id);
		Task<List<Curso>> GetCursos();
		Task InsertCurso(Curso curso);
	}
}
