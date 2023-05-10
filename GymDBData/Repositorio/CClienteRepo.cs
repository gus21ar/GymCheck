using Servicios.Data;
using Servicios.Repositorio;
using GymDBData.Mapeadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymDBData.Entidades;

namespace GymDBData.Repositorio
{
	public class CClienteRepo : IClienteRepo
	{
		public bool Agregar(ICliente cliente)
		{
			try
			{
				using (var db = new GymDbContext())
				{
					var clienteNuevo = new Cliente();
					ClienteMaper.Map(cliente, clienteNuevo);
					db.Clientes.Add(clienteNuevo);
					db.SaveChanges();
					return true;
				}
			}
			catch (Exception)
			{
				return false;
			}
		}

		public bool HayClientes(int dni)
		{
			bool hayClientes = false;
			try
			{
				using (var db = new GymDbContext())
				{
					var cliente = db.Clientes.Where(c => c.Dni == dni.ToString()).FirstOrDefault();					
						hayClientes = cliente != null;					
				}
			}
			catch
			{
				hayClientes = false;
			}
			return hayClientes;
		}

		public int ObtenerIdCliente(int dni)
		{
			int idCliente = 0;
			using (var db = new GymDbContext())
			{
				var cliente = db.Clientes.Where(c => c.Dni == dni.ToString()).FirstOrDefault();
				if (cliente != null)
				{
					idCliente = cliente.Id;
				}
				
			}
			return idCliente;
		}

		public string ObtenerNombreCompleto(int id)
		{
			string nombreCompleto = "";
			using (var db = new GymDbContext())
			{
				var cliente = db.Clientes.Where(c => c.Id == id).FirstOrDefault();
				if (cliente != null)
				{
					nombreCompleto = cliente.Nombre + " " + cliente.Apellido;
				}
			}
			return nombreCompleto;
		}

		public bool AgregarRedes(int dni, List<IUsuariosRedes> listaRedes)
		{
			bool respuesta = false;
			try
			{
				using (var db = new GymDbContext())
				{
					var cliente = db.Clientes.Where(c => c.Dni == dni.ToString()).FirstOrDefault();
					if (cliente != null)
					{
						foreach (var red in listaRedes)
						{
							var redNueva = new UsuarioRedCliente();
							redNueva.IdCliente = cliente.Id;
							redNueva.IdRed = db.RedesSociales.First(x => x.NombreRed == red.Red).Id;
							redNueva.Usuario = red.Usuario;
							db.UsuarioRedClientes.Add(redNueva);
						}
						db.SaveChanges();
						return true;
					}					
				}
			}
			catch { }
			return respuesta;
		}
	}
}

