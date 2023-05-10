
using GymDBData.Entidades;
using Servicios.Data;

namespace GymDBData.Mapeadores
{
	public static class ClienteMaper
	{
		public static bool Map(ICliente Origen, Cliente Destino)
		{
			try
			{
				Destino.Id = Origen.Id;
				Destino.Nombre = Origen.Nombre;
				Destino.Apellido = Origen.Apellido;
				Destino.Dni = Origen.Dni;
				Destino.FechaNacimiento = Origen.FechaNacimiento;
				Destino.FechaInscripcion = Origen.FechaInscripcion;
				Destino.Comentario = Origen.Comentario;							
				Destino.Direccion = Origen.Direccion;
				Destino.Telefono = Origen.Telefono;
				Destino.Mail = Origen.Mail;
				Destino.RutaFoto = Origen.RutaFoto;
				return true;
			}
			catch { return false;}
		}
		public static bool Map(Cliente Origen, ICliente Destino)
		{
			try
			{
				Destino.Id = Origen.Id;
				Destino.Nombre = Origen.Nombre;
				Destino.Apellido = Origen.Apellido;
				Destino.Dni = Origen.Dni;
				Destino.FechaNacimiento = Origen.FechaNacimiento;
				Destino.FechaInscripcion = Origen.FechaInscripcion;
				Destino.Comentario = Origen.Comentario;
				Destino.Direccion = Origen.Direccion;
				Destino.Telefono = Origen.Telefono;
				Destino.Mail = Origen.Mail;
				Destino.RutaFoto = Origen.RutaFoto;
				return true;
			}
			catch { return false;}
		}
	}
}
