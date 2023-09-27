using System;

namespace lubeeProject.Modelos.Inputs
{
	public class ContratoInput
	{
		public int Id { get; set; }
		public int ContractId { get; set; }
		public int ItemId { get; set; }
		public DateTime CreatedDate { get; set; }
		public DateTime? UpdateDate { get; set; }
		public bool Enabled { get; set; }
		public bool Deleted { get; set; }
		public string CreatedBy { get; set; }
	}
}
