
using Servicios.Data;

namespace Servicios.Repositorio
{
	public interface IReporteRepo
	{
		List<IPersonaPdf> AsistenciasHoy();
		List<IPersonaPdf> AsistenciasFecha(DateTime periodoinicio,DateTime periodofin);
		List<IPagoPdf> PagosHoy();
		List<IPagoPdf> PagosFecha(DateTime periodoinicio,DateTime periodofin);
	}
}
