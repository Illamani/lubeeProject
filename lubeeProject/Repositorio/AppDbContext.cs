using lubeeProject.Modelos;
using Microsoft.EntityFrameworkCore;

namespace lubeeProject.Repositorio
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{
		}

		public DbSet<Producto> Producto { get; set; }
		public DbSet<Contrato> Contrato { get; set; }
		public DbSet<Curso> Curso { get; set; }
	}
}