
using Servicios.Observer.Implementacion;

namespace Servicios.Observer
{
	public interface IPublicador
	{		
		void Suscribir(IObservador observador);
		void Desuscribir(IObservador observador);
		void Notificar(IAcceso acceso);
	}
}
