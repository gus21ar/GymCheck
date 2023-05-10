
using Servicios.Data;

namespace Servicios.Dto
{
	public class CRedesDto : IRedes
	{
		public int Id { get; set; }
		public string Nombre { get; set; } = null!;
	}
}
