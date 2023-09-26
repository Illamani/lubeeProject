using lubeeProject.Interfaces.Repositorios;
using lubeeProject.Interfaces.Servicios;
using lubeeProject.Modelos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace lubeeProject.Servicio
{
    public class ContratoService : IContratoService
	{
		private readonly IContratoRepositorio _contratoRepositorio;
		public ContratoService(IContratoRepositorio contratoRepositorio)
		{
			_contratoRepositorio = contratoRepositorio;
		}

		public async Task<List<Contrato>> GetContratos()
		{
			return await _contratoRepositorio.GetContratos();
		}

		public async Task InsertContratos(Contrato contrato)
		{
			await _contratoRepositorio.InsertContratos(contrato);
		}

		public async Task<Contrato> GetContratosById(int id)
		{
			return await _contratoRepositorio.GetContratosById(id);
		}
	}
}
