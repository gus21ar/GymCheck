
using Servicios.Data;

namespace Servicios.Repositorio
{
	public interface IMedioRepo
	{
		bool Agregar(string medio);
		bool Modificar(int id, string medio);
		bool Eliminar(int id);
		IMediosDePago Obtener(int id);
		string ObtenerMedio(int id);
		int ObtenerId(string medio);
		List<IMediosDePago> ObtenerTodos();
	}
}
