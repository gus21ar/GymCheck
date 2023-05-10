using Servicios.Data;

namespace Servicios.Dto
{
	public class CPagoPdf : IPagoPdf
	{
		public string Nombre { get; set; } = string.Empty;
		public string Dni { get; set; } = string.Empty;
		public string Fecha { get; set; } = string.Empty;
		public string Monto { get; set; } = string.Empty;
		public string Medio { get; set; } = string.Empty;
	}
}
