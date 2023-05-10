using Servicios.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Dto
{
	public class CClienteDto : ICliente
	{
		public int Id { get; set; }
		public string Nombre { get; set; }= null!;
		public string? Apellido { get; set; }
		public string? Dni { get; set; }
		public string? Direccion { get; set; }
		public string? Telefono { get; set; }
		public string? Mail { get; set; }
		public DateTime? FechaNacimiento { get; set; }
		public DateTime? FechaInscripcion { get; set; }
		public string? RutaFoto { get; set; }
		public string? Comentario { get; set; }
	}
}
