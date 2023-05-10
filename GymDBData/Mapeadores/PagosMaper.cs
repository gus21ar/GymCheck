
using GymDBData.Entidades;
using Servicios.Data;
using GymDBData.Repositorio;

namespace GymDBData.Mapeadores
{
	public static class PagosMaper
	{
		public static bool Map(IPago Origen, Pago Destino)
		{
			CMediosRepo mediosRepo = new CMediosRepo();
			try
			{
				Destino.Id = Origen.Id;
				Destino.Monto = Origen.Monto;				
				Destino.IdMedioDePago = mediosRepo.ObtenerId(Origen.MedioDePago);
				Destino.Fecha = Origen.Fecha;
				Destino.IdCliente = Origen.IdCliente;
				return true;
			}
			catch { return false;}
		}
		public static bool Map(Pago Origen, IPago Destino)
		{
			CMediosRepo mediosRepo = new CMediosRepo();
			try
			{
				Destino.Id = Origen.Id;
				Destino.Monto = Origen.Monto;
				int aux = Origen.IdMedioDePago ?? 0;
				Destino.MedioDePago = mediosRepo.ObtenerMedio(aux);
				Destino.Fecha = Origen.Fecha;
				Destino.IdCliente = Origen.IdCliente??0;
				return true;
			}
			catch { return false;}
		}
	}
}
