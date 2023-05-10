
namespace Servicios.Observer.Implementacion
{
	public class CAcceso : IAcceso
	{
		public string NombreCompleto { get; set; } = string.Empty;
		public string Dni { get; set; } = string.Empty;
		public string Mensaje { get; set; } = string.Empty;
		public Color Semaforo { get; set; } 
		public CAcceso()
		{

		}
	}	
}
