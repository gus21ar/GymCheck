
using Servicios.Data;

namespace Servicios.Repositorio
{
	public interface IPagoRepo
	{
		string LeyendaClienteDias(int dni);
		int DiasRestantes(int dni);
		bool HayPago(int dni);
		bool Pagar(IPago pago);
		List<string> Medios();
	}
}
