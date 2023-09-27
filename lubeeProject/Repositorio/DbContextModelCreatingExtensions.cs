using lubeeProject.Modelos;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace lubeeProject.Repositorio
{
	public static class DbContextModelCreatingExtensions
	{
		public static void ConfigureDbContextService(this ModelBuilder builder)
		{
			builder.Entity<Producto>(e =>
			{
				e.ToTable("producto");
				e.HasKey(x => x.Id).HasName("Id");
				e.Property(x => x.Nombre).HasColumnName("Nombre");
				e.Property(x => x.Precio).HasColumnName("Precio");

				e.HasOne(x => x.Contrato).WithOne(x => x.Producto).HasPrincipalKey<Producto>(x => x.Id).HasForeignKey<Contrato>(x => x.ItemId);
			});

			builder.Entity<Curso>(e =>
			{
				e.ToTable("curso");
				e.HasKey(x => x.Id).HasName("Id");
				e.Property(x => x.CourseCode).HasColumnName("CourseCode");
				e.Property(x => x.FechaAlta).HasColumnName("FechaAlta");
				e.Property(x => x.Estado).HasColumnName("Estado");
				e.Property(x => x.CantidadEgresado).HasColumnName("CantidadEgresado");
				e.Property(x => x.MediaEntrega).HasColumnName("MediaEntrega");
				e.Property(x => x.Vendedor).HasColumnName("Vendedor");
				e.Property(x => x.ColegioNivel).HasColumnName("ColegioNivel");
				e.Property(x => x.ColegioNombre).HasColumnName("ColegioNombre");
				e.Property(x => x.ColegioCurso).HasColumnName("ColegioCurso");
				e.Property(x => x.ColegioLocalidad).HasColumnName("ColegioLocalidad");
				e.Property(x => x.Comision).HasColumnName("Comision");
				e.Property(x => x.Total).HasColumnName("Total");

				e.HasMany(e => e.Contrato).WithOne(e => e.Curso).HasForeignKey(x => x.ContractId).HasPrincipalKey(e => e.Id);
			});

			builder.Entity<Contrato>(e =>
			{
				e.ToTable("contrato");
				e.HasKey(x => x.Id).HasName("Id");
				e.Property(x => x.ContractId).HasColumnName("ContractId");
				e.Property(x => x.ItemId).HasColumnName("ItemId");
				e.Property(x => x.CreatedDate).HasColumnName("CreatedDate");
				e.Property(x => x.UpdateDate).HasColumnName("UpdateDate");
				e.Property(x => x.Enabled).HasColumnName("Enabled");
				e.Property(x => x.Deleted).HasColumnName("Deleted");
				e.Property(x => x.CreatedBy).HasColumnName("CreatedBy");

				e.HasOne(x => x.Curso).WithMany(x => x.Contrato).HasForeignKey(x => x.ContractId);
				e.HasOne(x => x.Producto).WithOne(x => x.Contrato).HasPrincipalKey<Contrato>(x => x.ItemId).HasForeignKey<Producto>(x => x.Id);
			});
		}
	}
}
