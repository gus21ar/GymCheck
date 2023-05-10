
using Servicios.Observer.Attendance.Interfaces;

namespace Servicios.Observer.Attendance.Implementacion
{
	public class CPublicar : IPublicar
	{
		private static CPublicar _instancia;
		private readonly List<IObservar> _observadores;
		private CPublicar()
		{
			_observadores = new List<IObservar>();
		}
		public static CPublicar Instancia
		{
			get { return _instancia ?? (_instancia = new CPublicar()); }
		}
		public void Suscribir(IObservar oObservar)
		{
			_observadores.Add(oObservar);
		}
		public void Desuscribir(IObservar oObservar)
		{
			_observadores.Remove(oObservar);
		}
		public void Notificar()
		{
			foreach (var observador in _observadores)
			{
				observador.Actualizar();
			}
		}
	}	
}
