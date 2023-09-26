using lubeeProject.Interfaces.Repositorios;
using lubeeProject.Modelos;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace lubeeProject.Repositorio
{
    public class ContratoRepositorio : IContratoRepositorio
    { 
        private readonly AppDbContext _context;
        public ContratoRepositorio(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Contrato>> GetContratos()
        {
            return await _context.Contrato.ToListAsync();
        }

        public async Task InsertContratos(Contrato contrato)
        {
            await _context.Contrato.AddAsync(contrato);
            await _context.SaveChangesAsync();
        }

	}
}
