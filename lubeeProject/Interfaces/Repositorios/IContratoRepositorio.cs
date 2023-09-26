using lubeeProject.Modelos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace lubeeProject.Interfaces.Repositorios
{
    public interface IContratoRepositorio
	{
		Task<List<Contrato>> GetContratos();
		Task<Contrato> GetContratosById(int id);
		Task InsertContratos(Contrato contrato);
	}
}
