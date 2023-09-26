using lubeeProject.Modelos;
namespace lubeeProject.Modelos
{
    public class Producto
	{
		public int Id { get; set; }
		public string Nombre { get; set; }
		public decimal Precio { get; set; }

		public Contrato Contrato { get; set; }
	}
}
