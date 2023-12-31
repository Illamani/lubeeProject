﻿using lubeeProject.Modelos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace lubeeProject.Interfaces.Servicios
{
    public interface IContratoService
	{
		Task<List<Contrato>> GetContratos();
		Task<Contrato> GetContratosById(int id);
		Task InsertContratos(Contrato contrato);
	}
}
