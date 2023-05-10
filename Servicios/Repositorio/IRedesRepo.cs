
using Servicios.Data;

namespace Servicios.Repositorio
{
	public interface IRedesRepo
	{
		IRedes ObtenerRedes(int id);
		bool AgregarRedes(string nombre);
		bool ModificarRedes(IRedes redes);
		bool EliminarRedes(int id);
		List<IRedes> ObtenerRedes();
		List<string> ObtenerNombresRedes();
	}
}
