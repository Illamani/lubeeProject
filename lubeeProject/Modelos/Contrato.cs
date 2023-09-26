using System;

namespace lubeeProject.Modelos
{
	public class Contrato
	{
		public int Id { get; set; }
		public int ContractId { get; set; }
		public int ItemId { get; set; }
		public DateTime CreatedDate { get; set; }
		public DateTime? UpdateDate { get; set; }
		public bool Enabled { get; set; }
		public bool Deleted { get; set; }
		public string CreatedBy { get; set; }

		public Curso Curso { get; set; }
		public Producto Producto { get; set; }
	}
}
