using lubeeProject.Interfaces.Servicios;
using lubeeProject.Modelos;
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
        public async Task InsertContratos(Contrato contrato)
        {
            await _contratoService.InsertContratos(contrato);
        }

        [HttpGet]
        [Route("get-contrato-by-id")]
        public async Task<Contrato> GetContratosById(int id)
        {
            return await _contratoService.GetContratosById(id);
        }
    }
}
