
using Servicios.Data;

namespace Servicios.Repositorio
{
	public interface IClienteRepo
	{
		bool Agregar (ICliente cliente);
		bool HayClientes (int dni);
		int ObtenerIdCliente (int dni);
		string ObtenerNombreCompleto (int id);
		bool AgregarRedes (int dni,List<IUsuariosRedes> listaRedes);
	}
}
