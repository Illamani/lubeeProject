using lubeeProject.Modelos.Inputs;
using lubeeProject.Modelos.Outputs;
using Riok.Mapperly.Abstractions;
using System.Collections.Generic;

namespace lubeeProject.Modelos
{
	[Mapper]
	public partial class MapperlyMapper
	{
		public partial Contrato Map(ContratoInput contrato);
		public partial Curso Map(CursoInput curso);
		public partial Producto Map(ProductoInput producto);
		public partial Contrato Map(ContratoOutput contrato);

		public partial ContratoOutput Map(Contrato contrato);
		public partial List<ContratoOutput> Map(List<Contrato> contrato);
		public partial List<CursoOutput> Map(List<Curso> contrato);
		public partial CursoInput Map(Curso curso);
		public partial ProductoInput Map(Producto producto);
	}
}