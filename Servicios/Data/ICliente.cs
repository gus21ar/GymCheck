namespace Servicios.Data
{
	public interface ICliente
	{
		public int Id { get; set; }

		public string Nombre { get; set; }

		public string? Apellido { get; set; }

		public string? Dni { get; set; }

		public string? Direccion { get; set; }

		public string? Telefono { get; set; }

		public string? Mail { get; set; }

		public DateTime? FechaNacimiento { get; set; }

		public DateTime? FechaInscripcion { get; set; }

		public string? RutaFoto { get; set; }

		public string? Comentario { get; set; }
	}
}
