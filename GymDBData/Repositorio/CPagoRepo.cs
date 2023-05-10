using GymDBData.Entidades;
using GymDBData.Mapeadores;
using Servicios.Data;
using Servicios.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymDBData.Repositorio
{
	public class CPagoRepo : IPagoRepo
	{
		public int DiasRestantes(int dni)
		{
			if (HayPago(dni))
			{
				using (var contexto = new GymDbContext())
				{
					var cli = contexto.Clientes.FirstOrDefault(x => x.Dni == dni.ToString());
					if(cli == null)	return 0;					
					var ultimoPago = contexto.Pagos.Where(x => x.IdCliente == cli.Id).OrderByDescending(x => x.Fecha).FirstOrDefault();
					if (ultimoPago != null)
					{
						var fdpago = ultimoPago.Fecha.AddMonths(1);
						return (int)(fdpago - DateTime.Today ).TotalDays;
					}
					else
					{
						return -1;
					} 
				}
			}
			else
			{
				return -2;
			}
		}

		public bool HayPago(int dni)
		{
			bool respuesta = false;
			using (var contexto = new GymDbContext())
			{
				var cli = contexto.Clientes.FirstOrDefault(x => x.Dni == dni.ToString());
				if (cli != null) 
				respuesta = contexto.Pagos.Count(x => x.IdCliente == cli.Id) >0;
			}
			
			return respuesta;
		}

		public string LeyendaClienteDias(int dni)
		{
			string respuesta = string.Empty;
			try
			{
				using (var contexto = new GymDbContext())
				{					
					var cliente = contexto.Clientes.FirstOrDefault(x => x.Dni == dni.ToString());
					if (cliente != null)
					{
						respuesta = "Cliente: " + cliente.Nombre + " " + cliente.Apellido + " - ";
					}
					if (HayPago(dni))
					{
						respuesta += "Dias Restantes: " + DiasRestantes(dni).ToString();
					}
					else
					{
						respuesta += "Cliente no tiene pagos";
					}
				}					
			}
			catch
			{
				respuesta = "Cliente no Encontrado";
			}
			return respuesta;
		}

		public List<string> Medios()
		{
			List<string> list = new List<string>();
			using (var contexto = new GymDbContext())
			{
				list = contexto.MediosDePagos.Select(x => x.Nombre).ToList();
			}

			return list;
		}

		public bool Pagar(IPago pago)
		{
			bool respuesta = false;

			try
			{
				using (var contexto = new GymDbContext())
				{
					var aux = new Pago();
					PagosMaper.Map(pago, aux);
					contexto.Pagos.Add(aux);
					contexto.SaveChanges();
					respuesta = true;
				}
			}
			catch { }
			return respuesta;
		}
	}
}
