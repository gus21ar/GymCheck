using Servicios.Data;

namespace Servicios.Dto
{
	public class CAsistenciaDto : IAsistencias
	{
		public int Id { get; set; }
		public int IdCliente { get; set; }
		public DateTime Fecha { get; set; }
	}
}
