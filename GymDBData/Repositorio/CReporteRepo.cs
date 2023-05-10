using GymDBData.Entidades;
using Servicios.Data;
using Servicios.Dto;
using Servicios.Repositorio;

namespace GymDBData.Repositorio
{
	public class CReporteRepo : IReporteRepo
	{
		public List<IPersonaPdf> AsistenciasFecha(DateTime periodoinicio, DateTime periodofin)
		{
			List<IPersonaPdf> asistencias = new List<IPersonaPdf>();
			using (GymDbContext db = new GymDbContext())
			{
				var aux = db.Asistencias.Where(x => x.Fecha >= periodoinicio && x.Fecha <= periodofin).Select(i => i.IdCliente).ToList();
				foreach (var item in aux)
				{
					var cliente = db.Clientes.Where(x => x.Id == item).FirstOrDefault();
					if (cliente != null)
						asistencias.Add(new CPersonaPdf
						{
							Nombre = cliente.Nombre,
							Apellido = cliente.Apellido,
							Dni = cliente.Dni
						});
				}

			}
			return asistencias;
		}

		public List<IPersonaPdf> AsistenciasHoy()
		{
			List<IPersonaPdf> asistencias = new List<IPersonaPdf>();

			using (GymDbContext db = new GymDbContext())
			{
				var aux = db.Asistencias.Where(x => x.Fecha == DateTime.Today).Select(i => i.IdCliente).ToList();
				foreach (var item in aux)
				{
					var cliente = db.Clientes.Where(x => x.Id == item).FirstOrDefault();
					if (cliente != null)
						asistencias.Add(new CPersonaPdf
						{
							Nombre = cliente.Nombre,
							Apellido = cliente.Apellido,
							Dni = cliente.Dni
						});
				}

			}
			return asistencias;
		}

		public List<IPagoPdf> PagosFecha(DateTime periodoinicio, DateTime periodofin)
		{
			List<IPagoPdf> pagoPdfs = new List<IPagoPdf>();
			using(var db = new GymDbContext())
			{
				var aux = db.Pagos.Where(x => x.Fecha > periodoinicio && x.Fecha <= periodofin).ToList();
				if(aux != null)
				{
					foreach (var item in aux)
					{
						var cliente = db.Clientes.Where(x => x.Id == item.IdCliente).FirstOrDefault();
						var medio = db.MediosDePagos.Where(x => x.Id == item.IdMedioDePago).First();
						var NombreMedio = medio.Nombre;
						if (cliente != null)
							pagoPdfs.Add(new CPagoPdf
							{
								Nombre = cliente.Nombre + " " + cliente.Apellido,
								Dni = cliente.Dni,
								Monto = item.Monto.ToString() ?? "0",
								Fecha = item.Fecha.ToString("yyyy'/'MM'/'dd") ?? "0",
								Medio = NombreMedio
							});
					}
				}
			}
			return pagoPdfs;
		}

		public List<IPagoPdf> PagosHoy()
		{
			List<IPagoPdf> pagoPdfs = new List<IPagoPdf>();
			using (GymDbContext db = new GymDbContext())
			{
				var aux = db.Pagos.Where(x => x.Fecha == DateTime.Today).ToList();
				if(aux != null)
				foreach (var item in aux)
				{
					var cliente = db.Clientes.Where(x => x.Id == item.IdCliente).FirstOrDefault();
					var medio = db.MediosDePagos.Where(x => x.Id == item.IdMedioDePago).First();
					var NombreMedio = medio.Nombre;
					if (cliente != null)
						pagoPdfs.Add(new CPagoPdf
						{
							Nombre = cliente.Nombre + " " + cliente.Apellido,							
							Dni = cliente.Dni,
							Monto = item.Monto.ToString()??"0",
							Fecha = item.Fecha.ToString("yyyy'/'MM'/'dd") ?? "0",
							Medio = NombreMedio							
						});
				}
			}
			return pagoPdfs;
		}
	}
}
