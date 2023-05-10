using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Data
{
	public interface IPago
	{
		int Id { get; set; }
		double? Monto { get; set; }
		string MedioDePago { get; set; }
		DateTime Fecha { get; set; }
		int IdCliente { get; set; }
	}
}
