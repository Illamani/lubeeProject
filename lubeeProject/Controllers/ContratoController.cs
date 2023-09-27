using lubeeProject.Interfaces.Servicios;
using lubeeProject.Modelos;
using lubeeProject.Modelos.Inputs;
using lubeeProject.Modelos.Outputs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace lubeeProject.Controllers
{
    [Route("api/[controller]")]
	[ApiController]
	public class ContratoController : ControllerBase
	{
        private readonly IContratoService _contratoService;
		private readonly MapperlyMapper _mapperly = new();
		public ContratoController(IContratoService contratoService)
        {
            _contratoService = contratoService;
        }


        [HttpGet]
        [Route("get-contratos")]
        public async Task<List<Contrato>> GetContratos()
        {
            return await _contratoService.GetContratos();
        }

        [HttpPost]
        [Route("insert-contratos")]
        public async Task InsertContratos(ContratoInput contrato)
        {
            var contratoMapeo = _mapperly.Map(contrato);
            await _contratoService.InsertContratos(contratoMapeo);
        }

        [HttpGet]
        [Route("get-contrato-by-id")]
        public async Task<ContratoOutput> GetContratosById(int id)
        {
            var contratoById = await _contratoService.GetContratosById(id);
            return _mapperly.Map(contratoById);
        }
    }
}
