
namespace Servicios.Observer.Attendance.Interfaces
{
	public interface IPublicar
	{
		void Suscribir(IObservar oObservar);
		void Desuscribir(IObservar oObservar);
		void Notificar();
	}
}
