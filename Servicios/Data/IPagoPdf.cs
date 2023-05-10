
namespace Servicios.Data
{
	public interface IPagoPdf
	{
		string Nombre { get; set; }		
		string Dni { get; set; }
		string Fecha { get; set; }
		string Monto { get; set; }
		string Medio { get; set; }
	}
}
