
using Servicios.Data;

namespace Servicios.Dto
{
	public class CMediosDePagoDto :IMediosDePago
	{
		public int Id { get; set; }
		public string Nombre { get; set; } = string.Empty;
	}
	
	
}
