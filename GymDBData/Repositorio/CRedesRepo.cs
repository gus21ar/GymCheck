using GymDBData.Entidades;
using Servicios.Data;
using Servicios.Dto;
using Servicios.Repositorio;
namespace GymDBData.Repositorio
{
	public class CRedesRepo : IRedesRepo
	{
		public bool AgregarRedes(string nombre)
		{
			try
			{
				using (var db = new GymDbContext())
				{
					var redesSociales = new RedesSociale
					{
						NombreRed = nombre
					};
					db.RedesSociales.Add(redesSociales);
					db.SaveChanges();
					return true;
				}
			}
			catch (Exception)
			{
				return false;
			}
		}
		public bool EliminarRedes(int id)
		{
			throw new System.NotImplementedException();
		}
		public bool ModificarRedes(IRedes redes)
		{
			try
			{
				using (var db = new GymDbContext())
				{
					var redesSociales = db.RedesSociales.Find(redes.Id);
					if(redesSociales == null) return false;
					redesSociales.NombreRed = redes.Nombre;
					db.SaveChanges();
					return true;
				}
			}
			catch (Exception)
			{
				return false;
			}		
		}
		public IRedes ObtenerRedes(int id)
		{
			var respuesta = new CRedesDto();
			try
			{
				using (var db = new GymDbContext())
				{
					var redesSociales = db.RedesSociales.Find(id);
					if(redesSociales == null) return respuesta;
					respuesta.Id = redesSociales.Id;
					respuesta.Nombre = redesSociales.NombreRed;
				}
			}
			catch (Exception)
			{
				return respuesta;
			}
			return respuesta;
		}
		public List<IRedes> ObtenerRedes()
		{
			var lista = new List<IRedes>();
			try
			{
				using (var db = new GymDbContext())
				{
					var redesSociales = db.RedesSociales.ToList();
					foreach (var redes in redesSociales)
					{
						var aux = new CRedesDto
						{
							Id = redes.Id,
							Nombre = redes.NombreRed
						};
						lista.Add(aux);
					}
				}
			}
			catch 
			{
				return lista;
			} 

			return lista;
		}
		public List<string> ObtenerNombresRedes()
		{
			var lista = new List<string>();
			try
			{
				using (var db = new GymDbContext())
				{
					var redesSociales = db.RedesSociales.ToList();
					foreach (var redes in redesSociales)
					{
						lista.Add(redes.NombreRed);
					}
				}
			}
			catch 
			{
				return lista;
			}

			return lista;
		}
	}	
	
}
