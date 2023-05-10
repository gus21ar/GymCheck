using Servicios.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Dto
{
	public class CPersonaPdf : IPersonaPdf
	{
		public string Nombre { get; set; }=string.Empty;
		public string Apellido { get; set; } = string.Empty;
		public string Dni { get; set; } = string.Empty;
		
		public CPersonaPdf(string nombre, string apellido, string dni)
		{
			Nombre = nombre;
			Apellido = apellido;
			Dni = dni;
		}
		public CPersonaPdf()
		{
		}
	}
}
