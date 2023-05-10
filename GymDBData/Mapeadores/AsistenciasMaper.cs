
using GymDBData.Entidades;
using Servicios.Data;

namespace GymDBData.Mapeadores
{
	public static class AsistenciasMaper
	{
		public static bool Map(IAsistencias Origen, Asistencia Destino)
		{
			try
			{
				Destino.Id = Origen.Id;
				Destino.IdCliente = Origen.IdCliente;
				Destino.Fecha = Origen.Fecha;
				return true;
			}
			catch { return false;}
		}
		public static bool Map(Asistencia Origen, IAsistencias Destino)
		{
			try
			{
				Destino.Id = Origen.Id;
				Destino.IdCliente = Origen.IdCliente;
				Destino.Fecha = Origen.Fecha;
				return true;
			}
			catch { return false;}
		}
	}
}
