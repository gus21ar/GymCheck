using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Data
{
	public interface IAsistencias
	{
		public int Id { get; set; }

		public int IdCliente { get; set; }

		public DateTime Fecha { get; set; }
	}
}
