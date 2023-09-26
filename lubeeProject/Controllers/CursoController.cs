using lubeeProject.Interfaces.Servicios;
using lubeeProject.Modelos;
using lubeeProject.Modelos.Inputs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace lubeeProject.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CursoController : ControllerBase
	{
		private readonly ICursoService _cursoService;
		private readonly MapperlyMapper _mapperly = new();
		public CursoController(ICursoService cursoService)
		{
			_cursoService = cursoService;
		}

		[HttpGet]
		[Route("get-cursos")]
		public async Task<List<Curso>> GetCursos()
		{
			return await _cursoService.GetCursos();
		}

		[HttpPost]
		[Route("insert-curso")]
		public async Task InsertCurso(CursoInput curso)
		{
			var cursoMapeo = _mapperly.Map(curso);
			await _cursoService.InsertCurso(cursoMapeo);
		}
    }
}
