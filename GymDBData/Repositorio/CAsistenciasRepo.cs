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
	public class CAsistenciasRepo : IAsistenciasRepo
	{
		public bool Agregar(IAsistencias asistencia)
		{
			
			try
			{
				using (GymDbContext db = new GymDbContext())
				{
					var aux = new Asistencia();
					AsistenciasMaper.Map(asistencia, aux);
					db.Asistencias.Add(aux);
					db.SaveChanges();
					return true;
				}
			}
			catch 
			{
				return false;
			}


		}
	}
	
	
}
