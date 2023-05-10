using Servicios.Data;

namespace Servicios.Dto
{
	public class CPagoDto : IPago
	{
		public int Id { get; set; }
		public double? Monto { get; set; }
		public string MedioDePago { get; set; }=string.Empty;
		public DateTime Fecha { get; set; }
		public int IdCliente { get; set; }
	}
}
