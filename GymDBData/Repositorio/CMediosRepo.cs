using GymDBData.Entidades;
using Servicios.Data;
using Servicios.Dto;
using Servicios.Repositorio;


namespace GymDBData.Repositorio
{
	public class CMediosRepo : IMedioRepo
	{
		public bool Agregar(string medio)
		{
			bool respuesta = false;
			try
			{
				using (var db = new GymDbContext())
				{
					var nuevoMedio = new MediosDePago
					{
						Nombre = medio
					};
					db.MediosDePagos.Add(nuevoMedio);					
					db.SaveChanges();
					respuesta = true;
				}
			}
			catch 
			{
				respuesta=false;
			}

			return respuesta;
		}
		public bool Eliminar(int id)
		{
			throw new NotImplementedException();
		}
		public IMediosDePago Obtener(int id)
		{
			throw new NotImplementedException();
		}
		public List<IMediosDePago> ObtenerTodos()
		{
			List<IMediosDePago> lista = new List<IMediosDePago>();
			using(var db = new GymDbContext())
			{
				var medios = db.MediosDePagos.ToList();
				foreach (var item in medios)
				{
					lista.Add(new CMediosDePagoDto
					{
						Id = item.Id,
						Nombre = item.Nombre
					});
				}
			}

			return lista;
		}
		public bool Modificar(int id, string medio)
		{
			throw new NotImplementedException();
		}

		public string ObtenerMedio(int id)
		{
			string respuesta = string.Empty;

			using (var db = new GymDbContext())
			{
				var medio = db.MediosDePagos.Where(x => x.Id == id).FirstOrDefault();
				if (medio != null)
				{
					respuesta = medio.Nombre;
				}
			}
			return respuesta;
		}

		public int ObtenerId(string medio)
		{
			int respusta = 0;
			using (var db = new GymDbContext())
			{
				var medioDb = db.MediosDePagos.Where(x => x.Nombre == medio).FirstOrDefault();
				if (medioDb != null)
				{
					respusta = medioDb.Id;
				}
			}
			return respusta;
		}
	}
}
