﻿using System;
namespace lubeeProject.Modelos
{
	public class Curso
	{
		public int Id { get; set; }
		public string CourseCode { get; set; }
		public DateTime FechaAlta { get; set; }
		public int	Estado { get; set; }
		public int CantidadEgresado { get; set; }
		public DateTime FechaEntrega { get; set; }
		public int MediaEntrega { get; set; }
		public int Vendedor { get; set; }
		public string ColegioNivel { get; set; }
		public string ColegioNombre { get; set; }
		public string ColegioCurso { get; set; }
		public string ColegioLocalidad { get; set; }
		public int Comision { get; set; }
		public decimal Total { get; set; }

		public Contrato Contrato { get; set; }
	}
}
